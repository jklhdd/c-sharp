using System;

namespace ConsoleApp1
{
    public delegate void PrimeNumberFinder();
    class Program
    {
        static void Main(string[] args)
        {
            
            Phone testPhone = new Phone("Long","co dinh",80000);
            MobilePhone testMobilePhone = new MobilePhone();
            testPhone.display();
            testMobilePhone.display();
        }
        public event PrimeNumberFinder OnPrimeNumber;

        public void PrimeNumberFinder()
        {
            for (int i = 0; i < 10; i++)
            {
                
            }
        }
    }
    
}