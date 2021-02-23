using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Review.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Review.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;

        public Reviews Reviews { get; set; }
        public HomeController(ApplicationDbContext cxt)
        {
            context = cxt;
        }

        public async Task<IActionResult> Index()
        {
            //if (ModelState.IsValid)
            //{
            //    if (Reviews == null || Reviews.ReviewsId == 0 || Reviews.ReviewsId > 0)
            //    {
            //        var review = new Reviews();
            //        await context.Reviews.AddAsync(review);
            //        await context.SaveChangesAsync();
            //        return RedirectToAction("Index");
            //    }
            //    else
            //    {
            //        return View();
            //    }
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
