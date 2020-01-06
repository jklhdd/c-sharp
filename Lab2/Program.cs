using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    public delegate void de1(string s);
    class Program
    {
        static void Main(string[] args)
        {
            Product a = new Product("ao", 13000, 12, "bb", new List<string>() { "1"});
            a.getInfo();
            a.Qty -= 2;
            Product c = new Product("quan", 12000, 12, "aa",new List<string>() { "1","2"});
            c.getInfo();
            Cart b = new Cart("Long","HN","VN");
            b.addP(a);
            b.addP(c);
            b.showCart();

        }
    }
}
