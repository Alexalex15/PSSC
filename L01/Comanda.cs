using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static L01.Produs;

namespace L01
{
    internal record Comanda
    {
        public Contact contact{get;set;}
        public List<Produs> lista{get;set;}
        public Comanda(Contact contact1, List<Produs> Lista)
        {
            contact=contact1;
            lista=Lista;
        }

        public void afisare()
        {
            Console.WriteLine(contact);
            foreach(var Produs in lista);
            {
                Produs.Afisare();
            }

        }
    }
}