using System;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main()
		{
			Class0 cl0 = new Class0(10);
			Class0 cl0ref = cl0;
			cl0.test = 9;
			Console.WriteLine($"cl0.test: {cl0.test} | cl0ref.test: {cl0ref.test}");

			Class1 cl1 = new Class1(8);
			Class1 cl1copy = new Class1(cl1);
			cl1.test = 7;
			Console.WriteLine($"cl1.test: {cl1.test} | cl1copy.test: {cl1copy.test}");

			Class1v2 cl2 = new Class1v2(6);
			Class1v2 cl2copy = new Class1v2(cl2);
			cl2.test += 1;
			Console.WriteLine($"cl2.test: {cl2.test} | cl2copy.test: {cl2copy.test}");

		}
	}
	class Class0
	{
		public int test;
		public Class0(int tes) { test = tes; }
	}
	class Class1
	{
		public int test;
		public Class1(int tes) { test = tes; }
		public Class1(Class1 clas) : this(clas.test) { }
	}
	class Class1v2 : Class1
	{
		public int mol = 10;
		public Class1v2(int tes) : base(tes) { test *= mol; }
		public Class1v2(Class1v2 clasv2) : base(clasv2) { /*test *= mol; */ } //manca this!!!

	}
}
