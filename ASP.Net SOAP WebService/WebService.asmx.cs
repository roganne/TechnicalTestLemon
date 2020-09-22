using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace SOAP_WebService
{
    /// <summary>
    /// WebService with two methods, Fibonacci and XmlToJson
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public int Fibonacci(int n)
        {
            int result = -1;
            if (n >= 1 && n <= 100)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                result = a;
            }
            return result;
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            string result = string.Empty;
            try
            {
                //Load Xml into Xdocument
                var doc = XDocument.Parse(xml);

                //Remove null values to match expected results
                doc.Descendants().Where(e => e.FirstNode == null ).Remove();

                //Serialize into a Json string
                result = JsonConvert.SerializeXNode(doc);

                //Beautify results for display
                dynamic parsedJson = JsonConvert.DeserializeObject(result);
                result =  JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
            }
            catch (Exception)
            {
                result = "Bad Xml format";
            }
            return result;
        }
    }
}
