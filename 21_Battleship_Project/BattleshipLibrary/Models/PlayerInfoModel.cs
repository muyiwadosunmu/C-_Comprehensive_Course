using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipLibrary.Models
{
    public class PlayerInfoModel
    {
        public string? UsersName { get; set; }
        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();

        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
        public object Shotrid { get; set; }
    }
}