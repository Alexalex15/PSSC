using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L01
{
    public record class Contact
    {
    public string Nume{get;set;}
    public string Prenume{get;set;}
    public string Nr{get;set;}
    public string Adresa{get;set;}

    public Contact(string nume,string prenume,string nr,string adresa)
    {
        Nume=nume;
        Prenume=prenume;
        Nr=nr;
        Adresa=adresa;
    } 
    public void Afisare()
    {
        Console.WriteLine("Nume:"+Nume+"\n");
        Console.WriteLine("Prenume:"+Prenume+"\n");
        Console.WriteLine("Nr:"+Nr+"\n");
        Console.WriteLine("Adresa:"+Adresa+"\n");
    }
    }
}