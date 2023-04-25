using System.Text.Json.Serialization;
using System.Xml.Serialization;
using Serialization;

var electricalDev = new ElectricalDevices();

var xmlSerializer = new XMLSeraializer();
var data = xmlSerializer.Serialize(electricalDev);
var deserialized = xmlSerializer.Deserialize(data);

