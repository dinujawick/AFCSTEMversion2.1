using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AFCSTEM.Models;
using Microsoft.Extensions.Hosting;


using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace AFCSTEM.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IPlayerRepository _playerRepository;
        private readonly IWorkbookRepository _workbookRepository;
        private readonly IHostingEnvironment _hostEnviroment;
        private readonly ITeamRepository _teamRepository;
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(IPlayerRepository playerRepository, ILogger<HomeController> logger, ITeamRepository teamRepository, IWorkbookRepository workbook,IHostingEnvironment hostEnviroment )
        {
            _logger = logger;
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
            _workbookRepository = workbook;
            this._hostEnviroment = hostEnviroment;
        }


        public IActionResult Whatisfooty()
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
            else
            {
                _teamRepository.UpdateTeam(team, DEF2, DEF3, DEF4, DEF5, DEF6, DEF1, FWD1, FWD2, FWD3, FWD4, FWD5, FWD6, MID1, MID2, MID3, MID4, RUCK1, RUCK2);
            }
            return Json(new { success = "Team Saved" });
        }
        
        [HttpPost]
        public IActionResult SubmitWorkbook(string studentID,
            string act1table1, string act1table2, float cswidth1, float cslength1, float csarea1, string act1table3, string act1row1, string act1row2, string act1row3, string act1row4, float act2lengs, float act2widgs,float act2areags,
            float act2lengp, float act2widgp, float act2areagp, float act2lenbp, float act2widbp, float act2areabp, string box1, string box2, string box3, string act2text1, string act2t4, string act2t5, float act2lengs2, float act2widgs2, float act2areags2,
            float mcgLength, float mcgWidth, float mcgArea, float msLength, float msWidth, float msArea, float gmhLength, float gmhWidth, float gmhArea, float scgLength, float scgWidth, float scgArea, float ssLength, float ssWidth, float ssArea,
            float osLength, float osWidth, float osArea, float gLength, float gWidth, float gArea, float metLength, float metWidth, float metArea, string largestArea, string smallestArea, string crowdCapacity, string act3q4, string act3q5,string act3q6, string act3q7, string act3q8)
        {

            Workbook workbook = _workbookRepository.GetWorkbook(studentID);

            if (workbook == null)
            {
                _workbookRepository.CreateWorkbookActivity(studentID, act1table1,act1table2);
            }
            else
            {
                _workbookRepository.UpdateWorkbookActivity(workbook, act1table1, act1table2, cswidth1, cslength1, csarea1,act1table3,act1row1,act1row2,act1row3,act1row4,act2lengs,act2widgs,act2areags,act2lengp,act2widgp,act2areagp,act2lenbp,act2widbp,act2areabp,act2text1,box1,box2,
                    box3,act2t4,act2t5,act2lengs2,act2widgs2,act2areags2,mcgLength, mcgWidth,mcgArea,msLength,msWidth, msArea,gmhLength,gmhWidth,gmhArea,scgLength,scgWidth,scgArea,ssLength,ssWidth,ssArea,
                 osLength,osWidth,osArea,gLength,gWidth,gArea, metLength, metWidth, metArea,largestArea,smallestArea,crowdCapacity,act3q4,act3q5,act3q6,act3q7,act3q8);
            }
            return Json(new { success = "Workbook Saved" });
        }

        [HttpPost]
        public IActionResult HidePlayer(string name, bool hide)
        {
            Player player = _playerRepository.getPlayerByName(name);

            if (player == null) {
                return Json(new { error = "NoPlayer" });



            }
            _playerRepository.HidePlayer(player, hide);
           
            return Json(new { success = "player updated" });
        }



        [HttpPost]
        public IActionResult CreatePlayer(int Number, string Name, string Gender, string Position, int Price, int Height, DateTime DateOfBirth, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
            int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches, bool Hidden)
        {
           

            _playerRepository.createPlayer(Number,Name ,Gender, Position, Price, Height,DateOfBirth, Age, KickAvg, KickTotal, HandballAvg, HandballTotal, DisposalAvg, DisposalTotal, MarksAvg, MarksTotal, HOAvg,
          HOTotal, ClearanceAvg, ClearanceTotal, CentreClearanceAvg, CentreClearanceTotal, TackleAvg, TackleTotal, GoalsAvg, GoalsTotal, BehindsAvg, BehindsTotal, Matches,Hidden);


            return Json(new { success = "player updated" });
        }



        [HttpPost]
        public IActionResult UpdatePlayer(string name, string Position, int Price, int Height, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
          int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches,string Gender)
        {

           
            Player player = _playerRepository.getPlayerByName(name);



            _playerRepository.updatePlayer(player, Position, Price, Height, Age, KickAvg, KickTotal, HandballAvg, HandballTotal, DisposalAvg, DisposalTotal, MarksAvg, MarksTotal, HOAvg,
          HOTotal, ClearanceAvg, ClearanceTotal, CentreClearanceAvg, CentreClearanceTotal, TackleAvg, TackleTotal, GoalsAvg, GoalsTotal, BehindsAvg, BehindsTotal, Matches,Gender);
          

            return Json(new { success = "player updated" });
        }

        [HttpPost]
        public async Task<bool> ImagePost(IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\images\Players\", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                return true;
            }
            return false;

        }


        [HttpGet]
        public IActionResult GetPlayer(string name)
        {
            var player = _playerRepository.getPlayerByName(name);
            if(player == null)
            {
                return Json(new { error = "NoPlayer" });
            }

            
            
            return Json(new { player });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
