using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JSON_HW12;

var electrDev = new ElectricalDevices();

var jsonSerializer = new JSONSerialized();
var json = jsonSerializer.Serialize(electrDev);
var dererializedDev = jsonSerializer.Deserialize(json);