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

            for (int i = 0; i < 5; i++)
            {
                int randomszam = random.Next();
                randomszamok.Add(randomszam);
            }

            foreach (int number in randomszamok)
            {
                Console.WriteLine(number);
            }
        }
    }
}
