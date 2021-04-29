using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MyWebMVC.Controllers
{
    public class ShowdataController : Controller
    {
        private ExampleContext db;
        public ShowdataController(ExampleContext ctx)
        {
            db = ctx;
        }
        public async Task<IActionResult> Index()
        {
            var ps = await(from p in db.MyTables
                           orderby p.Id
                           select p).ToListAsync();
            return View(ps);
        }
    }
}
