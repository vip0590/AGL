using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace AGL_Test
{
    public static class JsonData
    {
        public static String getData()
        {
            var url = "http://agl-developer-test.azurewebsites.net/people.json";
            var syncClient = new WebClient();
            String content = syncClient.DownloadString(url);
            return content;
            //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));
            //using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            //{
            //    var data = (Person)serializer.ReadObject(ms);
            //}

        }
    }
}
