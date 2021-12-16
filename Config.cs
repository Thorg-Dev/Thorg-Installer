using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Thorg_Installer.Config
{
    public class Component
    {
        [XmlAttribute]
        public string Id { get; set; }

        public string Version { get; set; }

        public string Download { get; set; }

        [XmlAttribute]
        public string Sha256 { get; set; }

        [XmlElement("Component")]
        public List<Component> Components { get; set; } = new List<Component>();

    }
    public class App
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlElement("Component")]
        public List<Component> Components { get; set; } = new List<Component>();
        
    }
}
