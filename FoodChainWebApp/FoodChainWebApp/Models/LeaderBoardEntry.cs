using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodChainWebApp.Models
{
    public class LeaderBoardEntry
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public int Score { get; set; }

        public LeaderBoardEntry()
        {

        }
    }
}
