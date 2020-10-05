using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Bertoni_test.Controllers.Tools
{
    public class JsonRequests
    {
        static string mainURL = "https://jsonplaceholder.typicode.com";

        public static async Task<string> request(string url)
        {
            using(HttpClient client = new HttpClient())
            {
                url = string.Format("{0}/{1}", mainURL, url);
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    return data;
                }

                return null;
            }
        }
    }
}