using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
	class Program
	{
		static void Main(string[] args)
		{
			





			/*Console.WriteLine("What's your name?");
			string name1 = Console.ReadLine();
			Console.WriteLine("What's you neighbor ");
			string name2 = Console.ReadLine();
			if (name1== "Denis" && name2 == "ArtjomV" || name1 == "ArtjomV" && name2 == "Denis")
			{
				Console.WriteLine("Damn, they are sitting together.....");

			}
			if (name1 == "ArtjomR" && name2 == "Timosha" || name1 == "Timosha" && name2 == "ArtjomR")
			{
				Console.WriteLine("Damn, they are sitting together.....");

			}
			if (name1 == "Angelina" && name2 == "Ilja" || name1 == "Ilja" && name2 == "Angelina")
			{
				Console.WriteLine("Damn, they are sitting together.....");

			}
			else
			{
				Console.WriteLine("You are wrong, they are not neighbors!");
			}
			Console.ReadKey();*/




			/*double hind = 10;
			string pilet_tuup = "Täispilet";
			Console.WriteLine("Hallo, what is your name?");
			string eesnimi = Console.ReadLine();
			//Console.WriteLine("Hallo,"+ eesnimi);

			if (eesnimi.ToLower() == "juku")
			{
				Console.WriteLine("Welcome back, homie! Do you want go to drug dealer?");
				string vastus = Console.ReadLine();
				if (vastus.ToUpper() == "YE" || vastus.ToUpper() == "YES")
				{
					Console.WriteLine("Yoy homie, how old are you?");
					int vanus = int.Parse(Console.ReadLine());
					if (vanus < 0 || vanus > 108)
					{
						Console.WriteLine("Damn, error...");
					}
					else if (vanus < 6 || vanus >= 65)
					{
						hind -= hind * 1;
						pilet_tuup = "tasuta";
					}
					else if (vanus >= 6 && vanus < 12)
					{
						hind -= hind * 0.3;
						pilet_tuup = "laste pilet";
					}
					else if (vanus >= 12 && vanus < 18)
					{
						hind -= hind * 0.1;
						pilet_tuup = "väike soodus";
					}
					else if(vanus<0 || vanus>108)
					{
						Console.WriteLine("Damn, error...");
					}
					char[] tahed = eesnimi.ToCharArray();
					int i = 0;
					eesnimi = "";
					foreach (var t in tahed)
					{
						if (i==0)
						{
							eesnimi += t.ToString().ToUpper();
						}
						else
						{
							eesnimi += t.ToString().ToLower();
						}
						i += 1;
					}
					Console.WriteLine("{eesnimi},you need to pay {hind}",eesnimi);

				}
				else
				{

				}
			}
			else
			{
			Console.WriteLine("Yoy nigga, go back to your home!! Ass hole!!!");
			}
			Console.ReadKey();*/
		}
	}
}
