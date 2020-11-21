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
            float osLength, float osWidth, float osArea, float gLength, float gWidth, float gArea, float metLength, float metWidth, float metArea, string largestArea, string smallestArea, string crowdCapacity, string act3q4, string act3q5,string act3q6, string act3q7, string act3q8
            ,string act5table, int act5tablecount, string act5q1, string act5q2, string act5q3, string act5q4, string act5q5, string act6table1, int act6tablecount, string act6avgheight, string act6avgage, string act6q1, string act6q2, string act6q3, string act6q4, string act6q5, string act6q6, string act6q7, string act6q8, string act6q9
            , string act6q10, string act6q11, string act6q12, string act6table3, string act6table4, string act9table1, string act9table2, string act9table3, string act9table4, string act9table5, string act10table1, string act10q1, string act10q2, string act10table2, string act10table3, string act10q3
            , string act11q1, string act11table1, string act11q2, string act12table1, string act12q1, string act12table2, string act13q1, string act13table1, string act13table2,string act14graph1, string act14graph2, string act14graph3, string act14q1, string act14q2, string act14q3
            , string act14q4, string act14q5, string act14q6, string act14q7, string act14q8, string act14q9, string act14q10, string act14q11, string act15quad1, string act15table1, string act15quad2, string act15table2, string act15quad3
            , string act15graphpoints, string act15graphlines, string act15table4, string act15table5, string act15textarea, string act16table1, string act16table2, string act16table3, string act16table4, string act16table5, string act16table6,
            string act17table1, string act17table2, string act17table3, string act17table4, string act17table5, string act17table6, string act17table7, string act17q1, string act17q2, string act17q3, string act17q4, string act17q5, string act17q6, string act17q7)
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
                 osLength,osWidth,osArea,gLength,gWidth,gArea, metLength, metWidth, metArea,largestArea,smallestArea,crowdCapacity,act3q4,act3q5,act3q6,act3q7, act3q8, act5table, act5tablecount,  act5q1,  act5q2,  act5q3,  act5q4,  act5q5,
                  act6table1,  act6tablecount,  act6avgheight,  act6avgage,  act6q1,  act6q2,  act6q3,  act6q4,  act6q5,  act6q6,  act6q7,  act6q8,  act6q9,  act6q10,  act6q11,  act6q12, act6table3, act6table4,  act9table1,  act9table2,  act9table3,  act9table4,  act9table5,  act10table1,  act10q1,  act10q2,  act10table2,  act10table3,  act10q3
                  , act11q1, act11table1, act11q2,  act12table1,  act12q1,  act12table2,  act13q1,  act13table1,  act13table2,act14graph1,act14graph2,act14graph3,  act14q1,  act14q2,  act14q3,  act14q4,  act14q5,  act14q6,  act14q7,  act14q8,  act14q9,  act14q10,  act14q11,  act15quad1,  act15table1,  act15quad2,  act15table2,  act15quad3
            ,  act15graphpoints,  act15graphlines,act15table4,act15table5,act15textarea, act16table1,act16table2, act16table3, act16table4,act16table5,act16table6,  act17table1,  act17table2,  act17table3,  act17table4,  act17table5,  act17table6,  act17table7,  act17q1,  act17q2,  act17q3,  act17q4,  act17q5,  act17q6,  act17q7);
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
