using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.Bll.Manager;
using RentACar.Entity;

namespace RentACar.WinFormUI
{
    public partial class FormAracEkle : Form
    {
        private AracManager _aracManager;
        private MarkaManager _markaManager;
        private ModelManager _modelManager;
        public FormAracEkle()
        {
            InitializeComponent();
            _aracManager = new AracManager();
            _markaManager =new MarkaManager();
            _modelManager = new ModelManager();
          
        }

        private void FormAracEkle_Load(object sender, EventArgs e)
        {
            cmbMarka.DataSource= _markaManager
                .GetAll()
                .Select(i => i.MarkaAdi)
                .ToList();


            cmbModel.DataSource = _modelManager
                .GetAll()
                .Where(i=>i.Marka.MarkaAdi==cmbMarka.Text)
                .Select(i => i.ModelAdi)
                .ToList();

        }

        private void CmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.DataSource = _modelManager
                .GetAll()
                .Where(i => i.Marka.MarkaAdi == cmbMarka.Text)
                .Select(i => i.ModelAdi)
                .ToList();
        }
    }
}
