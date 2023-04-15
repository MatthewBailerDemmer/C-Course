using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Excecoes_Especificas
{
    public class NumeroNegativoException: Exception
    {
        public NumeroNegativoException(int numero): base("Número " + numero + " não é positivo")
        {

        }
    }
}
