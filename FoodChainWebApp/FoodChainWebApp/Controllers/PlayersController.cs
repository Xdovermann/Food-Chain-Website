using FoodChainWebApp.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace FoodChainWebApp.Controllers
{
    // link is : https://localhost:44386/api/players
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // test waardes dit doe je normaal via de database
        // hier leg je je database connectie
        private static List<Player> Players = new List<Player>()
        {
            new Player
            {
                Id = 1,
                Username = "TestPlayer_1",
                Score = 1000,

            },
              new Player
            {
                Id = 2,
                Username = "TestPlayer_2",
                Score = 500,

            },
                new Player
            {
                Id = 3,
                Username = "TestPlayer_3",
                Score = 250,

            },
        };


        // pakt alle spelers
        [HttpGet]
        public JsonResult Get()
        {

            return new JsonResult(Players);
        }

        // GET api/players/5(een id)
        // pakt een player met de meegegeven id
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            Player player = Players.Single(p => p.Id == id);
            return new JsonResult(player);
        }

        // create functie voor een nieuwe speler
        //POST api/players
        [HttpPost]
        public JsonResult Post([FromBody] Player newPlayer)
        {
            Players.Add(newPlayer); // hier zal je add database callen
            return new JsonResult(Players);
        }

        // update functie om een speler zijn score up te daten
        //PUT api/players/5(id)
        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody] float newscore)
        {
            Player player = Players.Single(p => p.Id == id);
            player.Score = newscore;
            return new JsonResult(player);
        }

        // DELETE api/players/5(id)
        // deletes de meegegeven player 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Player player = Players.Single(p => p.Id == id);
            Players.Remove(player);
        }
    }
}
