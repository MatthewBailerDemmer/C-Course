using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;

namespace Serializacao_Deserializacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro("Bilu", "Boxer", "Marrom");
            Cachorro meuCachorroDesserializado;
            
            DataContractSerializer serializador = new DataContractSerializer(typeof(Cachorro));

            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriteObject(escritorDeXml, meuCachorro);
            escritorDeXml.Flush();
            string objetoSerializadoStr = construtorDeString.ToString();

            //Salvando o conteudo do objeto num XML
            string caminhoDoMeuArquivoXML = "cachorro.xml";
            FileStream meuArquivoXML = File.Create(caminhoDoMeuArquivoXML);
            meuArquivoXML.Close();
            File.WriteAllText(caminhoDoMeuArquivoXML, objetoSerializadoStr);

            //Desserialização
            string conteudoDoObjetoSeralizado = File.ReadAllText(caminhoDoMeuArquivoXML);
            StringReader leitorDeStrings = new StringReader(conteudoDoObjetoSeralizado);
            XmlReader leitorDeXml = XmlReader.Create(leitorDeStrings);
            meuCachorroDesserializado = (Cachorro) serializador.ReadObject(leitorDeXml);

            escritorDeXml.Close();
            leitorDeXml.Close();
        }
    }
}
