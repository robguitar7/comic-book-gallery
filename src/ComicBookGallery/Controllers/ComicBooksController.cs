using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller 
    {
        public ActionResult Detail()
        {
            var day = DateTime.Today.DayOfWeek;

            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
              
            }
            return Content("Hello from the comic books controller! and Today is: "+ day);
        }
    }
}