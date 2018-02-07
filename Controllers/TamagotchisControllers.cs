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

        [Route("/tamagotchis/game")]
        public ActionResult Game()
        {
            List<Tama> allTamas = Tama.GetAll();
            return View(allTamas);
        }

        //Actions Below
        [Route("/tamagotchis/feed")]
        public ActionResult Feed()
        {
            Tama.CycleFeedTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [Route("/tamagotchis/play")]
        public ActionResult Play()
        {
            Tama.CyclePlayTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [Route("/tamagotchis/sleep")]
        public ActionResult Sleep()
        {
            Tama.CycleSleepTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [Route("/tamagotchis/wait")]
        public ActionResult Wait()
        {
            Tama.CycleWaitTamas();
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }

        [Route("/tamagotchis/clear")]
        public ActionResult Clear()
        {
            Tama.ClearAll();
            return View("Index");
        }

        [Route("/tamagotchis/remove/{id}")]
        public ActionResult Remove(int id)
        {
            Tama.RemoveByIdAndReassignIds(id);
            List<Tama> allTamas = Tama.GetAll();
            return View("Game", allTamas);
        }
    }
}
