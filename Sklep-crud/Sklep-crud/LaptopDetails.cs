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
    public partial class LaptopDetails : Form
    {
        Laptop laptop;
        SKLEPEntities db;
        public LaptopDetails(Laptop laptop, SKLEPEntities db)
        {
            this.db = db;
            this.laptop = laptop;
            InitializeComponent();
        }

        private void LaptopDetails_Load(object sender, EventArgs e)
        {
            this.txtProcesor.Text = laptop.procesor.ToString();
            this.txtRam.Text = laptop.ram.ToString();
            this.txtHDD.Text = laptop.hdd.ToString();
            this.txtEkran.Text = laptop.ekran.ToString();
            this.txtCena.Text = laptop.cena.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            laptop.procesor = int.Parse(this.txtProcesor.Text);
            laptop.ram = int.Parse(this.txtRam.Text);
            laptop.hdd = int.Parse(this.txtHDD.Text);
            laptop.ekran = int.Parse(this.txtEkran.Text);
            laptop.cena = decimal.Parse(this.txtCena.Text);
            db.SaveChanges();
        }
    }
}
