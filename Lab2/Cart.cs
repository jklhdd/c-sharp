using System;
using System.Collections.Generic;

namespace Lab2
{
    class Cart
    {
        private int id;
        private string name;
        private double grandTotal;
        private List<Product> pList;
        private string cty;
        private string country;

        public event de1 addProduct;

        private static int sID = 100;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double GrandTotal { get => grandTotal; set => grandTotal = value; }
        public List<Product> PList { get => pList; set => pList = value; }
        public string Cty { get => cty; set => cty = value; }
        public string Country { get => country; set => country = value; }

        public Cart()
        {
            this.Id = sID++;
            this.PList = new List<Product>();
        }

        public Cart(string name, string cty, string country)
        {
            this.Id = sID++;
            this.Name = name;
            this.PList = new List<Product>();
            this.Cty = cty;
            this.Country = country;
        }

        public void addP(Product p)
        {
            
            this.PList.Add(p);
            this.GrandTotal = this.calMoney();
            if(addProduct == null)
            {
                addProduct += Notification;
            }
            addProduct("Them san pham thanh cong");
        }
        public List<Product> delP(int i)
        {
            this.PList.RemoveAt(i-1);
            this.GrandTotal = this.calMoney();
            return this.PList;
        }

        public double calMoney()
        {
            double ship;
            double grandT = 0;
            if (this.Cty == "HCM" || this.Cty == "HN") ship = 0.01;
            else if (this.Country == "VN") ship = 0.05;
            else ship = 0.02;
            foreach(Product p in this.PList)
            {
                grandT += p.Price;
            }
            return grandT= grandT + grandT * ship;
        }

        public static void Notification(string msg)
        {
            Console.WriteLine(msg);
        }

        public void showCart()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Cty);
            Console.WriteLine(this.Country);
            Console.WriteLine(this.GrandTotal);
            foreach(Product p in this.PList)
            {
                p.getInfo();
            }

        }
    }
}
