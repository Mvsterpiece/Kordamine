using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class list_sonastik
    {
        static void Main(string[] args)
        {
            /*Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                int number = rnd.Next(1, 5);
                numbers.Add(number);
            }
            foreach (int number in numbers)
            {
                Console.Write(number+" ");
            }
            List<int> result = new List<int>();
            int snumber = numbers[0];
            int enumber = numbers[numbers.Count - 1];
            numbers.Insert(0, enumber);
            numbers.Add(snumber);*/








            /*int[] arvud = new int[5] { 2, 1, 4, 56, 23 };
            List<int> koik_arvud = new List<int>(arvud);
            List<int> paaris = new List<int>();
            List<int> paaritu = new List<int>();
            foreach (int arv in koik_arvud)
            {
                if (arv % 2==0)
                {
                    paaris.Add(arv);
                }
                else
                {
                    paaritu.Add(arv);
                }
                Console.WriteLine(paaris);
                Console.WriteLine(paaritu);
            }
            Console.ReadLine();*/
            


            /*Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 21; i++)
            {
                int number = rnd.Next(1, 21);
                numbers.Add(number);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();*/







            /*Dictionary<int, string> sportlased = new Dictionary<int, string>();
            for (int i = 1; i < 6; i++)
            {
                sportlased.Add(i, Console.ReadLine());
            }
            Console.WriteLine(sportlased[1]);
            sportlased.Remove(5);
            foreach (KeyValuePair<int,string> kv in sportlased)
            {
                Console.WriteLine(kv.Key+"kohal"+ kv.Value);
            }
            /*LinkedList<int> loetelu = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                loetelu.AddFirst(i);
                if(i%2!=0)
                {
                    loetelu.Remove(i);
                }
            }
            foreach (int item in loetelu)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();*/

            /*
            List<inimene> inimesed = new List<inimene>();
            inimesed.Add(new inimene() {Nimi ="Madis"});
            inimesed.Add(new inimene() { Nimi = "Hui Lo Pan" });
            foreach (inimene Inimene in inimesed)
            {
                Console.WriteLine(Inimene.Nimi);
            }



            string[] nimed0 = new string[3] { "Mati", "Silver", "Reimo" };
            List<string> nimed = new List<string>(nimed0);

            Console.Write("Sisesta nimi listisse: ");
            nimed.Add(Console.ReadLine());
            nimed.Insert(0, "Denis");
            if (nimed.Contains("Denis"))
            {
                Console.WriteLine("See nimi on olemas"+"ta on {0} kohal",nimed.IndexOf("Denis"));
            }
            else
            {
                Console.WriteLine("Selle nimi ei ole!");
            }

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            Console.ReadLine();*/


        }

    }
}
