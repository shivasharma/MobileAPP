using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MSTL.Model;
using Newtonsoft.Json;

namespace MSTL.Services
{
    public class AppService
    {
        private const string baseURIString = "http://ec2-54-205-196-55.compute-1.amazonaws.com:3001";

        public async Task<string> SendEmail(ContactInfo c)
        {
            //testing
            var httpClient = new HttpClient();
            var baseURI = new Uri(baseURIString);

            httpClient.BaseAddress = baseURI;
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("name", c.Name),
                new KeyValuePair<string, string>("email", c.Email),
                new KeyValuePair<string, string>("message", c.Message)
            });

            var response = await httpClient.PostAsync("/email/send", content);
            var rescontent = await response.Content.ReadAsStringAsync();

            dynamic res = JsonConvert.DeserializeObject(rescontent);

            string status = res.status;

            return status;
        }
    }
}