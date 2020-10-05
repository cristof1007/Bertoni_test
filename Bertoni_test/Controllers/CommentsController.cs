using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Bertoni_test.Models;

namespace Bertoni_test.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
        public async Task<ActionResult> Index(int? id)
        {
            List<Comments> comments = await Comments.parseFromJSON(id);
            return View(comments);
        }
    }
}
