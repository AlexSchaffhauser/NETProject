using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETGalaxyView
{
    public class Planet
    {

        private readonly ObservableListSource<Building> _buildings = 
            new ObservableListSource<Building>();

        public int PlanetId { get; set; }

        public string PlanetName { get; set; }

        public int PlanetResources { get; set; }

        public virtual ObservableListSource<Building> Buildings { get { return _buildings; } }

    }
}
