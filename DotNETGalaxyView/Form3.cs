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
    public partial class Form3 : Form
    {
        BuildingContext _context;

        public Form3()
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
            _context.Buildings.Load();
            // Bind the categoryBindingSource.DataSource to
            // all the Unchanged, Modified and Added Category objects that
            // are currently tracked by the DbContext.
            // Note that we need to call ToBindingList() on the
            // ObservableCollection<TEntity> returned by
            // the DbSet.Local property to get the BindingList<T>
            // in order to facilitate two-way binding in WinForms.
            this.buildingsBindingSource.DataSource = _context.Buildings.Local.ToBindingList();
        }

        private void btn_Upgrade_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void buildingsDataGridView_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //e.Row.Cells["Name"].Value = "Factory";
            //e.Row.Cells["Cost"].Value = 10;
            //e.Row.Cells["Level"].Value = 1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            planetNameTextBox.Text = Form1.sendingForm3Name;
            planetResourcesTextBox.Text = Form1.sendingForm3Resources.ToString();
        }
    }
}
