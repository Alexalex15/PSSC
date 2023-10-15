using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static L01.Cantitate;
namespace L01
{
    internal record Produs
    {
        public static string Cod{get;set;}
        public static ICantitate Cantitate{get;set;}
        public Produs(string cod, ICantitate cantitate)
        {
            Cod=cod;
            Cantitate=cantitate;
        }
        public static void Afisare()
        {
            Console.WriteLine("Cod="+ Cod +"\n");
            Console.WriteLine("Cantitate="+ Cantitate + "\n");
        }

    }
}