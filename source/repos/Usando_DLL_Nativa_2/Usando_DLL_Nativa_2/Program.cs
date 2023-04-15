using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Usando_DLL_Nativa_2
{
    internal class CascaDLlNativa 
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct MinhaEstrutura
        {
            public int valor1;
            public double valor2;
            public char valor3;
        }
        
        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void  LimpaMemoria();

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaString();

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaArrayDeBytes();

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeEstrutura(ref MinhaEstrutura estrutura);

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnviaEstrutura(ref MinhaEstrutura estrutura);

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr RetornaEstrutura();

        [DllImport(@"D:\C-Course\source\repos\Usando_DLL_Nativa\Usando_DLL_Nativa\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeEstrutura(IntPtr minhaEstrutura);

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr ptrParaStr = CascaDLlNativa.RetornaString();
            string minhaString = Marshal.PtrToStringAnsi(ptrParaStr);
            CascaDLlNativa.LimpaMemoria();
            Console.WriteLine(minhaString);

            IntPtr ptrParaByteArray = CascaDLlNativa.RetornaArrayDeBytes();
            byte[] byteArray = new byte[3];
            Marshal.Copy(ptrParaByteArray, byteArray, 0, 3);
            CascaDLlNativa.LimpaMemoria();
            if (byteArray[0] == 0 && byteArray[1] == 1 && byteArray[2] == 2)
                Console.WriteLine("Array de Bytes retornado com sucesso");
            else
                Console.WriteLine("Array de Bytes NÃO retornado com sucesso");

            CascaDLlNativa.MinhaEstrutura minhaEstrutura = new CascaDLlNativa.MinhaEstrutura();
            CascaDLlNativa.RecebeEstrutura(ref minhaEstrutura);
            if (minhaEstrutura.valor1 == 10 && minhaEstrutura.valor2 == 20 && minhaEstrutura.valor3 == 30)
                Console.WriteLine("Estrutura preenchida com sucesso");
            else
                Console.WriteLine("Estrutura não preenchida com sucesso");

            CascaDLlNativa.MinhaEstrutura minhaEstrutura2 = new CascaDLlNativa.MinhaEstrutura();
            minhaEstrutura2.valor1 = 10;
            minhaEstrutura2.valor2 = 20;
            minhaEstrutura2.valor3 = 'a';
            bool retornoEnviaEstrutura = CascaDLlNativa.EnviaEstrutura(ref minhaEstrutura2);
            if (retornoEnviaEstrutura)
                Console.WriteLine("Estrutura enviada com sucesso");
            else
                Console.WriteLine("Estrutura não enviada com sucesso");

            IntPtr ptrParaStrcut = CascaDLlNativa.RetornaEstrutura();
            CascaDLlNativa.MinhaEstrutura minhaEstrutura3 = new CascaDLlNativa.MinhaEstrutura();
            minhaEstrutura3 = (CascaDLlNativa.MinhaEstrutura)Marshal.PtrToStructure(ptrParaStrcut, typeof(CascaDLlNativa.MinhaEstrutura));
            CascaDLlNativa.LimpaMemoria();
            if (minhaEstrutura3.valor1 == 10 && minhaEstrutura3.valor2 == 20 && minhaEstrutura3.valor3 == 30)
                Console.WriteLine("Estrutura retornada com sucesso");
            else
                Console.WriteLine("Estrutura não retornada com sucesso");

            IntPtr minhaEstruturaPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(CascaDLlNativa.MinhaEstrutura)));
            CascaDLlNativa.RecebeEstrutura(minhaEstruturaPtr);
            CascaDLlNativa.MinhaEstrutura minhaEstruturaConvertida = (CascaDLlNativa.MinhaEstrutura)Marshal.PtrToStructure(minhaEstruturaPtr, typeof(CascaDLlNativa.MinhaEstrutura));
            if (minhaEstruturaConvertida.valor1 == 10 && minhaEstruturaConvertida.valor2 == 20 && minhaEstruturaConvertida.valor3 == 30)
                Console.WriteLine("Estrutura preenchida com sucesso");
            else
                Console.WriteLine("Estrutura não preenchida com sucesso");

            Console.ReadKey();
        }
    }
}
