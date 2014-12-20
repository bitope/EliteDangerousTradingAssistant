using System;

namespace EliteDangerousTradingAssistant
{

    public class Commodity
    {
        private string name;
        private decimal buyPrice;
        private decimal sellPrice;
        private decimal supply;
        private decimal demand;
        private decimal galacticAverage;
        private DateTime lastUpdated;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }
        public decimal SellPrice
        {
            get { return sellPrice; }
            set { sellPrice = value; }
        }
        public decimal Supply
        {
            get { return supply; }
            set { supply = value; }
        }
        public decimal Demand
        {
            get { return demand; }
            set { demand = value; }
        }
        public decimal Average
        {
            get { return galacticAverage; }
            set { galacticAverage = value; }
        }

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }

        public Commodity()
        {
        }

        public Commodity(Commodity copy)
        {
            name = copy.Name;
            buyPrice = copy.BuyPrice;
            sellPrice = copy.SellPrice;
            supply = copy.supply;
            demand = copy.demand;
            galacticAverage = copy.galacticAverage;
            lastUpdated = copy.LastUpdated;
        }

        public bool Equals(Commodity compareTo)
        {
            if (name != compareTo.Name || buyPrice != compareTo.BuyPrice || sellPrice != compareTo.SellPrice || supply != compareTo.Supply || supply != compareTo.Demand)
                return false;

            return true;
        }
    }
}
