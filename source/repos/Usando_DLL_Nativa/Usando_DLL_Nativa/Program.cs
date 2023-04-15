﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Usando_DLL_Nativa
{
    internal class CascaDLLNativa
    {
        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Soma(double a, double b);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Media(double[] a, int quantidade);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void RecebeVetor([In, Out]int[] Vetor, int Tamanho);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnviaFrase(char[] Frase);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool EnviaFrase(string Frase);

        [DllImport(@"..\..\DLL\DLL_Nativa.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void PegaFrase([In, Out]char[] Frase, int Tamanho);


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // DLL nativas são desenvolvidas em C ou C++, portanto são interpretadas diretamente pelo processador
            //Códigos de C# e Java passam sempre pelo interpretador antes 
            double resultadoSoma = CascaDLLNativa.Soma(10, 20);
            Console.WriteLine("O resultado da soma de 10 e 20 é: " + resultadoSoma);
           
            double[] valoresMedia = { 10, 20, 30 };
            double resultadoMedia = CascaDLLNativa.Media(valoresMedia, valoresMedia.Length);
            Console.WriteLine("A médiia de 10, 20 e 30 é: " + resultadoMedia);

            int[] meuVetorInt = new int[3];
            CascaDLLNativa.RecebeVetor(meuVetorInt, meuVetorInt.Length);
            if (meuVetorInt[0] == 0 && meuVetorInt[1] == 1 && meuVetorInt[2] == 2)
                Console.WriteLine("Vetor recebido corretamente");
            else
                Console.WriteLine("Vetor não recebido corretamente");

            char[] enviaFrase1 = ("EnviaFrase").ToCharArray();
            bool resultadoEnviaFrase1 = CascaDLLNativa.EnviaFrase(enviaFrase1);
            if (resultadoEnviaFrase1)
                Console.WriteLine("String enviada corretamente");
            else
                Console.WriteLine("String não enviada corretamente");

            String enviaFrase2 = "EnviaFrase2";
            bool resultadoEnviaFrase2 = CascaDLLNativa.EnviaFrase(enviaFrase2);
            if (resultadoEnviaFrase2)
                Console.WriteLine("String enviada corretamente");
            else
                Console.WriteLine("String não enviada corretamente");

            char[] chPegaFrase = new char[128];
            CascaDLLNativa.PegaFrase(chPegaFrase, chPegaFrase.Length);
            string strPegaFrase = new string(chPegaFrase);
            Console.WriteLine(strPegaFrase);

            Console.ReadKey();
        }
    }
}
