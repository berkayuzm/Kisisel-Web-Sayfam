using BlogSayfam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogSayfam.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            var bloglar = db.Bloglar.Where(i => i.IsHomepage == true).ToList();

            return View(bloglar);
        }
        public ActionResult Bloglar()
        {

            return View(db.Bloglar.ToList());
        }
      
        public ActionResult BlogDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Bloglar.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

    }
}