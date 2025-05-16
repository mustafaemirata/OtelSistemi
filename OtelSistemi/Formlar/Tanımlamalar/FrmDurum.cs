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
using DevExpress.XtraEditors;
using OtelSistemi.Entitiy;

namespace OtelSistemi.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        public FrmDurum()
        {
            InitializeComponent();
        }
        DbOtelEntities1 db = new DbOtelEntities1(); 
        private void FrmDurum_Load(object sender, EventArgs e)
        {
            //// Veritabanından veri çekmek için kullanılan LINQ sorgusu
            //var durumlar = (from x in db.Tbl_Durum
            //                select new
            //                {
            //                    x.DurumID,
            //                    x.DurumAd
            //                });
            //// Veri listeleme için kullanılan komut
            //gridControl1.DataSource=durumlar.ToList();

            // KISA YOL (Run Designer'da gerekli yapılandırmayı yaptığımız için.)

            db.Tbl_Durum.Load(); 
            bindingSource1.DataSource = db.Tbl_Durum.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Grid view üzerine yeni eklenen satırı veritabanına gönderme işlemi. Aynı şekilde güncelleme yapılırken de aynı komut.

            try
            {
                db.SaveChanges();
            }
            catch (Exception )
            {
                XtraMessageBox.Show("Lütfen değerleri kontrol ederek tekrar deneyin!","Uyarı!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
