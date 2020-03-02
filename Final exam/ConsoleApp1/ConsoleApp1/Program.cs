using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone testPhone = new Phone("Long","co dinh",80000);
            MobilePhone testMobilePhone = new MobilePhone();
            testPhone.display();
            testMobilePhone.display();
        }
    }
}