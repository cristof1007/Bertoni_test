using Bertoni_test.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Bertoni_test.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public async Task<ActionResult> Index(int? id)
        {
            var photos = await Photos.parseFromJSON(id);
            return View(photos);
        }

    }
}
