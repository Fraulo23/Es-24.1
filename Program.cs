using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire la misura del lato");
            Quadrato l = new Quadrato();
            l.Lato=float.Parse(Console.ReadLine());
            Console.WriteLine("L'area del quadrato è {0}",l.Lato*l.Lato);
            Console.ReadLine();
        }
    }
}
