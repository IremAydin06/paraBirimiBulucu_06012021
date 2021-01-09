using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paraBirimiBulucu_06012021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ülke giriniz (tr, fr, abd, it, hol)");
            string ulkeKodu = Console.ReadLine();
            /*i if ile
             
            if (ulkeKodu == "tr")
            {
                Console.WriteLine("Lira");
            }
            else if (ulkeKodu == "fr")
            {
                Console.WriteLine("Euro");
            }
            else if (ulkeKodu == "abd")
            {
                Console.WriteLine("Dolar");
            }
            else
            {
                Console.WriteLine("Yok ki");
            }
            */

            switch (ulkeKodu)
            {
                case "tr":
                    Console.WriteLine("Lira");
                    break;

                case  "fr":
                case  "it":
                case "hol":
                    Console.WriteLine("Euro");
                    break;

                case "abd":
                    Console.WriteLine("Dolar");
                    break;
            }
            Console.ReadLine();
        }
    }
}
