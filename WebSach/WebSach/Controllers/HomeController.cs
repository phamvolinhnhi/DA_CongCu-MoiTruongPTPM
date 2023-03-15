using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            //    // 1. Đoạn code dùng để tìm kiếm
            //    // 1.1. Lưu tư khóa tìm kiếm
            //    ViewBag.Keyword = searchString;
            //    //1.2 Lưu chủ đề tìm kiếm
            //    ViewBag.Subject = Category_Id;
            //    //1.2.Tạo câu truy vấn kết 3 bảng Book, Author, Category
            //    var books = db.Books.Include(b => b.Author).Include(b => b.Category);

            //    //1.3. Tìm kiếm theo searchString
            //    if (!String.IsNullOrEmpty(searchString))
            //        books = books.Where(b => b.Title.Contains(searchString));

            //    //1.4. Tìm kiếm theo tên sách
            //    if (!String.IsNullOrEmpty(searchString))
            //        books = books.Where(b => b.Title.Contains(searchString));

            //    //1.5. Tìm kiếm theo Category_Id
            //    if (Category_Id != 0)
            //        books = books.Where(c => c.Category_Id == Category_Id);

            //    //1.6. Tìm kiếm theo thể loại
            //    ViewBag.Category_Id = new SelectList(db.Categories, "Category_Id", "Category_Name"); // danh sách Category   

            //    //1.7 Tìm kiếm theo tên tác giả
            //    if (!String.IsNullOrEmpty(searchString))
            //        books = books.Where(b => b.Author_Name.Contains(searchString));

            //    return View(books);
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}