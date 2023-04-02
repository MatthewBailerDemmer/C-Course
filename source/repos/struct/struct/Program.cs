using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    internal class Program
    {
        struct DadosCadastrais // por default os campos dessa estrutura são private
        {
            public string Nome;
            public string nomeDaRua;
            public UInt32 NumeroDaCasa;
            public DateTime DataDeNascimento;
        }
        static void Main(string[] args) // struct é um agrupamento de váriaveis de diferentes tipso
        {
            DadosCadastrais meuCadastro;
            meuCadastro.Nome = "João";
            meuCadastro.nomeDaRua = "Rua das Flores";
            meuCadastro.NumeroDaCasa = 24;
            meuCadastro.DataDeNascimento = Convert.ToDateTime("21/12/1985");

            Console.WriteLine(meuCadastro.Nome);
            Console.WriteLine(meuCadastro.nomeDaRua);
            Console.WriteLine(meuCadastro.NumeroDaCasa);
            Console.WriteLine(meuCadastro.DataDeNascimento.Day + "/" + meuCadastro.DataDeNascimento.Month + "/" + meuCadastro.DataDeNascimento.Year);
            Console.ReadKey();
          
        }
    }
}
