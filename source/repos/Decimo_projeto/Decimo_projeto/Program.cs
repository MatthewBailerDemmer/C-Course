﻿using Oitavo_Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimo_projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDeDados baseDeDados = new BaseDeDados("BaseDeDados.xml");
            InterfaceGrafica meuPrograma = new InterfaceGrafica(baseDeDados);
            meuPrograma.IniciaInterface();
        }
    }
}
