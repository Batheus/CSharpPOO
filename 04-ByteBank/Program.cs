using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 123;
            contaDaGabriela.numero = 123456;

            ContaCorrente contaDoRodolfo = new ContaCorrente();
            contaDoRodolfo.titular = "Rodolfo";
            contaDoRodolfo.agencia = 123;
            contaDoRodolfo.numero = 123456;

            //Sacar
            Console.WriteLine(contaDaGabriela.saldo);
            bool resultadoSacar = contaDaGabriela.Sacar(50);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(resultadoSacar);
            Console.WriteLine();

            //Depositar
            Console.WriteLine(contaDaGabriela.saldo);
            contaDaGabriela.Depositar(500);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine();

            //Transferir
            Console.WriteLine("Valor antigo da conta da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Valor antigo da conta do Rodolfo: " + contaDoRodolfo.saldo);
            bool resultadoTransferir = contaDaGabriela.Transferir(200, contaDoRodolfo);
            Console.WriteLine("Valor atual da conta da Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Valor atual da conta do Rodolfo: " + contaDoRodolfo.saldo);
            Console.WriteLine("Bool da transferência: " + resultadoTransferir);

            Console.ReadLine();
        }
    }
}