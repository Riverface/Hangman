using HangMan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace HangMan.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index(){
            return View();
        }
    }
}