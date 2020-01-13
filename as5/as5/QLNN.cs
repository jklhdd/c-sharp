using System;
using System.Collections.Generic;
using System.Text;

namespace as5
{
    class QLNN
    {
        private List<KHNN> listKH = new List<KHNN>();

        public QLNN()
        {
        }

        public QLNN(List<KHNN> listKH)
        {
            this.ListKH = listKH;
        }
        internal List<KHNN> ListKH { get => listKH; set => listKH = value; }

        public void addKH(KHNN k)
        {            
            ListKH.Add(k);            
        }

        public float totalQ()
        {
            float total = 0;
            foreach(KHNN k in ListKH)
            {
                total += k.Sl;
            }
            return total;
        }

        public double avgCal()
        {
            double total = 0;
            foreach (KHNN k in ListKH)
            {
                total += k.ThanhTien;
            }
            return total / ListKH.Count;
        }

        public void getInfo()
        {
            int count = 0;
            Console.WriteLine("Nhap thang va nam gioi han: (MM/yyyy)");
            String[] s = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            foreach (KHNN k in ListKH)
            {
                if (k.NgayXuat.Month == Convert.ToInt32(s[0]) && k.NgayXuat.Year == Convert.ToInt32(s[1]))
                {
                    k.getInfo();
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("Khong co hoa don phu hop");
        }
    }
}
