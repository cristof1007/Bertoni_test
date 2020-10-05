using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Bertoni_test.Models;

namespace Bertoni_test.Controllers
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public async Task<ActionResult> Index()
        {
            List<Albums> albums = await Albums.parseFromJSON();
            return View(albums);
        }
    }
}
