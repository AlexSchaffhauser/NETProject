using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETGalaxyView
{
    public class Building
    {

        public int BuildingId { get; set; }

        public string BuildingName { get; set; }

        public int BuildingCost { get; set; }

        public int BuildingLevel { get; set; }

        public int PlanetId { get; set; }

        public virtual Planet Planet { get; set; }

    }
}
