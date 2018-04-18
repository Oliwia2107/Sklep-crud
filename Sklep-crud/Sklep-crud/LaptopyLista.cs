using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep_crud
{
    public partial class LaptopyLista : Form
    {
        SKLEPEntities db;

        public LaptopyLista(SKLEPEntities sklepEntities)
        {
            db = sklepEntities;
            InitializeComponent();
        }

        private void LaptopyLista_Load(object sender, EventArgs e)
        {
            this.gridLaptopy.DataSource = db.Laptop.ToList();
        }

        private void gridLaptopy_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Laptop selectedLaptop = (Laptop)((DataGridView)sender).CurrentRow.DataBoundItem;
            LaptopDetails laptopDetails = new LaptopDetails(selectedLaptop, db);
            laptopDetails.Show();
        }
    }
}
