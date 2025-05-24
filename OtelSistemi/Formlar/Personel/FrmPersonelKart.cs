using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using OtelSistemi.Entitiy;
using OtelSistemi.Repositories;

namespace OtelSistemi.Formlar.Personel
{
    public partial class FrmPersonelKart : Form
    {
        public FrmPersonelKart()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        DbOtelEntities1 db = new DbOtelEntities1();
        Repository<Tbl_Personel> repo = new Repository<Tbl_Personel>();
        public int id;

        private void FrmPersonelKart_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();

            if(id!=0)
            {
                //id değerini bulmak için
                var personel = repo.Find(x => x.PersonelID == id);
                txtAd.Text = personel.AdSoyad;
                txtTc.Text = personel.TC;
                adresMemo.Text = personel.Adres;
                txtTelefon.Text = personel.Telefon;
                girisTarih.Text = personel.IseGirisTarih.ToString();
                cikisTarih.Text = personel.IstenCikisTarih.ToString();
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;
                txtMail.Text = personel.Mail;
                txtAciklama.Text = personel.Aciklama;
                kimlikOn.LoadAsync(personel.KimlikOn);
                kimlikArka.LoadAsync(personel.KimlikArka);
                txtSifre.Text = personel.Sifre;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;
            }
          
            





            lookUpEditDepartman.Properties.DataSource = (from x in db.Tbl_Departman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();
            lookUpEditGorev.Properties.DataSource = (from x in db.Tbl_Gorev
                                                     select new
                                                     {
                                                         x.GorevID,
                                                         x.GorevAd
                                                     }).ToList();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Repository<Tbl_Personel> repo = new Repository<Tbl_Personel>();
            Tbl_Personel t=new Tbl_Personel();
            t.AdSoyad = txtAd.Text;
            t.TC = txtTc.Text;
            t.Adres = adresMemo.Text;
            t.Telefon = txtTelefon.Text;
            t.IseGirisTarih = DateTime.Parse(girisTarih.Text);
            t.IstenCikisTarih = DateTime.Parse(cikisTarih.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Mail = txtMail.Text;
            t.Aciklama = txtAciklama.Text;
            t.KimlikOn = kimlikOn.GetLoadedImageLocation();
            t.KimlikArka=kimlikArka.GetLoadedImageLocation();
            t.Sifre = txtSifre.Text;    
            t.Durum = 1;
            repo.Tadd(t);
            XtraMessageBox.Show("Personel Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var deger=repo.Find(x => x.PersonelID == id);
            deger.AdSoyad = txtAd.Text;
            deger.TC = txtTc.Text;
            deger.Adres = adresMemo.Text;
            deger.Telefon = txtTelefon.Text;
            deger.IseGirisTarih = DateTime.Parse(girisTarih.Text);
            deger.IstenCikisTarih = DateTime.Parse(cikisTarih.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Mail = txtMail.Text;
            deger.Aciklama = txtAciklama.Text;
            deger.KimlikOn = kimlikOn.GetLoadedImageLocation();
            deger.KimlikArka = kimlikArka.GetLoadedImageLocation();
            deger.Sifre = txtSifre.Text;
            deger.Durum = 1;

            repo.Tupdate(deger);
            XtraMessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
