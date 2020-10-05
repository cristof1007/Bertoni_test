using Bertoni_test.Controllers.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Bertoni_test.Models
{
    public class Albums
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }

        public static async Task<List<Albums>> parseFromJSON()
        {
            var data = await JsonRequests.request("albums"); 
            var json_serializer = new JavaScriptSerializer();
            var routes_list = json_serializer.Deserialize<List<Albums>>(data);
            return routes_list;
        }
    }
}