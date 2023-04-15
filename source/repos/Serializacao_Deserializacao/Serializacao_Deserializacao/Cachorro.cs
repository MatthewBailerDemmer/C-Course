using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serializacao_Deserializacao
{
    [DataContract] // indica que queremos serializar esta classe
    internal class Cachorro
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string raca;
        [DataMember]
        private string cor;
        public Cachorro(string nome, string raca, string cor)
        {
            this.Nome = nome;
            this.raca = raca;   
            this.cor = cor;
        }
        public Cachorro()
        {

        }
    }
}
