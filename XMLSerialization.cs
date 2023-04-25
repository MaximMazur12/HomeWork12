using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    internal class XMLSeraializer
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(ElectricalDevices));
        public string Serialize(ElectricalDevices devices)
        {
            var writer = new StringWriter();
            serializer.Serialize(writer, devices);
            var xmlStr = writer.ToString();
            Console.WriteLine(xmlStr);
            return xmlStr;
        }
          
    }
}
