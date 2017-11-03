using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Aktivny 1", "aktivny", "nie", 3, 70.9f, 34.8f);
            mojDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je {0}", mojDom.ZistiVyuzitelnostZastavanejPlochy());

            Dom susedovDom = new Dom("Aktivny 1", "aktivny", "nie", 3, 78.9f, 44.8f);
            susedovDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je {0}", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Chata chata = new Chata("chata 1", "pasivna", "10", 50, 188.5f, 65.5f, "ano a velka");
            chata.PoskytniInformacie();
            chata.PopisChaty();
            Console.WriteLine("Percento zastavanej plochy je {0}", chata.ZistiVyuzitelnostZastavanejPlochy());



            Console.ReadLine();

        }
    }
}
