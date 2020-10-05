using Bertoni_test.Controllers.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Bertoni_test.Models
{
    public class Photos
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }

        public static async Task<List<Photos>> parseFromJSON(int? albumId)
        {
            var data = await JsonRequests.request("photos");
            var json_serializer = new JavaScriptSerializer();
            var routes_list = json_serializer.Deserialize<List<Photos>>(data);
            return routes_list.Where(a => a.albumId == albumId).ToList();
        }
    }
}