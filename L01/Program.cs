using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static L01.Cantitate;
using System.Globalization;

namespace L01
{
    internal class Program{
 private static void Main(string[] args)
        {
            ICantitate q1 = ConversieCantitate("2");
            ICantitate q2 = ConversieCantitate("3.5");
            Contact persoana = new Contact("Popa", "Ion", "078900113322", "Garoafelor");
            Produs produs1 = new Produs("1231", q1);
            Produs produs2 = new Produs("999", q2);
            List<Produs> produse = new List<Produs>();
            produse.Add(produs1);
            produse.Add(produs2);
            Comanda comanda = new Comanda(persoana, produse);
            comanda.afisare();
        }

        private static ICantitate ConversieCantitate(string cantitate)
        {
            if (Int32.TryParse(cantitate, out int units))
                return new Unitati(units);
            else if (Double.TryParse(cantitate, NumberStyles.Number, CultureInfo.CreateSpecificCulture("en-US"), out double kgs))
                return new Kg(kgs);
            else
                return new Undef(cantitate);
        }

        public static Contact citestePersoana()
        {
            string nume, prenume, telefon, adresa;
            Console.WriteLine("Introducere contact");
            Console.Write("Introduceti numele: ");
            nume = Console.ReadLine();
            Console.Write("Introduceti prenumele: ");
            prenume = Console.ReadLine();
            Console.Write("Introduceti numarul de telefon: ");
            telefon = Console.ReadLine();
            Console.Write("Introduceti adresa: ");
            adresa = Console.ReadLine();
            Contact persoana = new Contact(nume, prenume, telefon, adresa);
            return persoana;
        }

        public static Produs citesteProdus()
        {
            string cod;
            ICantitate cantitate;
            Console.WriteLine("Introducere produs");
            Console.Write("Introduceti codul: ");
            cod = Console.ReadLine();
            Console.Write("Introduceti cantitatea: ");
            cantitate = ConversieCantitate(Console.ReadLine());
            Produs produs = new Produs(cod, cantitate);
            return produs;
        }
    }
}
       
