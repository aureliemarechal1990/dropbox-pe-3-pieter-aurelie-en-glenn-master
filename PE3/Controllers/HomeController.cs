using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PE3.Models;
using PE3.Data;
using System.Data.SqlClient;
using PE3.Entities;

namespace PE3.Controllers
{
    public class HomeController : Controller
    {
        private QuizContext quizcontext;

        public HomeController(QuizContext context)
        {
            quizcontext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Addteacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult controleerGegevens(string username, string password)
        {

            var gebruiker = quizcontext.Teachers.FirstOrDefault(leerkracht => leerkracht.Login == username && leerkracht.Password == password);
            
            if (gebruiker != null)
            {
                return RedirectToAction("account");
                
            }
            else if (gebruiker == null)
            {
                return RedirectToAction("index");
            }

            return View();
        }


        [HttpPost]
        public IActionResult createTeacher(string firstname,string lastname,string username, string password)
        {

            var teacherexists = quizcontext.Teachers.FirstOrDefault(leerkracht => leerkracht.Login == username);

            if (teacherexists != null)
            {
                ViewBag.Message = "Deze gebruiker bestaat al, probeer een andere username";
                return View("addTeacher");
                

            }
            else if (teacherexists == null)
            {
                var teacher = new Teacher { FirstName = firstname, LastName = lastname , Login = username, Password= password };
                quizcontext.Teachers.Add(teacher);
                quizcontext.SaveChanges();
                ViewBag.Message = "account aangemaakt, je kan nu inloggen";
                return View("index");
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
