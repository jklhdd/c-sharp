using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Fibo f = new Fibo();
			Console.WriteLine("Nhap N:");
			f.setN(Convert.ToInt32(Console.ReadLine()));
			f.getFibo();
			Console.WriteLine(f.getFibo());
		}
		class Fibo
		{
			int n;
			int f1 = 1;
			int f2 = 2;
			int fn = 0;
			public void setN(int n)
			{
				this.n = n;
			}
			public int getN()
			{
				return n;
			}
			public int getFibo()
			{
				if (this.getN() == 2) return fn = 2;
				else if (this.getN() == 1) return fn = 1;
				else if (this.getN() < 1)
				{
					Console.WriteLine("Khong tim duoc"); return fn = 0;
				}
				else
				{
					while (f1 + f2 < n)
					{
						fn = f1 + f2;
						f1 = f2;
						f2 = fn;
					}
					return fn;

				}
			}
		}
	}
}


