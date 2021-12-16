using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Thorg_Installer.Config
{
    public class Component
    {
        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        public string Download { get; set; }

        [XmlAttribute]
        public string Sha256 { get; set; }

        [XmlElement("Component")]
        public List<Component> Components { get; set; } = new List<Component>();

        internal bool Find(string id, out Component child)
        {
            foreach (var component in this.Components)
            {
                if (component.Id == id)
                {
                    child = component;
                    return true;
                }
                if (component.Find(id, out child))
                {
                    return true;
                }
            }
            child = null;
            return false;
        }

    }
    public class App
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlElement("Component")]
        public List<Component> Components { get; set; } = new List<Component>();

        public async static Task<App> Load(string uri = "https://golem-releases.cdn.golem.network/thorg/thorg.xml")
        {
            var xs = new XmlSerializer(typeof(App));
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                return xs.Deserialize(await response.Content.ReadAsStreamAsync()) as App;
            }
        }

        public static App FromFile(string path)
        {
            var xs = new XmlSerializer(typeof(App));
            using (var f = File.OpenRead(path))
            {
                return xs.Deserialize(f) as App;
            }
        }

        public Component this[string id]
        {
            get
            {
                foreach (var component in this.Components)
                {
                    if (component.Id == id)
                    {
                        return component;
                    }
                    if (component.Find(id, out var _child))
                    {
                        return _child;
                    }
                }
                return null;
            }
        }


        private static void _flattenComponents(IList<Component> aggregator, IList<Component> components)
        {
            foreach (var c in components)
            {
                aggregator.Add(c);
                _flattenComponents(aggregator, c.Components);
            }
        }

        public IList<Component> GetAllComponents()
        {
            var list = new List<Component>(10);
            _flattenComponents(list, Components);
            return list;
        }

        public ICollection<Component> DiffrenceTo(App _other)
        {
            var me = GetAllComponents();
            var diffrent_sha2 = me.Select(t => t.Sha256).Except(_other.GetAllComponents().Select(t => t.Sha256)).ToList();

            return me.Where(t => diffrent_sha2.Contains(t.Sha256)).ToList();
        }
    }
}
