using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sexto_Projeto
{
    internal class Program
    {
        static string inicio;
        static string fim;
        static string nome;
        static string nascimento;
        static string rua;
        static string casa;
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
            if (temp == "s" || temp == "S")
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

        public static Resultado_e CadastraUsuario(ref List<DadosCadastraisStruct> ListaDeUsuarios)
        {
            DadosCadastraisStruct cadastroUsuario;
            cadastroUsuario.Nome = "";
            cadastroUsuario.DataDeNascimento = new DateTime();
            cadastroUsuario.NomeDaRua = "";
            cadastroUsuario.NumeroDaCasa = 0;

            if (PegaString(ref cadastroUsuario.Nome, "Digite o nome completo ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaData(ref cadastroUsuario.DataDeNascimento, "Digite a data de nascimento ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaString(ref cadastroUsuario.NomeDaRua, "Digite o nome da rua ou S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            if (PegaUInt32(ref cadastroUsuario.NumeroDaCasa, "Digite o numero da casa S para sair") == Resultado_e.Sair)
                return Resultado_e.Sair;
            ListaDeUsuarios.Add(cadastroUsuario);
            return Resultado_e.Sucesso;


        }
        public static void Grava(string caminho, List<DadosCadastraisStruct> ListaDeUsuario)
        {
            try 
            {
                string conteudo = "";
                foreach(DadosCadastraisStruct cadastro in ListaDeUsuario) {
                    conteudo += inicio + "\r\n";
                    conteudo += nome + cadastro.Nome + "\r\n";
                    conteudo += nascimento + cadastro.DataDeNascimento.ToString("dd/MM/yyyy") + "\r\n";
                    conteudo += rua + cadastro.NomeDaRua + "\r\n";
                    conteudo += casa + cadastro.NumeroDaCasa + "\r\n";
                    conteudo += fim;
                }
                File.WriteAllText(caminho, conteudo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Carrega(string caminho, ref List<DadosCadastraisStruct> ListaDeUsuario)
        {
            try
            {
                if(File.Exists(caminho))
                {
                    string[] conteudoArq = File.ReadAllLines(caminho);
                    DadosCadastraisStruct dadosCadastrais;
                    dadosCadastrais.Nome = "";
                    dadosCadastrais.DataDeNascimento = new DateTime();
                    dadosCadastrais.NomeDaRua = "";
                    dadosCadastrais.NumeroDaCasa = 0;

                    foreach(string linha in conteudoArq) 
                    { 
                        if(linha.Contains(inicio))
                            continue;
                        if (linha.Contains(fim))
                            ListaDeUsuario.Add(dadosCadastrais);
                        if (linha.Contains(nome))
                            dadosCadastrais.Nome = linha.Replace(nome, "");
                        if (linha.Contains(nascimento))
                            dadosCadastrais.DataDeNascimento = Convert.ToDateTime(linha.Replace(nascimento, ""));
                        if (linha.Contains(rua))
                            dadosCadastrais.NomeDaRua = linha.Replace(rua, "");
                        if (linha.Contains(casa))
                            dadosCadastrais.NumeroDaCasa = Convert.ToUInt32(linha.Replace(casa, ""));

                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main(string[] args)
        {
            List<DadosCadastraisStruct> ListaDeUsuarios = new List<DadosCadastraisStruct>();
            string opcao = "";
            inicio = "\r\n##### INICIO #####";
            fim = "##### FIM #####";
            nome = "NOME: ";
            nascimento = "DATA_DE_NASCIMENTo: ";
            rua = "NOME_DA_RUA: ";
            casa = "NUMERO_DA_CASA ";
            string caminhoArq = @"D:\baseDeDados.txt";
            Carrega(caminhoArq, ref ListaDeUsuarios);
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário ou S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    if (CadastraUsuario(ref ListaDeUsuarios) == Resultado_e.Sucesso)
                        Grava(caminhoArq, ListaDeUsuarios);
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
