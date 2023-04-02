using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MODIFICADORES_DE_ACESSO class NOME_DA_CLASE {}
//Modificadores de acesso
//Internal (interno) - só pode ser acessada pelo nosso assembly, o produto do nosso projeto aqui no visual studio
//public - pode ser acessado por qualquer outro programa ou assembly externo
//private - A classe só pode ser acessada internamente pelo bloco de código q a criou

namespace CriandoClasses
{
    internal class Carro_Internal
    {
        Carro_Public meuCarroPublic = new Carro_Public(); 
    }
    public class Carro_Public 
    {
        Carro_Internal meuCarroInternal = new Carro_Internal();
    }
    internal class Program
    {
        //Só podemos criar classes privadas dentro de outras classes
        private class Carro_Private 
        {
        
        }
        static void Main(string[] args)
        {
            //NOME_DA_CLASSE NOME_DO_OBJETO = new NOME_DA_CLASSE();
            Carro_Internal meuCarroInternal = new Carro_Internal();
            Carro_Public meuCarroPublic = new Carro_Public();
            Carro_Private meuCarroPrivate = new Carro_Private();
            Carro_Externo meuCarroExterno = new Carro_Externo();
        }
    }
}
