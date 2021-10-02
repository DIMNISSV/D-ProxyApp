using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace D_ProxyApp
{
    class API
    {
        internal static string Connect(string url, string Parameters = "")
        {
            WebClient client = new WebClient();
            string result = "";

            using (Stream stream = client.OpenRead($"{url}?{Parameters}"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        result += line;
                    }
                }
            }

            return result;
        }
        
    }
}
