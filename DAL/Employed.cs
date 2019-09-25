using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using DTO;
using Newtonsoft.Json;

namespace DAL
{
    public class Employed
    {
        private string baseUrl = "http://masglobaltestapi.azurewebsites.net/api";
        public ResponseDTO getEmployes()
        {
            var resp = new ResponseDTO { status = false };
            try
            {
                HttpClient http = new HttpClient();
                string url = baseUrl + "/Employees";
                HttpResponseMessage response = http.GetAsync(new Uri(url)).Result;
                string responseBody = response.Content.ReadAsStringAsync().Result;
                resp.data = JsonConvert.DeserializeObject<List<EmployedDTO>>(responseBody);
                resp.status = true;
            }
            catch (Exception e)
            {
                resp.message = e.Message;
            }
            return resp;
        }
    }
}
