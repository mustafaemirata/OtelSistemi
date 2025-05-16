using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelSistemi.Entitiy;

namespace OtelSistemi.Formlar.Tanımlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }
        DbOtelEntities1 db = new DbOtelEntities1(); 
        private void FrmBirim_Load(object sender, EventArgs e)
        {

            db.Tbl_Birim.Load();
            bindingSource1.DataSource = db.Tbl_Birim.Local;
        }
    }
}
