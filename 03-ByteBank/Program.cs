using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 123456;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 123;
            contaDaGabrielaCosta.numero = 123456;

            Console.WriteLine("Igualdade do tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idade2 = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Igualdade do tipo de referência (Apontando pro mesmo objeto): " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}