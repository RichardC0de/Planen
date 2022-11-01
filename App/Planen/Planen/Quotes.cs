using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Planen
{
    internal class Quotes
    {
        private string quotesString;
        private XmlAnyAttributeAttribute quotesAPI;
        public string QuotesString { get { return quotesString; } set { quotesString = value; } }
        public XmlAnyAttributeAttribute QuotesAPI { get { return quotesAPI; } set { quotesAPI = value; } }
        public void getQuotes(XmlAnyAttributeAttribute API) { }
    }
}
