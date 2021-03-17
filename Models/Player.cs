using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiModelBase.Models
{
    public class Player
    {
        public int PId { get; set; }
        public string PName { get; set; }

        public DateTime PDOB { get; set; }
        public string PTeam { get; set; }

    }
}
