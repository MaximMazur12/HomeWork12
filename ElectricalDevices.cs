using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Serialization
{
    [Serializable]
    public  class ElectricalDevices
    {
        protected string Name { get; set; }
        public int dateRealise;
        protected int weight;
        protected string operatingSystem;
        private decimal Price { get; }

        public virtual void Sum(int a, int b)      
        {
            int Sum = a + b;
        }

        public float MathOperations(float a, float b)   
        {
            return a + b;
        }
        public ElectricalDevices()
        {
            Name = "Samsung";
            dateRealise = 2010;
            operatingSystem = "Android";
        }
    }
}
