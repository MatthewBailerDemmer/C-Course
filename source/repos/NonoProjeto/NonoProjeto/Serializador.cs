﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;
using Oitavo_Projeto;
using Microsoft.SqlServer.Server;

namespace NonoProjeto
{
    internal static class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BaseDeDados));

        public static void Serializa(string pCaminhoArquivoXml, BaseDeDados pBaseDeDados)
        {
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true};
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, settings);
            serializador.WriteObject(escritorDeXml, pBaseDeDados);
            escritorDeXml.Flush();
            string objetoSerializadoStr = construtorDeString.ToString();


            FileStream meuArquivoXml = File.Create(pCaminhoArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(pCaminhoArquivoXml, objetoSerializadoStr);

            escritorDeXml.Close();
        }
        public static BaseDeDados Desserializa(string pCaminhoArquivoXml)
        {

            try
            {
                if(File.Exists(pCaminhoArquivoXml))
                {
                    string conteudoDoObjetoSerializado = File.ReadAllText(pCaminhoArquivoXml);
                    StringReader leitorDeString = new StringReader(conteudoDoObjetoSerializado);
                    XmlReader leitorDeXml = XmlReader.Create(leitorDeString);
                    BaseDeDados BaseDeDadosTemp = (BaseDeDados) serializador.ReadObject(leitorDeXml);
                    return BaseDeDadosTemp;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
