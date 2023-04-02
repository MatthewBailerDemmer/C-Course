using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        enum NotasDeReal_e // enums são nomes associados a números
        {
            NotaDe2 = 2,
            NotaDe5 = 5,
            NotaDe10 = 10 // não é aceito números quebrados
        }

        enum NotaDaProva_e
        {
            Nota_1 = -1, //é possivel enums com números negativos
            Nota1,
            Nota2,
            Nota3,
            Nota4
        }
        static void Main(string[] args)
        {
            NotasDeReal_e minhaNota = NotasDeReal_e.NotaDe10;
            Console.WriteLine(minhaNota + " vale " + Convert.ToUInt32(minhaNota));
            

            NotaDaProva_e minhaNotaProva = NotaDaProva_e.Nota4;
            Console.WriteLine(minhaNotaProva + " vale " + Convert.ToInt32(minhaNotaProva)); //ToUInt não aceita números negativos
            Console.ReadKey();
        }
    }
}
