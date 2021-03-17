using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiModelBase.Models;

namespace WebApiModelBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        static List<Player> listPlayer = new List<Player> {
            new Player{PId=1,PName="archer",PDOB=DateTime.Parse("12/12/2012"),PTeam="england" },
            new Player{PId=2,PName="Raj",PDOB=DateTime.Parse("13/02/2012"),PTeam="India" },
            new Player{PId=3,PName="wood",PDOB=DateTime.Parse("20/12/191"),PTeam="england" }


        };
        [HttpGet]
        public IEnumerable<Player> GetPlayers()
        {
            return listPlayer;
        }
        [HttpGet("{id}")]

        public ActionResult Get(int id)
        {
            var result = listPlayer.SingleOrDefault(p => p.PId == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = listPlayer.SingleOrDefault(p => p.PId == id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                listPlayer.RemoveAll(p => p.PId == id);
                return Ok(result);
            }

        }
        [HttpPost]
        public ActionResult Insert([FromBody] Player p)
        {
            try
            {
                listPlayer.Add(p);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
        }

    }
}

