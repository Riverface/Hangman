using HangMan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace HangMan.Controllers
{
    public class HangManController : Controller
    {
        [HttpGet("/HangMan/New")]
        public ActionResult NewGame(){
        HMGame.game = new HMGame("triskaidekaphobia", 12);
        return RedirectToAction("Game");
        }
        [HttpGet("/HangMan/Game")]
        public ActionResult Game()
        {

            return View(HMGame.game);
        }
        [HttpPost("/HangMan/Game")]
        public ActionResult Guess(char guess)
        {
        HMGame.game.Guess(guess);
        HMGame.game.BuildUnsolved();
        return RedirectToAction("Game");
        }
    }
}