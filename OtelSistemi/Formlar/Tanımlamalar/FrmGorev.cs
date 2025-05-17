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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        DbOtelEntities1 db = new DbOtelEntities1();

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.Tbl_Gorev.Load();
            bindingSource1.DataSource = db.Tbl_Gorev.Local;


            repositoryItemLookUpEditDepartman.DataSource = (from x in db.Tbl_Departman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();







            repositoryItemLookUpEdit1Durum.DataSource = (from x in db.Tbl_Durum
                                                         select new
                                                         {
                                                             x.DurumID,
                                                             x.DurumAd
                                                         }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Bilgiler kaydedilirken hata oluştu.");
            }
        }
    }
}
