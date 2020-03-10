using JobBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace FriendLetter.Controllers
{
    public class JobsController : Controller
    {

        [HttpGet("/jobs")]
        public ActionResult Index(){
        return View(Job.GetAll());
        }
        [HttpGet("/jobs/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/jobs")]
        public ActionResult Create(string name, string company, string position)
        {
            Job tempOpening = new Job(name, company, position);
            return RedirectToAction("Index");
        }

        [HttpGet("/jobs/{id}")]
        public ActionResult Show(int id)
        {
            Job foundOpening = Job.GetOpeningByID(id);
            return View(foundOpening);
        }
        [HttpPost("/jobs/delete")]
        public ActionResult Delete()
        {
        Job.ClearAll();
        return RedirectToAction("Index");
        }
    }
}