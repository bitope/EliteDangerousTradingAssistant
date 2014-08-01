using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EliteDangerousTradingAssistant
{
    public partial class AddEditCommodityDialog : Form
    {
        private Commodity result;
        private List<StarSystem> systems;

        public Commodity Result
        {
            get { return result; }
            set { result = value; }
        }

        public AddEditCommodityDialog(string system, string station, List<StarSystem> systems)
        {
            InitializeComponent();
            this.Icon = new Icon("Graphics\\EliteDangerousIcon.ico");

            SystemTextBox.Text = system;
            StationTextBox.Text = station;
            result = null;
            this.systems = systems;

            
            var uniqueCommodities = new AutoCompleteStringCollection();
            uniqueCommodities.AddRange(ExistingCommodities().ToArray());

            CommodityTextBox.AutoCompleteCustomSource = uniqueCommodities;
        }

        public AddEditCommodityDialog(string system, string station, List<StarSystem> systems, Commodity commodity)
        {
            InitializeComponent();
            this.Icon = new Icon("Graphics\\EliteDangerousIcon.ico");

            SystemTextBox.Text = system;
            StationTextBox.Text = station;
            result = commodity;
            this.systems = systems;

            CommodityTextBox.Text = commodity.Name;
            BuyTextBox.Text = commodity.BuyPrice.ToString("n0");
            SellTextBox.Text = commodity.SellPrice.ToString("n0");
            SupplyTextBox.Text = commodity.Supply.ToString("n0");
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CommodityTextBox.Text))
            {
                MessageBox.Show("Please provide the commodity name.", "Error: Commodity name needed.", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(BuyTextBox.Text))
            {
                MessageBox.Show("Please provide the commodity buy price.", "Error: Commodity buy price needed.", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(SellTextBox.Text))
            {
                MessageBox.Show("Please provide the commodity sell price.", "Error: Commodity sell price needed.", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrEmpty(SupplyTextBox.Text))
            {
                MessageBox.Show("Please provide the commodity supply.", "Error: Commodity supply needed.", MessageBoxButtons.OK);
                return;
            }

            result = new Commodity();
            result.Name = CommodityTextBox.Text;

            decimal buyPrice = 0;
            decimal.TryParse(BuyTextBox.Text, out buyPrice);
            result.BuyPrice = buyPrice;

            decimal sellPrice = 0;
            decimal.TryParse(SellTextBox.Text, out sellPrice);
            result.SellPrice = sellPrice;

            decimal supply = 0;
            decimal.TryParse(SupplyTextBox.Text, out supply);
            result.Supply = supply;

            this.Close();
        }

        private List<string> ExistingCommodities()
        {
            var uniqueCommodityNames = new List<string>();

            foreach (StarSystem system in systems)
                foreach (Station station in system.Stations)
                    foreach (Commodity commodity in station.Commodities)
                        if (uniqueCommodityNames.Contains(commodity.Name) == false)
                            uniqueCommodityNames.Add(commodity.Name);

            uniqueCommodityNames.Sort();
            return uniqueCommodityNames;
        }

        private void BuyTextBox_TextChanged(object sender, EventArgs e)
        {
            SupplyTextBox.Text = 10000.ToString();
        }
    }
}
