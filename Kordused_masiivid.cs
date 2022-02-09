using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
	class Kordused_masiivid
	{
		static void Main(string[] args)
		{
			/*Random rnd = new Random();
			int N = rnd.Next(1, 100);
			int M = rnd.Next(1, 100);
			Console.WriteLine($"N={N}");
			Console.WriteLine($"M={M}");
			if (N>M)
			{
				int abi = N;
				N = M;
				M = abi;
			}
			int[] N_M = new int[M-N+1];
			int j = 0;
			for (int i = N; i < M+1; i++)
			{
				N_M[j]= i;
				j++;
			}
			foreach (int n_m in N_M)
			{
				Console.Write($"{n_m*n_m,5}");
			}*/
			//Console.OutputEncoding = Encoding.UTF8; на русском
			int[] arvudd = new int[5];
			int a=0;
			int k=0;
			float arvv = 0;
			do
			{
				try
				{
					Console.WriteLine("Siseta arv \n");
					a = int.Parse(Console.ReadLine());
					arvudd[k] = a;
					k++;
				}
				catch (Exception exp)
				{
					Console.WriteLine(exp);
				}

			} while (k<5);
			int summa = 0;
			int korr = 1;
			foreach (int arv in arvudd)
			{
				summa += arv;
				korr *= arv;
				arvv = arv / arvudd.Length;
			}
			Console.WriteLine($"Summa = {summa}, korr={korr},arvv={arvv}");














			Console.ReadLine();



			/*char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
			Console.WriteLine($"Esimene täht on {Tahed[0]}");

			foreach (char taht in Tahed)
			{
				Console.Write($"{taht,2}");
			}
			Random rnd = new Random();
			int[] arvud = new int[10];
			for (int i = 0; i < arvud.Length; i++)
			{
				arvud[i] = rnd.Next(5,500);
			}
			foreach (int arv in arvud)
			{
				Console.Write($"{arv,4}\n");
			}
			int[,] tabel = new int[5,10];
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine($"ride {i + 1}:");
				for (int j = 0; j < 6; j++)
				{
					Console.Write($"koht{j+1} ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();*/




		}

	}
}
