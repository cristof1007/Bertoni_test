using Bertoni_test.Controllers.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace Bertoni_test.Models
{
    public class Comments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }

        public static async Task<List<Comments>> parseFromJSON(int? photoId)
        {
            var data = await JsonRequests.request("comments");
            var json_serializer = new JavaScriptSerializer();
            var routes_list = json_serializer.Deserialize<List<Comments>>(data);
            return routes_list.Where(c=>c.postId == photoId).ToList();
        }
    }
}