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

                campos.Add(new Field { Id = 1, FielDoc = "ioquhduiqwh", FieldThe = "qiowjdoiqwjd" });
                campos.Add(new Field { Id = 2, FielDoc = "qiodqwd", FieldThe = "apjisjaiojd" });

                Perfil teste = new Perfil { Id = 123, Categoria = "Felicidade", NomePerfil = "Helmuth", Caminho = "CAMINHO", Fields = campos };

                campos = new List<Field>();
                campos.Add(new Field { Id = 1, FielDoc = "iurhuite", FieldThe = "mkvbmnbvmv" });
                campos.Add(new Field { Id = 2, FielDoc = "llwlwlwl", FieldThe = "nmcnvnvn" });

                Perfil teste2 = new Perfil { Id = 145, Categoria = "teste", NomePerfil = "Digoo", Caminho = "CAMINHO2", Fields = campos };

                campos = new List<Field>();
                campos.Add(new Field { Id = 1, FielDoc = "nbmvbmbnasd", FieldThe = "nbvxcbvnxvb" });
                campos.Add(new Field { Id = 2, FielDoc = "iuwieruiweur", FieldThe = "vbknOAISJOQFJ" });

                Perfil teste3 = new Perfil { Id = 356, Categoria = "testeDiogo", NomePerfil = "Vitor", Caminho = "CAMINHO3", Fields = campos };

                listaExemplo.Add(teste);
                listaExemplo.Add(teste2);
                listaExemplo.Add(teste3);

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
            TextWriter textWriter = new StreamWriter(@"C:\Users\Helmuth\Desktop\input.xml");
            x.Serialize(textWriter, listaExemplo);
            textWriter.Close();
        }

        static List<Perfil> Deserialize()
        {
            XmlSerializer y = new XmlSerializer(typeof(List<Perfil>));
            TextReader textReader = new StreamReader(@"C:\Users\Helmuth\Desktop\input.xml");
            List<Perfil> lista;
            lista = (List<Perfil>)y.Deserialize(textReader);
            textReader.Close();

            return lista;
        }


    }
}
