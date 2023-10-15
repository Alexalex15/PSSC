using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace L01
{
    [AsChoice]
    public static partial class Cantitate{

        public interface ICantitate{}
        public record Unitati(int Units) : ICantitate;
        public record Kg(double Kgs):ICantitate;
        public record Undef(string Ndef):ICantitate;
    }
}