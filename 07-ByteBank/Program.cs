using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 89879456);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente contadoMario = new ContaCorrente(867, 89879470);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
        }
    }
}