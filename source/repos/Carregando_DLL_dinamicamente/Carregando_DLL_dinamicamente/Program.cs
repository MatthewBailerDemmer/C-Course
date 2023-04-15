using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Carregando_DLL_dinamicamente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly minhaDLL = Assembly.LoadFile(@"D:\C-Course\source\repos\Minha_Primeira_DLL\Minha_Primeira_DLL\bin\Debug\Minha_Primeira_DLL.dll");
            Type classeMatematica = minhaDLL.GetType("Minha_Primeira_DLL.Matematica");
            dynamic instanciaMatematica = Activator.CreateInstance(classeMatematica);
            var metodoSoma = classeMatematica.GetMethod("Soma");
            double resultado  = (double) metodoSoma.Invoke(instanciaMatematica, new object[] {10, 20});
            Console.WriteLine("O resultado da soma de 10 e 20 é:" + resultado);
            Console.ReadKey();
        }
    }
}
