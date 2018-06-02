using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Application_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {

            try
            {
                List<Perfil> listaExemplo = new List<Perfil>();
                List<Field> campos = new List<Field>();

                campos.Add(new Field { Id = 1, FielDoc = "teste", FieldThe = "teste2" });

                Perfil teste = new Perfil { Id = 123, Categoria = "teste1", NomePerfil = "teste2", Caminho = "teste3", Fields = campos };

                listaExemplo.Add(teste);

                Serialize(listaExemplo);
                listaExemplo = Deserialize();
                Serialize(listaExemplo);

            }
            catch (Exception log)
            {
                Console.WriteLine("Erro");
                throw log;
            }
        }

        static void Serialize(List<Perfil> listaExemplo)
        {
            XmlSerializer x = new XmlSerializer(listaExemplo.GetType());
            TextWriter textWriter = new StreamWriter(@"path");
            x.Serialize(textWriter, listaExemplo);
            textWriter.Close();
        }

        static List<Perfil> Deserialize()
        {
            XmlSerializer y = new XmlSerializer(typeof(List<Perfil>));
            TextReader textReader = new StreamReader(@"path");
            List<Perfil> lista;
            lista = (List<Perfil>)y.Deserialize(textReader);
            textReader.Close();

            return lista;
        }


    }
}
