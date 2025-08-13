using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoa objJogador;//criei uma "pessoa"
            pessoa camisa7;
            objJogador = new pessoa();
            camisa7 = new pessoa();
            objJogador.cadastrar()
            camisa7.cadastrar();
            objJogador.exibir();
            camisa7.exibir();
            
        }
    }
}
