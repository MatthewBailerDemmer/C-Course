using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_classe
{
    internal class Program
    {
        public class ContaBancaria
        {
            public string senha;
            public double saldo;
            public string nomeDoCliente;
            public double Sacar(double pValorSacado, string pSenha)
            {
                if(senha == pSenha )
                {
                    if(saldo > pValorSacado)
                    {
                        saldo -= pValorSacado;
                        Console.WriteLine("O valor sacado foi de: " + pValorSacado);
                        return pValorSacado;
                    }
                    else
                    {
                        Console.WriteLine("O saldo é insuficiente");
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("A senha esta incorreta");
                    return 0;
                }
            }
            public void Depositar(double pValorDepositado)
            {
                saldo += pValorDepositado;
                Console.WriteLine("O valor depositado foi de: " + pValorDepositado);

            }
            public void Depositar(double pValorDepositado, string pNomeDoCliente)
            {
               if(pNomeDoCliente == nomeDoCliente)
                {
                    saldo += pValorDepositado;
                    Console.WriteLine("O valor depositado foi de: " + pValorDepositado);
                }
               else
                {
                    Console.WriteLine("Tentativa de deposito para a conta errada");
                    return;
                }
            }

            public void ConsultaSaldo(string pSenha)
            {
                if (senha == pSenha)
                    Console.WriteLine("O saldo da conta é: " + saldo);
                else
                    Console.WriteLine("A senha está incorreta");
            }

            public ContaBancaria(string pSenha, string pNomeDoCliente)
            {
                saldo = 0;
                senha = pSenha;
                nomeDoCliente = pNomeDoCliente;
            }
        }
      
        static void Main(string[] args)
        {
            ContaBancaria contaDoPedro = new ContaBancaria("12345", "Pedro Santos");

            double valorSacado = contaDoPedro.Sacar(10, "12345");
            contaDoPedro.Depositar(1000);
            contaDoPedro.ConsultaSaldo("12345");
        }
    }
}
