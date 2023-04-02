using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Classe
{
    internal class ClasseMae
    {
        //Modificadores de Acesso
        //public - todo mundo tem acesso (classes filhas e externamente)
        //private - somente a própria classe tem acesso (nem as filhas nem externamente)
        //protected - somente poderá ser acessado pela classe filha e pela própria classe (externamente não)
        
        public string atributoDaMae = "Atributo da mãe";
        protected string atributoMaeProtected = "Pau no seu cu";

        public string PropriedadeDaMae
        {
            get;
            set;
        }
        public void MetodoDaClasseMae()
        {
            Console.WriteLine("Método da classe mae");
        }

        public ClasseMae(string pParametroMae)
        {
            PropriedadeDaMae = pParametroMae;
        }
    }
}
