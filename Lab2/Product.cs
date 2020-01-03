using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Product
    {
        private int id;
        private String name;
        private double price;
        private int qty;
        private String desc;
        private List<String> gall;

        private static int sID = 100;

        public Product(string name, double price, int qty, string desc, List<string> gall)
        {
            this.id = sID++;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.desc = desc;
            this.gall = gall;
        }

        public Product()
        {
            this.id = sID++;
        }

        public void getInfo(){
            Console.WriteLine("Thông tin sản phẩm:");
            Console.WriteLine("ID sản phẩm:" + id);
            Console.WriteLine("Tên sản phẩm:" + name);
            Console.WriteLine("Giá sản phẩm:" + price);
            Console.WriteLine("Số lượng sản phẩm:" + qty);
            Console.WriteLine("Mô tả sản phẩm:" + desc);
            Console.WriteLine("Ảnh sản phẩm:");
            foreach(String t in gall){
                Console.WriteLine(t);
            }

        }

        public void setInfo(){
            Console.WriteLine("Nhập thông tin sản phẩm:");    
            Console.WriteLine("Tên sản phẩm:");
            this.name = Console.ReadLine();
            Console.WriteLine("Giá sản phẩm:");
            this.price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Số lượng sản phẩm:");
            this.qty = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mô tả sản phẩm:");
            this.desc = Console.ReadLine();
            addImg();        

        }

        public void addImg(){
            int i = 0;
            int index;
            String s;
            while(true){              
                if(i == 10) {
                    Console.WriteLine("Thư viện đầy,chọn ảnh thay thế");  
                    index = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nhập ảnh mới:");
                    s = Console.ReadLine();
                    this.gall.Insert(index,s);    
                }
                Console.WriteLine("Nhập ảnh mới:");   
                this.gall.Add(Console.ReadLine());
                Console.WriteLine("Dừng nhập ảnh? (Y/N)");
                if(Console.ReadLine() == "Y") break;
                i++;                              
            }
        }

        public void deleteImg(){
            int i = 0;
            foreach (String img in this.gall)
            {
                Console.WriteLine(i+":"+img);            
            }
            Console.WriteLine("Chọn ảnh xóa:");
            int index = Int32.Parse(Console.ReadLine());
            this.gall.RemoveAt(index);            
        }

        public bool checkQty(){
            return (this.qty>0) ? true : false;
        }

    }
}