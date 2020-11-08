
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace VKAPI
{
    public class VKAPI
    {


        public static string VkAsk(string url) {
            System.Net.WebRequest webRequest = System.Net.WebRequest.Create(url);
            System.Net.WebResponse webResponse = (System.Net.WebResponse)webRequest.GetResponse();
            System.IO.Stream dataStream = webResponse.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            webResponse.Close();
            return responseFromServer;
        }
    }

    
}
