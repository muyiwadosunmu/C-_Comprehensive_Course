using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; } = string.Empty;
        public int SpotNumber { get; set; }
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty; //0 = empty, 1 = placed, 2 = miss, 2 = hit 4 = sunk


    }
}