using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ComicBooksCharacters.Models;

namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
        private ComicBookContext cbcontext = null;
        public HomeController(ComicBookContext context)
        {
            cbcontext = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(cbcontext);
        }
    }
}
