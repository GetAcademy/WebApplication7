using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class MatchController : Controller
    {
        Match[] _matches = new Match[]
            {
                new Match{Id=1, HomeTeam="A", AwayTeam="B", Date=DateTime.Now},
                new Match{Id=2, HomeTeam="A", AwayTeam="C", Date=DateTime.Now.AddDays(-1)},
                new Match{Id=3, HomeTeam="C", AwayTeam="B", Date=DateTime.Now.AddDays(-2)},
            };

        public IActionResult List()
        {
            return View(_matches);
        }

        public IActionResult Single(int id)
        {
            var match = _matches.FirstOrDefault(m => m.Id == id);
            return View(match);
        }
    }
}
