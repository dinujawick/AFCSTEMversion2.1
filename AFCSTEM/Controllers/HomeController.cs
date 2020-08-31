using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AFCSTEM.Models;

namespace AFCSTEM.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPlayerRepository _playerRepository;

        private readonly ITeamRepository _teamRepository;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IPlayerRepository playerRepository,ILogger<HomeController> logger, ITeamRepository teamRepository)
        {
            _logger = logger;
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;

        }


        public IActionResult Whatisfooty()
        {
            return View();
        }

        public IActionResult Activity1()
        {
            return View();
        }

        public IActionResult Activity2()
        {
            return View();
        }

        public IActionResult Activity3()
        {
            return View();
        }

        public IActionResult Activity4()
        {
            return View();
        }


        public IActionResult Activity5()
        {
            return View();
        }


        public IActionResult Activity6()
        {
            return View();
        }

        public IActionResult Activity7()
        {
            return View();
        }

        public IActionResult Activity8()
        {
            return View();
        }

        public IActionResult Activity9()
        {
            return View();
        }

        public IActionResult Activity10()
        {
            return View();
        }

        public IActionResult Activity11()
        {
            return View();
        }

        public IActionResult Activity12()
        {
            return View();
        }

        public IActionResult Activity13()
        {
            return View();
        }

        public IActionResult Activity14()
        {
            return View();
        }

        public IActionResult Activity15()
        {
            return View();
        }
        public IActionResult Activity16()
        {
            return View();
        }
        public IActionResult Activity17()
        {
            return View();
        }















        public IActionResult StemID()
        {
            return View();
        }
        public IActionResult Unit1Home()
        {
            return View();
        }
        public IActionResult Unit2Home()
        {
            return View();
        }
        public IActionResult Unit3Home()
        {
            return View();
        }
        public IActionResult Unit4Home()
        {
            return View();
        }

        public IActionResult Workbook()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Crowball()
        {
            return View();
        }
        public IActionResult MVP()
        {
            return View();
        }
        public IActionResult Survey()
        {
            return View();
        }
        public IActionResult AccountDetails()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SubmitTeam(String StudentId, int DEF2, int DEF3, int DEF4, int DEF5, int DEF6, 
            int DEF1, int FWD1, int FWD2, int FWD3, int FWD4, int FWD5, int FWD6, int MID1, int MID2, int MID3, int MID4, int RUCK1, int RUCK2)
        {
            Team team = _teamRepository.GetTeam(StudentId);

            if (team == null)
            {
                _teamRepository.CreateTeam(StudentId, DEF2, DEF3, DEF4, DEF5, DEF6, DEF1, FWD1, FWD2, FWD3, FWD4, FWD5, FWD6, MID1, MID2, MID3, MID4, RUCK1, RUCK2);
            }
            else {
                _teamRepository.UpdateTeam(team, DEF2, DEF3, DEF4, DEF5, DEF6, DEF1, FWD1, FWD2, FWD3, FWD4, FWD5, FWD6, MID1, MID2, MID3, MID4, RUCK1, RUCK2);
            }
            return Json(new { success = "Team Saved" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
