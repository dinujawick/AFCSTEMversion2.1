using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public interface IPlayerRepository
    {
        Player getPlayer(int id);
        IEnumerable<Player> getAllPlayers();
        Player getPlayerByName(string name);
        Player HidePlayer(Player player, bool hide);
        Player updatePlayer(Player player, string Position, int Price, int Height, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
          int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches, string gender);
        Player createPlayer(int Number, string Name, string Gender, string Position, int Price, int Height, DateTime DateOfBirth, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
            int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches, bool Hidden);
        

        }     
}
