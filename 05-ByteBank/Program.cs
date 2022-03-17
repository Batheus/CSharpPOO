using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente gabriela = new Cliente();
            // gabriela.nome = "Gabriela Martins";
            // gabriela.cpf = "123.456.789-10";
            // gabriela.profissao = "Desenvolvedora Front-End";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Martins";
            conta.titular.cpf = "123.456.789-10";
            conta.titular.profissao = "Desenvolvedora Front-End";
            conta.saldo = 500;
            conta.agencia = 123;
            conta.numero = 123456;

            // Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);

            Console.ReadLine();
        }
    }
}