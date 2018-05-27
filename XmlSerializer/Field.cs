using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application_Test
{
    [Serializable]
    public class Field
    {
        [XmlAttribute(AttributeName = "Id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "FieldThe")]
        public string FieldThe { get; set; }

        [XmlElement(ElementName = "FieldDoc")]
        public string FielDoc { get; set; }
    }
}