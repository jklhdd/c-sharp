using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private int qty;
        private String desc;
        private List<String> gall = new List<string>();

        private static int sID = 100;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }
        public string Desc { get => desc; set => desc = value; }
        public List<string> Gall { get => gall; set => gall = value; }

        public Product(string name, double price, int qty, string desc, List<string> gall)
        {
            this.Id = sID++;
            this.Name = name;
            this.Price = price;
            this.Qty = qty;
            this.Desc = desc;
            this.Gall = gall;
        }

        public Product()
        {
            this.Id = sID++;
        }

        public void getInfo(){
            Console.WriteLine("Thông tin sản phẩm:");
            Console.WriteLine("ID sản phẩm:" + Id);
            Console.WriteLine("Tên sản phẩm:" + Name);
            Console.WriteLine("Giá sản phẩm:" + Price);
            Console.WriteLine("Số lượng sản phẩm:" + Qty);
            Console.WriteLine("Mô tả sản phẩm:" + Desc);
            Console.WriteLine("Ảnh sản phẩm:");
            foreach(String t in Gall){
                Console.WriteLine(t);
            }

        }

        public void setInfo(){
            Console.WriteLine("Nhập thông tin sản phẩm:");    
            Console.WriteLine("Tên sản phẩm:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Giá sản phẩm:");
            this.Price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Số lượng sản phẩm:");
            this.Qty = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mô tả sản phẩm:");
            this.Desc = Console.ReadLine();
            this.addImg();        

        }

        public void addImg(){
            int i = 0;
            int index;
            String s;
            while(true){
                if (i == 3)
                {
                    Console.WriteLine("Thư viện đầy,chọn ảnh thay thế");
                    index = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập ảnh mới:");
                    s = Console.ReadLine();
                    this.Gall.RemoveAt(index-1);
                    this.Gall.Insert(index, s);
                    Console.WriteLine("Dừng nhập ảnh? (Y/N)");
                    String yn = Console.ReadLine();
                    if (yn == "Y" || yn == "y") break;
                }
                else {
                    Console.WriteLine("Nhập ảnh mới:");
                    this.Gall.Add(Console.ReadLine());
                    Console.WriteLine("Dừng nhập ảnh? (Y/N)");
                    String yn = Console.ReadLine();
                    if (yn == "Y" || yn == "y") break;
                    i++;
                }
                                                  
            }
        }

        public void deleteImg(){
            int i = 0;
            foreach (String img in this.Gall)
            {
                Console.WriteLine(i+":"+img);            
            }
            Console.WriteLine("Chọn ảnh xóa:");
            int index = Int32.Parse(Console.ReadLine());
            this.Gall.RemoveAt(index-1);            
        }

        public bool checkQty(){
            return (this.Qty>0) ? true : false;
        }

    }
}