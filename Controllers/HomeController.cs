using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DbConnection;
using Microsoft.AspNetCore.Http;

namespace mys2msapp.Controllers
{
    public class HomeController : Controller{
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(string Username, string Email, string Password, string PasswordConfirmation){
            //*** REGISTRATION 1 ***
            //Check Email To See If It Already Exists - Retrieve a User Using the Provided Email
            Dictionary<string, object> UserExist = DbConnector.Query($"SELECT * FROM users WHERE email = '{Email}';").FirstOrDefault();
            if(UserExist == null){
                if(Password != PasswordConfirmation){
                    ViewBag.RegError = "Passwords do not match!";
                    return View("Index");
                } else {
                    // Validate for empty
                    if(Username == null || Email == null || Password == null){
                        ViewBag.RegError = "Please complete all required fields";
                        return View("Index");
                    } else {
                        //*** REGISTRATION 2 ***
                        // Create the New User
                        DbConnector.Execute($"INSERT INTO users (username, email, password) VALUES ('{Username}', '{Email}', '{PasswordConfirmation}' );");
                        // *** REGISTRATION 3 ***
                        //Set this user's id in session before redirecting
                        Dictionary<string, object> CurrUser = DbConnector.Query($"SELECT * FROM users WHERE email = '{Email}';").FirstOrDefault();
                        HttpContext.Session.SetInt32("SessionId", (int)(long)CurrUser["userId"]);
                        return RedirectToAction("Dashboard");
                    }
                }
            } else {
                ViewBag.RegError = "This email currently exists!";
                return View("Index");
            }
        }

        [HttpGet]
        [Route("Dashboard")]
        public IActionResult Dashboard(){
            int? CurrSessionId = HttpContext.Session.GetInt32("SessionId");
            if(CurrSessionId == null){
                return RedirectToAction("Index");
            } else {
                //*** DASHBOARD 1 ***
                //Retrieve Current User
                Dictionary<string, object> CurrUser = DbConnector.Query($"SELECT * FROM users WHERE userId = {CurrSessionId};").SingleOrDefault();
                ViewBag.CurrUser = CurrUser;
            }
            //*** DASHBOARD 2 ***
            //Retrieve Current User's ToDos
            ViewBag.AllToDos = DbConnector.Query($"SELECT * FROM toDos WHERE userId = {CurrSessionId};");
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(string Email, string PwToCheck){
            //*** LOGIN ***
            //Retrieve user with email
            Dictionary<string, object> CurrUser = DbConnector.Query($"SELECT * FROM users WHERE email = '{Email}';").FirstOrDefault();
            if(CurrUser == null){
                ViewBag.LogError = "This email has not been registered. Please register or try again!";
                return View("Index");
            } else {
                //check password
                if(CurrUser["password"].ToString() != PwToCheck){
                    ViewBag.LogError = "The password is incorrect - please try again!";
                    return View("Index");
                }
            }
            //Set this user's id in session before redirecting
            HttpContext.Session.SetInt32("SessionId", (int)(long)CurrUser["userId"]);
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("Logout")]
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpPost]
        [Route("AddTodo")]
        public IActionResult AddTodo(string Title, string Description){
            if(Title == null || Description == null){
                ViewBag.TodoError = "Please include all required fields.";
            } else {
                //*** CREATE TODO ***
                //Create New ToDo
                DbConnector.Execute($"INSERT INTO toDos (title, description, userId) VALUES ('{Title}', '{Description}', {HttpContext.Session.GetInt32("SessionId")});");
            }
            return RedirectToAction("Dashboard");
        }


        [HttpGet]
        [Route("Delete/{TodoID}")]
        public IActionResult Delete(int TodoId){
            //*** DELETE TODO ***
            //Delete Todo
            DbConnector.Execute($"DELETE FROM toDos WHERE toDosId = {TodoId};");
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [Route("Edit/{TodoID}")]
        public IActionResult Edit(int TodoId){
            //*** EDIT TODO 1 ***
            //Retreive ToDo Using TodoId
            Dictionary<string, object> CurrTodo = DbConnector.Query($"SELECT * FROM toDos WHERE toDosId = {TodoId};").SingleOrDefault();
            ViewBag.CurrTodo = CurrTodo;
            return View();
        }

        [HttpPost]
        [Route("EditTodo")]
        public IActionResult EditTodo(string Title, string Description, int TodoId){
            //*** EDIT TODO 2 ***
            //Update Todo
            DbConnector.Execute($"UPDATE toDos SET title = '{Title}', description = '{Description}' WHERE toDosId = {TodoId};");
            return RedirectToAction("Dashboard");
        }



    }
}
