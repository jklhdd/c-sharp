using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace as5
{
    class KHNN : KH
    {
        private string quocTich;

        public string QuocTich { get => quocTich; set => quocTich = value; }

        public KHNN()
        {
        }

        public KHNN(int id, string ten, DateTime ngayXuat, float sl, string quocTich)
            : base(id, ten, ngayXuat, sl)
        {
            QuocTich = quocTich;
            ThanhTien = CalMoney();
        }

        new public double CalMoney()
        {
            return Sl * 2000;
        }

        public void inputInfo()
        {
            Console.WriteLine("Nhap ID: ");
            Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap ngay: ");
            NgayXuat = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy" , CultureInfo.InvariantCulture);
            Console.WriteLine("Nhap so luong: ");
            Sl = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap quoc tich: ");
            QuocTich = Console.ReadLine();            
            ThanhTien = CalMoney();
        }

        public void getInfo()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Ten: " + Ten);
            Console.WriteLine("Ngay: " + NgayXuat.ToString("MM/dd/yyyy"));
            Console.WriteLine("So luong: " + Sl);
            Console.WriteLine("Quoc tich: " + QuocTich);
            Console.WriteLine("Thanh tien: " + ThanhTien);
        }

    }
}
