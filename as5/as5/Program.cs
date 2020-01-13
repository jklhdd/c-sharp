using System;

namespace as5
{
    class Program
    {
        static void Main(string[] args)
        {
            KHVN k1 = new KHVN(0, "Long", new DateTime(2020, 01, 10), 220, "sinh hoat");
            KHNN k2 = new KHNN(0, "Annie", new DateTime(2020, 01, 10), 220, "Anh");            
            KHVN k3 = new KHVN(0, "Lana", new DateTime(2020, 02, 10), 220, "sinh hoat");
            QLVN qLVN = new QLVN();
            QLNN qlNN = new QLNN();
            qLVN.addKH(k1);
            qLVN.addKH(k3);
            qlNN.addKH(k2);
            qLVN.getInfo();
            qlNN.getInfo();
        }
    }
}
