using CORE_CRUD.Db_Connect;
using CORE_CRUD.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CORE_CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            EMPLOYEEINFOContext obj = new EMPLOYEEINFOContext();
            List<EMPModel> mdb = new List<EMPModel>();
            var res = obj.Employees.ToList();
            foreach (var item in res)
            {
                mdb.Add(new EMPModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Mobile = item.Mobile,
                    Password = item.Password
                });
            }
                return View(mdb);
        }
        [Authorize]
        public IActionResult Delete(int id)
        {
            EMPLOYEEINFOContext obj = new EMPLOYEEINFOContext();
            var deleteitem = obj.Employees.Where(m => m.Id == id).First();
            obj.Employees.Remove(deleteitem);
            obj.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Authorize]
        public IActionResult ADD()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult ADD(EMPModel empobj)
        {
            EMPLOYEEINFOContext obj = new EMPLOYEEINFOContext();
            Employee tblobj = new Employee();
            tblobj.Id = empobj.Id;
            tblobj.Name = empobj.Name;
            tblobj.Email = empobj.Email;
            tblobj.Mobile = empobj.Mobile;
            tblobj.Password = empobj.Password;
            if (empobj.Id == 0)
            {
                obj.Employees.Add(tblobj);
                obj.SaveChanges();
            }
            else
            {
                obj.Entry(tblobj).State = EntityState.Modified;
                obj.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            EMPModel empobj = new EMPModel();
            EMPLOYEEINFOContext obj = new EMPLOYEEINFOContext();
            var edit = obj.Employees.Where(m => m.Id == id).First();


            empobj.Id = edit.Id;
            empobj.Name = edit.Name;
            empobj.Email = edit.Email;
            empobj.Mobile = edit.Mobile;
            empobj.Password = edit.Password;

            //ViewBag.Id = edit.Id;

            return View("ADD", empobj);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return View("login");
        }


        [HttpGet]
        public IActionResult login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult login(EMPModel objUser)
        {
            EMPLOYEEINFOContext obj = new EMPLOYEEINFOContext();
            var res = obj.Employees.Where(m =>m.Email== objUser.Email).FirstOrDefault();

            if (res == null)
            {

                TempData["Invalid"] = "Wrong Email Enter The Correct Email";
            }

            else
            {
                if (res.Email == objUser.Email && res.Password == objUser.Password)
                {

                    var claims = new[] { new Claim(ClaimTypes.Name, res.Name),
                                        new Claim(ClaimTypes.Email, res.Email) };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };
                    HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(identity),
                    authProperties);


                    HttpContext.Session.SetString("Name", res.Name);
                    HttpContext.Session.GetString("Name");

                    return RedirectToAction("Index", "Home");

                }

                else
                {

                    ViewBag.Inv = "Wrong Password";

                    return View("login");
                }


            }


            return View("login");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
