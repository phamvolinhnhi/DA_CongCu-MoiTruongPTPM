using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Controllers
{
    public class UserController : Controller
    {
        private readonly Model1 context = new Model1();

        // GET: User
        private Model1 db = new Model1();

     
       

        public ActionResult Profile()
        {
            return View();
        }
      

      

        public ActionResult Detail(string user)
        {

            if (String.IsNullOrEmpty(user))
            {
                return HttpNotFound();
            }
            User find = context.Users.FirstOrDefault(p => p.User_Name == user);
            if (find == null)
                return HttpNotFound();
            return View(find);

        }


    }
}
   
    

   

