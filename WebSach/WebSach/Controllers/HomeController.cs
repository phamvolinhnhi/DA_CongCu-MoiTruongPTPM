using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebBookDb _db;
        public HomeController() {
            _db = new WebBookDb();
        }
        
        //public ActionResult Index(int? page, string searchString)
        //{
        //    ViewBag.Keyword = searchString;
        //    if (page == null)
        //        page = 1;
        //    int pageSize = 3;
        //    return View(GetAll(searchString).ToPagedList(page.Value, pageSize));
        //}

        public ActionResult Index()
        {
            return View(GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Detail(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }
            Books books = FindBookById(id.Value);
            if (books == null)
            {
                return HttpNotFound();
            }
            return View(books);

        }
        public ActionResult Revieẉ̣()
        {
            return View();
        }

        public List<Books> GetAll() => _db.Books.ToList();
        public List<Books> GetAll(string searchKey)
        {
            return _db.Books.Where(p => p.Title.Contains(searchKey) || p.Author.Contains(searchKey)).ToList();
        }

        public Books FindBookById(int id)
        {
            return _db.Books.FirstOrDefault(p => p.Book_Id == id);
        }
    }
}