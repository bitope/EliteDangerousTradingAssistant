using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliteDangerousTradingAssistant
{
    public class OCRData
    {
        public string System { get; set; }
        public string Station { get; set; }
        public string Commodity { get; set; }
        public int Sell { get; set; }
        public int Buy { get; set; }
        public int Demand { get; set; }
        public string DemandText { get; set; }
        public int Supply { get; set; }
        public string SupplyText { get; set; }
        public string Date { get; set; }
    }

    public static class DataImport
    {
        static DataImport()
        {
            
        }

        private static int parseNumber(string s)
        {
            int x = 0;
            Int32.TryParse(s, out x);
            return x;
        }

        public static void ImportCSV(GameData data, string filename)
        {
            using (var fstream = File.OpenText(filename))
            {
                while (!fstream.EndOfStream)
                {
                    string line = fstream.ReadLine();
                    var x = line.Split(';');

                    if (x[0]=="System") 
                        continue;

                    var item = new OCRData();
                    item.System = x[0];
                    item.Station = x[1];
                    item.Commodity = x[2];
                    item.Sell = parseNumber(x[3]);
                    item.Buy = parseNumber(x[4]);
                    item.Demand = parseNumber(x[5]);
                    item.DemandText = x[6];
                    item.Supply = parseNumber(x[7]);
                    item.SupplyText = x[8];
                    item.Date = x[9];

                    foreach (var system in data.StarSystems)
                    {
                        if (item.System=="" || String.Equals(system.Name,item.System,StringComparison.InvariantCultureIgnoreCase))
                            foreach (var station in system.Stations)
                            {
                                if (String.Equals(station.Name, item.Station, StringComparison.InvariantCultureIgnoreCase))
                                {
                                    var commodity = station.Commodities.FirstOrDefault(i => String.Equals(i.Name, item.Commodity, StringComparison.InvariantCultureIgnoreCase));
                                    if (commodity != null)
                                    {
                                        commodity.BuyPrice = item.Buy;
                                        commodity.SellPrice = item.Sell;
                                        commodity.Supply = item.Supply;
                                        commodity.LastUpdated = DateTime.Now;
                                    }
                                    else
                                    {
                                        commodity = new Commodity
                                                    {
                                                        Name = item.Commodity,
                                                        BuyPrice = item.Buy, 
                                                        SellPrice = item.Sell, 
                                                        Supply = item.Supply, 
                                                        LastUpdated = DateTime.Now
                                                    };
                                        station.Commodities.Add(commodity);
                                    }
                                }
                            }
                    }

                }
            }
        }

        public static bool ImportOcrData(GameData data)
        {
            bool needUpdate = false;

            foreach (var item in OcrEngine.Commodities)
            {
                //data.StarSystems.ForEach(i => Enumerable.Where(i.Stations, j => String.Equals(j.Name, item.System, StringComparison.InvariantCultureIgnoreCase)));
                List<Station> stations = new List<Station>();
                foreach (var s in data.StarSystems)
                {
                    stations.AddRange(s.Stations);
                }
                if (!stations.Exists(i => String.Equals(i.Name, item.Station, StringComparison.InvariantCultureIgnoreCase)))
                {
                    var s = new StarSystem {Name = "Unknown"};
                    if (!data.StarSystems.Exists(i => i.Name == "Unknown"))
                    {
                        data.StarSystems.Add(s);
                    }
                    else
                    {
                        s = data.StarSystems.Single(i => i.Name == "Unknown");
                    }

                    Station tmpStation = new Station();
                    tmpStation.Name = item.Station;
                    s.Stations.Add(tmpStation);
                    needUpdate = true;
                    //MessageBox.Show("Warning! Importing OCR data failed. No Station with that name: " + item.Station);
                    //return;
                }

                foreach (var system in data.StarSystems)
                {
                    if (item.System == "" || String.Equals(system.Name, item.System, StringComparison.InvariantCultureIgnoreCase))
                        foreach (var station in system.Stations)
                        {
                            if (String.Equals(station.Name, item.Station, StringComparison.InvariantCultureIgnoreCase))
                            {
                                var commodity = station.Commodities.FirstOrDefault(i => String.Equals(i.Name, item.Commodity, StringComparison.InvariantCultureIgnoreCase));
                                if (commodity != null)
                                {
                                    commodity.BuyPrice = item.Buy;
                                    commodity.SellPrice = item.Sell;
                                    commodity.Supply = item.Supply;
                                    commodity.Demand = item.Demand;
                                    commodity.Average = item.Average;
                                    commodity.LastUpdated = DateTime.Now;
                                }
                                else
                                {
                                    commodity = new Commodity
                                    {
                                        Name = item.Commodity,
                                        BuyPrice = item.Buy,
                                        SellPrice = item.Sell,
                                        Supply = item.Supply,
                                        Demand = item.Demand,
                                        Average = item.Average,
                                        LastUpdated = DateTime.Now
                                    };
                                    station.Commodities.Add(commodity);
                                }

                            }
                        }
                }
            }
            OcrEngine.Commodities.Clear();
            return needUpdate;
        }
    }
}
