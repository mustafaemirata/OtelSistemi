using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelSistemi.Entitiy;

namespace OtelSistemi.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        public FrmPersonelListesi()
        {
            InitializeComponent();
        }
        DbOtelEntities1 db = new DbOtelEntities1();

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource= (from x in db.Tbl_Personel
                                      select new
                                      {
                                          x.PersonelID,
                                          x.AdSoyad,
                                          x.TC,
                                          x.Telefon,
                                          x.Adres,
                                          x.Tbl_Departman.DepartmanAd,
                                          x.Tbl_Gorev.GorevAd,
                                          x.Tbl_Durum.DurumAd
                                      }).ToList();

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmPersonelKart fr = new FrmPersonelKart();
            fr.id=int.Parse(gridView1.GetFocusedRowCellValue("PersonelID").ToString());
            fr.Show();
        }
    }
}
