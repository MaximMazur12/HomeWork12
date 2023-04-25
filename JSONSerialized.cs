using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_HW12
{
   public class JSONSerialized
    {
        public string Serialize(ElectricalDevices electrDev)
        {
            var json = JsonConvert.SerializeObject(electrDev);
            Console.WriteLine(json);
            return json;
        }

        public ElectricalDevices Deserialize(string json)
        {
            var deserializeDev = JsonConvert.DeserializeObject<ElectricalDevices>(json);
            return deserializeDev; 
        }
    }
}
