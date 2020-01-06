using System.Collections.Generic;

namespace Lab2
{
    class Cart
    {
        private int id;
        private string name;
        private double grandTotal;
        private List<Product> pList = new List<Product>();
        private string cty;
        private string country;

        private static int sID = 100;

        public Cart()
        {
            this.id = sID++;
        }

        public Cart(string name, List<Product> pList, string cty, string country)
        {
            this.id = sID++;
            this.name = name;
            this.pList = pList;
            this.cty = cty;
            this.country = country;
            this.grandTotal = this.calMoney();
        }

        public void addP(Product p)
        {
            this.pList = new List<Product>();
            this.pList.Add(p);
            this.grandTotal = this.calMoney();
        }
        public List<Product> delP(int i)
        {
            this.pList.RemoveAt(i-1);
            this.grandTotal = this.calMoney();
            return this.pList;
        }

        public double calMoney()
        {
            double ship;
            double grandT = 0;
            if (this.cty == "HCM" || this.cty == "HN") ship = 0.01;
            else if (this.country == "VN") ship = 0.05;
            else ship = 0.02;
            foreach(Product p in this.pList)
            {
                grandT += p.Price;
            }
            return grandT= grandT + grandT * ship;
        }

        

    }
}
