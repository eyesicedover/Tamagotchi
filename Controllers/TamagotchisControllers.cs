using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;

namespace Tamagotchis.Controllers
{
    public class TamagotchisController : Controller
    {
        [HttpGet("/tamagotchis")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/tamagotchis/new")]
        public ActionResult Create()
        {
            Tama newTama = new Tama(Request.Form["tamaName"]);
            newTama.Save();
            return View(newTama);
        }

        [HttpPost("/tamagotchis/game")]
        public ActionResult Game()
        {
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        //Actions Below
        [HttpPost("/tamagotchis/game")]
        public ActionResult Feed()
        {
            Tama.CycleFeedTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [HttpPost("/tamagotchis/game")]
        public ActionResult Play()
        {
            Tama.CyclePlayTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [HttpPost("/tamagotchis/game")]
        public ActionResult Sleep()
        {
            Tama.CycleSleepTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [HttpPost("/tamagotchis/game")]
        public ActionResult Wait()
        {
            Tama.CycleWaitTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }
    }
}
