using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			int f1 = 1, f2 = 2, fn = 0;
			Console.WriteLine("Nhap N:");
			n = Convert.ToInt32(Console.ReadLine());
			if (n == 2) Console.WriteLine("So fibo tim duoc : " + f2);
			else if (n == 1) Console.WriteLine("So fibo tim duoc : " + f1);
			else if (n < 1) Console.WriteLine("Khong tim duoc");
			else
			{
				while (f1 + f2 <= n)
				{
					fn = f1 + f2;
					f1 = f2;
					f2 = fn;
				}
				Console.WriteLine("So fibo tim duoc : " + fn);

			}
		}
	}
}


