using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Classe
{
   

    internal class ClasseFilha: ClasseMae
    {
        public string atributoDaFilha = "Atributo da filha";

        public string PropriedadeDaFilha
        {
            get;
            set;
        }
        public void MetodoDaClasseFilha()
        {
            Console.WriteLine("Método da classe filha");
            Console.WriteLine(atributoMaeProtected);
        }

        public ClasseFilha() :base("ojnsonsdo´n")
        {
            PropriedadeDaFilha = "Propriedade da  mãe";
        }
    }
}
