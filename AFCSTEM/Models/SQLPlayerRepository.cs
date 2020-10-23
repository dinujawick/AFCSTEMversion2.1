using AFCSTEM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class SQLPlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext context;
       


        public SQLPlayerRepository(ApplicationDbContext context)
        {
            
            this.context = context;
        }

        public Player createPlayer(int Number, string Name, string Gender, string Position, int Price, int Height, DateTime DateOfBirth, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
            int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches,bool Hidden)
        {
            Player newplayer = new Player();
            newplayer.Number = Number;
            newplayer.Name = Name;
        
        

            return null;
        }

        public Player getPlayerByName(string name)
        {

            int count = 2;
            while(getPlayer(count) != null)
            {
                if(getPlayer(count).Name == name)
                {
                    return getPlayer(count);
                }
                count++;
            }

            return null;


        
            
            
        }

        public Player HidePlayer(Player player,bool hide)
        {

            player.Hidden = hide;
           
            var playerUpdate = context.Players.Attach(player);
            playerUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return player;
        }


        public Player getPlayer(int id)
        {
            return context.Players.Find(id);
        }

        public IEnumerable<Player> getAllPlayers()
        {
            return context.Players;

        }
    }

}
