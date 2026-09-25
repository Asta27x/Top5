using Microsoft.AspNetCore.Mvc;

namespace Top5.Controllers
{
    public class Top5Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("rank/{id:range(1,5)}")]
        public IActionResult Number(int id)
        {
            string[] items =
            {
                "Asta",
                "Ichigo",
                "Luffy",
                "Shinra",
                "Naruto",
                "Deku",
                "Goku",
            };

            //if (id > items.Length || id < 1)
            //{
              //  return NotFound();
            //}

            ViewData["Items"] = $"{items[id - 1]}";

            return View();
        }
        [HttpGet("about-my-list")]
        public IActionResult About()
        {

            return View();
        }
        [HttpGet("character/{**anything}")]
        public IActionResult NotOnList(
            string anything)
        {
            ViewData["Asked"] = anything;
            return View();
        }
    }
    }
