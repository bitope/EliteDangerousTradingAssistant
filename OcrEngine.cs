using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tesseract;

namespace EliteDangerousTradingAssistant
{
    public static class Util
    {
        public static String PrettyString(this String fixMe)
        {
            if (fixMe == null)
                return null;

            fixMe = fixMe.Trim();
            string chars = " \t\n\v\f\r-";
            int i = 0;
            string properExpression = "";
            int lenExpression = fixMe.Length;
            int flag = 1;
            string symbol = "";

            while (i < lenExpression)
            {
                symbol = fixMe.Substring(i, 1).ToLower();
                if (symbol.IndexOfAny(chars.ToCharArray()) != -1)
                {
                    flag = 1;
                }
                else
                {
                    if (flag == 1)
                    {
                        symbol = fixMe.Substring(i, 1).ToUpper();
                        flag = 0;
                    }
                }
                properExpression = properExpression + symbol;
                i++;
            }

            return properExpression;
        }

    }

    public static class OcrEngine
    {
        public static List<string> Processed;
        public static List<OcrCommodity> Commodities;
        public static Mutex isProcessing;

        static OcrEngine()
        {
            isProcessing = new Mutex();
            Processed = new List<string>();
            Commodities = new List<OcrCommodity>();
        }

        public class OcrCommodity
        {
            public string Station { get; set; }
            public string Commodity { get; set; }
            public int Buy { get; set; }
            public int Sell { get; set; }
            public int Cargo { get; set; }
            public int Demand { get; set; }
            public int Supply { get; set; }
            public int Average { get; set; }
            public string System { get; set; }
        }

        public static bool IsProcessed(string image)
        {
            isProcessing.WaitOne(-1);
            isProcessing.ReleaseMutex();
            return Processed.Contains(image);
        }

        public static void ProcessImage2(string image)
        {
            isProcessing.WaitOne(-1);
            int top = 490;
            int bottom = 1948;
            int[] columns = { 154, 894, 1069, 1244, 1429, 1795, 2199, 2590 };

            Bitmap b = (Bitmap)Bitmap.FromFile(image);
            Graphics g = Graphics.FromImage(b);
            TesseractEngine tess = new TesseractEngine("", "fed", EngineMode.Default);

            Pix pix;
            using (var xz = tess.Process(b))
            {
                pix = xz.Image;
                pix = pix.ConvertRGBToGray(1.5f, 1.0f, 0.0f);
                //pix = pix.BinarizeOtsuAdaptiveThreshold(pix.Width / 5, pix.Height / 5, 15, 15, 0.2f);
                //pix.Save(image + ".png", ImageFormat.Png);
            }

            Rect stationName = new Rect(161, 133, 1600, 61);
            string StationName = "";
            Pen p1 = new Pen(Color.Red, 5);
            using (var xx = tess.Process(pix, stationName, PageSegMode.SingleLine))
            {
                g.DrawRectangle(p1, new Rectangle(stationName.X1, stationName.Y1, stationName.Width, stationName.Height));
                StationName = xx.GetText().Replace('\n', ' ').Trim();
            }

            if (String.IsNullOrEmpty(StationName))
            {
                Processed.Add(image);
                isProcessing.ReleaseMutex();
                return;
            }

            // Find lines
            List<Rect> lineRects = new List<Rect>();
            Rect searchRect = new Rect(columns[6] - 5, top - 5, columns[7] - columns[6] + 10, bottom - top + 10);
            g.DrawRectangle(p1, new Rectangle(searchRect.X1, searchRect.Y1, searchRect.Width, searchRect.Height));
            using (var xx = tess.Process(pix, searchRect, PageSegMode.SingleBlock))
            {
                using (var i = xx.GetIterator())
                {
                    i.Begin();
                    do
                    {
                        Rect bb;
                        if (i.TryGetBoundingBox(PageIteratorLevel.TextLine, out bb))
                        {
                            Pen p = new Pen(Color.Green, 5);
                            lineRects.Add(new Rect(columns[0], bb.Y1 - 10, columns[7] - columns[0], bb.Height + 20));
                            g.DrawRectangle(p, new Rectangle(columns[0], bb.Y1 - 10, columns[7] - columns[0], bb.Height + 20));
                        }
                    } while (i.Next(PageIteratorLevel.TextLine));
                }
            }

            foreach (var lineRect in lineRects)
            {
                OcrCommodity m = new OcrCommodity();
                string[] tempM = new string[7];
                float confidence = 0;

                for (int c = 0; c < 7; c++)
                {
                    Rect cell = new Rect(columns[c], lineRect.Y1, columns[c + 1] - columns[c], lineRect.Height);
                    using (var xx = tess.Process(pix, cell, PageSegMode.SingleBlock))
                    {
                        tempM[c] = xx.GetText().Replace('\n', ' ').Trim();
                        float v = xx.GetMeanConfidence();

                        if (c != 0)
                        {
                            tempM[c] = tempM[c].Replace(".", "").Replace(",", "").Replace(" ", "");
                            tempM[c] = tempM[c].Replace("O", "0");
                            tempM[c] = tempM[c].Replace("B", "8");
                            tempM[c] = tempM[c].Replace("MED", "");
                            tempM[c] = tempM[c].Replace("LOW", "");
                            tempM[c] = tempM[c].Replace("CR", "");
                            tempM[c] = tempM[c].Replace("HIGH", "").Trim();
                        }
                        confidence += v;
                    }
                }

                int tmp = 0;

                m.System = "";
                m.Station = StationName.PrettyString();
                m.Commodity = tempM[0].PrettyString();
                if (Int32.TryParse(tempM[1], out tmp)) m.Sell = tmp;
                if (Int32.TryParse(tempM[2], out tmp)) m.Buy = tmp;
                m.Cargo = 0;
                if (Int32.TryParse(tempM[4].Split(' ')[0], out tmp)) m.Demand = tmp;
                if (Int32.TryParse(tempM[5].Split(' ')[0], out tmp)) m.Supply = tmp;
                if (Int32.TryParse(tempM[6].Split(' ')[0], out tmp)) m.Average = tmp;

                var dupe = Commodities.SingleOrDefault(i => i.Station == m.Station && i.Commodity == m.Commodity);
                if (dupe != null)
                {
                    dupe.Sell = m.Sell;
                    dupe.Buy = m.Buy;
                    dupe.Demand = m.Demand;
                    dupe.Supply = m.Supply;
                    dupe.Average = m.Average;
                }
                else
                {
                    Commodities.Add(m);
                }
            }

            Processed.Add(image);
            isProcessing.ReleaseMutex();
        }



    }
}
