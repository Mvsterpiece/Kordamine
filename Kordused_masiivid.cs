using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
	class Kordused_masiivid
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
			//Console.OutputEncoding = Encoding.UTF8; //на русском
			/*int[] arvudd = new int[5];
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

			Console.ReadLine();*/



			/*char[] Tahed = new char[7] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
			Console.WriteLine($"Esimene täht on {Tahed[0]}");

			funct.Massiiv_ekraanile(Tahed);
			Array arvud;
			arvud = funct.Arvud_massiivisse(10, false);
			funct.Massiiv_ekraanile(arvud);
			Console.WriteLine();
			int[] arvud = new int[10];
			for (int i = 0; i < arvud.Length; i++)
			{
				arvud[i] = rnd.Next(5,500);
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



			/*Console.WriteLine("Купи слона!");
            string loom = Console.ReadLine();
			Console.OutputEncoding = Encoding.UTF8; 
			if (loom != "слон")
			{
                Console.WriteLine("Все так говорят "+loom+ "а ты купи!");
                Console.ReadLine();
			}
            Console.WriteLine("Слон теперь твой!");
            Console.ReadLine();*/

			/*Random rand = new Random();
			int i = rand.Next(10);
			int count = 1;
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
			Console.WriteLine("Введите первое число:");
			int k = Convert.ToInt32(Console.ReadLine());
			while (count <= 5)
			{
				if (i == k)
				{
					Console.WriteLine("Да! Компьютер загадал число " + k + "!");
					break;
				}
				else
				{
					count++;
					if (count == 6)
					{
						Console.WriteLine("Увы, вы не отгодали загаданное число. Это было число " + i + "!");
						break;
					}
					Console.WriteLine("Нет, это не число " + k + "! Попытка № " + count + ":");
					k = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.ReadLine();*/
			/*Array nelliarvud;
			nelliarvud = funct.Arvud_massiivisse(4,true);
			//Array.Reverse(nelliarvud);
			//var arv = "";
			int arv1 = 0;
			int j = 0;
			foreach (int n in nelliarvud)
			{
				//arv += n.ToString();
				arv1 =(int)(arv1 + n * Math.Pow(10,j));
				j++;
			}
			Console.WriteLine(arv1);
			Console.ReadLine();*/






			/*int num1, num2, avg;
			Console.Write("Number 1: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Number 2: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			avg = Average(num1, num2);
			Console.WriteLine("The average of numbers is " + avg);
			Console.ReadKey();*/
























        /*private static int Average(int num1, int num2)
        {
            throw new NotImplementedException();
        }*/
    }
}
