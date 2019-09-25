using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace masglobal
{
    public class REST
    {
        public string Get(string url)
        {
            HttpClient http = new HttpClient();
            HttpResponseMessage response = http.GetAsync(new Uri(url)).Result;
            string responseBody = response.Content.ReadAsStringAsync().Result;
            return responseBody;
        }
    }
}
