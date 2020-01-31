using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DotNETGalaxyView
{
    public partial class Form2 : Form
    {
        public string incomingForm2Name;
        BuildingContext _context;

        public Form2()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new BuildingContext();
            // Call the Load method to get the data for the given DbSet
            // from the database.
            // The data is materialized as entities. The entities are managed by
            // the DbContext instance.
            _context.Planets.Load();
            // Bind the categoryBindingSource.DataSource to
            // all the Unchanged, Modified and Added Category objects that
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.
            this.planetBindingSource.DataSource = _context.Planets.Local.ToBindingList();
        }

        private void btnAddPlanet_Click(object sender, EventArgs e)
        {
            //add new Planet
            var newPlanet = new Planet()
            {
                PlanetName = tbxPlanetName.Text
            };
            _context.Planets.Add(newPlanet);
            //Add Factory to Planet
            var factory = new Building()
            {
                BuildingName = "Factory",
                BuildingCost = 10,
                BuildingLevel = 1,
                BuildingId = newPlanet.PlanetId
            };
            _context.Buildings.Add(factory);
            //Add Storage to Planet
            var storage = new Building()
            {
                BuildingName = "Storage",
                BuildingCost = 10,
                BuildingLevel = 1,
                BuildingId = newPlanet.PlanetId
            };
            _context.Buildings.Add(storage);
            _context.SaveChanges();
            this.Close();
        }

    }
}
