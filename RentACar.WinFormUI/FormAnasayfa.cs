using RentACar.Bll;
using RentACar.Dal.Concrete;
using RentACar.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.WinFormUI
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }
        AracController arac = new AracController();
        private void btnKirala_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RentContext context = new RentContext();
            IEnumerable<Arac> araclar = context.Araclar.ToList();
            foreach (var gelen in araclar)
            {
                comboBox1.Items.Add(gelen.Model+"-Km:"+gelen.Kilometre);
            }
            
        }
    }
}
