using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_5
{
    internal class Program
    {
        public struct DadosCadastraisStruct
        {
            public string Nome;
            public DateTime DataDeNascimento;
            public string NomeDaRua;
            public UInt32 NumeroDaCasa;
        }
        public enum Resultado_e
        {
            Sucesso,
            Sair,
            Excessao
        }

        public static void MostraMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public static Resultado_e PegaString(ref string minhaString, string mensagem)
        {
            Resultado_e ret;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if(temp == "s" || temp =="S")
                ret = Resultado_e.Sair;
            else
            {
                minhaString = temp;
                ret = Resultado_e.Sucesso;
            }
            Console.Clear();
            return ret;
        }

        public static Resultado_e PegaData(ref DateTime data, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }
        public static Resultado_e PegaUInt32(ref UInt32 numero, string mensagem)
        {
            Resultado_e retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                        retorno = Resultado_e.Sair;
                    else
                    {
                        numero = Convert.ToUInt32(numero);
                        retorno = Resultado_e.Sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = Resultado_e.Excessao;
                }
            } while (retorno == Resultado_e.Excessao);
            Console.Clear();
            return retorno;
        }

        public static void CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;

            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite o nome da rua ou S para sair") != Resultado_e.Sucesso)
                return;
            if (PegaUInt32(ref cadastroUsuario.NumeroDaCasa, "Digite o numero da casa S para sair") != Resultado_e.Sucesso)
                return;
            ListaDeUsuarios.Add(cadastroUsuario);


        }
        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    CadastraUsuario(ref ListaDeUsuarios);
                }
                else if (opcao == "s")
                {
                    MostraMensagem("Encerrando o programa");
                }
                else
                {
                    MostraMensagem("Opcao desconhecida");
                }
            } while (opcao != "s");
        }
    }
}
