using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Planen
{
    class Weather
    {
        private XmlAnyAttributeAttribute weatherAPI;
        public XmlAnyAttributeAttribute WetaherAPI { get { return weatherAPI; } set { weatherAPI = value; } }   
        public void getWeatherAPI(XmlAnyAttributeAttribute API) { }
    }
}
