using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application_Test
{
    [Serializable]
    public class Perfil
    {
        [XmlAttribute(AttributeName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "Categoria")]
        public string Categoria { get; set; }

        [XmlElement(ElementName = "NomePerfil")]
        public string NomePerfil { get; set; }

        [XmlElement(ElementName = "Caminho")]
        public string Caminho { get; set; }

        [XmlArray(ElementName = "Fields")]
        public List<Field> Fields { get; set; }
    }
}