using System;
using System.Collections.Generic;
using System.Text;

namespace as5
{
    class QLVN
    {
        List<KHVN> khList = new List<KHVN>();

        public QLVN()
        {
        }

        public QLVN(List<KHVN> khList)
        {
            KhList = khList;
        }

        internal List<KHVN> KhList { get => khList; set => khList = value; }

        public void addKH(KHVN kh)
        {            
            KhList.Add(kh);
        }

        public float totalQ()
        {
            float total = 0;
            foreach (KHVN k in KhList)
            {
                total += k.Sl;
            }
            return total;
        }

        public void getInfo()
        {
            int count = 0;
            Console.WriteLine("Nhap thang va nam gioi han: (MM/yyyy)"); 
            String[] s = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            foreach (KHVN k in KhList)
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
