using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectWithDB
{
	interface ICake
	{
		double getPrice(string flavour, int toppings, double sizeinKg);
	}

	class CupCake : ICake
	{
		public double getPrice(string flavour, int toppings, double sizeinKg)
		{
			double price = 0;
			if (flavour.ToLower() == "vanilla")
			{
				price = (toppings * 15+100)*sizeinKg;
			}
			if (flavour.ToLower() == "chocalate")
			{
				price = (toppings * 15+150)* sizeinKg;
			}
			return price;
		}
	}

	class PinataCake : ICake
	{
		public double getPrice(string flavour, int toppings, double sizeinKg)
		{
			double price = 0;
			if (flavour.ToLower() == "vanilla")
			{
				price = (toppings * 40) + (sizeinKg * 250);
			}
			if (flavour.ToLower() == "chocalate")
			{
				price = (toppings * 40) + (sizeinKg * 350);
			}
			return price+100;
		}
	}
	class Class5
	{
		static void Main5(string[] args)
		{
			CupCake cc = new CupCake();
			var res = cc.getPrice("Vanilla", 2, 0.5);
			Console.WriteLine(res);
			//PinataCake pc = new PinataCake();
			//var res1 = pc.getPrice();
			//Console.WriteLine(res1);
		}
	}
}

