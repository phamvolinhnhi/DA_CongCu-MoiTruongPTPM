using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebSach.Models;

namespace WebSach.Controllers
{
    public class AccountController : Controller
    {
        private WebBookDb _db = new WebBookDb();
        // GET: Account
        public ActionResult Index()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        // LOGIN
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User _user)
        {
            if (ModelState.IsValid)
            {
                var f_password = GetMD5(_user.Password);
                var data = _db.User.Where(s => s.User_Name.Equals(_user.User_Name) && s.Password.Equals(f_password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    Session["Email"] = data.FirstOrDefault().Email;
                    Session["FullName"] = data.FirstOrDefault().Full_Name;
                    Session["UserName"] = data.FirstOrDefault().User_Name;
                    data.FirstOrDefault().Last_Login = DateTime.Now;
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Index","Home");
        }



        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        //GET: Register
        public ActionResult Register()
        {
            return View();
        }

        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User _user)
        {
            if (ModelState.IsValid)
            {
                
                var check = _db.User.FirstOrDefault(s => s.User_Name == _user.User_Name);
                if (check == null)
                {
                    User newUser = new User
                    {
                        User_Name = _user.User_Name,
                        Full_Name = _user.Full_Name,
                        Email = _user.Email,
                        Password = GetMD5(_user.Password),
                        Create_at = DateTime.Now,
                        Permission_Id = false
                    };

                    _db.Configuration.ValidateOnSaveEnabled = false;
                    _db.User.Add(newUser);
                    _db.SaveChanges();
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ViewBag.error = "Username already exists";
                    return View();
                }


            }
            return View();
        }
    }
}