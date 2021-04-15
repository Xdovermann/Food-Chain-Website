using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FoodChainWebApp.Contracts
{
   
        [JsonObject, Serializable]
        public class Player
        {
            public int Id { get; set; }

            public string Username { get; set; }

            public float Score { get; set; }
        }
    
}
