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
            Player player = new Player();
            player.Number = Number;
            player.Name = Name;
            player.Gender = Gender;
            player.Position = Position;
            player.DateOfBirth = DateOfBirth;
            player.Hidden = Hidden;
            player.Price = Price;
            player.Height = Height;
            player.Age = Age;
            player.KickAvg = KickAvg;
            player.KickTotal = KickTotal;
            player.HandballAvg = HandballAvg;
            player.HandballTotal = HandballTotal;
            player.DisposalAvg = DisposalAvg;
            player.DisposalTotal = DisposalTotal;
            player.MarksTotal = MarksTotal;
            player.MarksAvg = MarksAvg;
            player.HOAvg = HOAvg;
            player.HOTotal = HOTotal;
            player.ClearanceAvg = ClearanceAvg;
            player.ClearanceTotal = ClearanceTotal;
            player.CentreClearanceAvg = CentreClearanceAvg;
            player.CentreClearanceTotal = CentreClearanceTotal;
            player.TackleAvg = TackleAvg;
            player.TackleTotal = TackleTotal;
            player.GoalsAvg = GoalsAvg;
            player.GoalsTotal = GoalsTotal;
            player.BehindsAvg = BehindsAvg;
            player.BehindsTotal = BehindsTotal;
            player.Matches = Matches;


            context.Players.Add(player);
            context.SaveChanges();

            return player;
        }

        public Player updatePlayer(Player player, string Position, int Price, int Height, int Age, double KickAvg, int KickTotal, double HandballAvg, int HandballTotal, double DisposalAvg, int DisposalTotal, double MarksAvg, int MarksTotal, double HOAvg,
          int HOTotal, double ClearanceAvg, int ClearanceTotal, double CentreClearanceAvg, int CentreClearanceTotal, double TackleAvg, int TackleTotal, double GoalsAvg, int GoalsTotal, double BehindsAvg, int BehindsTotal, int Matches, string gender)
        {
            player.Gender = gender;
            player.Position = Position;
            player.Price = Price;
            player.Height = Height;
            player.Age = Age;
            player.KickAvg = KickAvg;
            player.KickTotal = KickTotal;
            player.HandballAvg = HandballAvg;
            player.HandballTotal = HandballTotal;
            player.DisposalAvg = DisposalAvg;
            player.DisposalTotal = DisposalTotal;
            player.MarksTotal = MarksTotal;
            player.MarksAvg = MarksAvg;
            player.HOAvg = HOAvg;
            player.HOTotal = HOTotal;
            player.ClearanceAvg = ClearanceAvg;
            player.ClearanceTotal = ClearanceTotal;
            player.CentreClearanceAvg = CentreClearanceAvg;
            player.CentreClearanceTotal = CentreClearanceTotal;
            player.TackleAvg = TackleAvg;
            player.TackleTotal = TackleTotal;
            player.GoalsAvg = GoalsAvg;
            player.GoalsTotal = GoalsTotal;
            player.BehindsAvg = BehindsAvg;
            player.BehindsTotal = BehindsTotal;
            player.Matches = Matches;


            var playerUpdate = context.Players.Attach(player);
            playerUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();



            return player;
        }

            public Player getPlayerByName(string name){

            int count = 2;
            while(count < 300)
            {

                if(getPlayer(count) != null)
                {
                    if (getPlayer(count).Name == name)
                    {
                        return getPlayer(count);
                    }
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
