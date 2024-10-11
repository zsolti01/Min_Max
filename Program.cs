using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> randomszamok = new List<int>();
            Random random = new Random();

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                int randomszam = random.Next(1, 101);
                randomszamok.Add(randomszam);
            }

            foreach (int szam in randomszamok)
            {
                Console.WriteLine("A számok: {0}", szam);
            }

            Console.WriteLine();

            int legkisebb = randomszamok[0];
            int legnagyobb = randomszamok[0];

            foreach (int i in randomszamok)
            {
                if (i < legkisebb) legkisebb = i;
                if (i > legnagyobb) legnagyobb = i;
            }

            Console.WriteLine("A legkisebb szám: {0}", legkisebb);
            Console.WriteLine("A legnagyobb szám: {0}", legnagyobb);

        }
    }
}
