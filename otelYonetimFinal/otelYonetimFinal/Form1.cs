using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DAL;
using otelYonetimFinal.Formlar.Giris;

namespace otelYonetimFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.AnaSayfa.FrmAnaSayfa)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.AnaSayfa.FrmAnaSayfa fr = new Formlar.AnaSayfa.FrmAnaSayfa
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göste
        }

        private void BtnDurumTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();
        }

        private void BtnDepartmanTanimlamalari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDepartman fr = new Formlar.Tanımlamalar.FrmDepartman();
            fr.Show();
        }

        private void btnDepartmanTanimlari1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDepartman fr = new Formlar.Tanımlamalar.FrmDepartman();
            fr.Show();
        }

        private void btnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmGorev fr = new Formlar.Tanımlamalar.FrmGorev();
            fr.Show();
        }

        private void btnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            fr.Show();
        }

        private void btnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKur fr = new Formlar.Tanımlamalar.FrmKur();
            fr.Show();
        }

        private void btnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmOda fr = new Formlar.Tanımlamalar.FrmOda();
            fr.Show();
        }

        private void btnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmTelefon fr = new Formlar.Tanımlamalar.FrmTelefon();
            fr.Show();
        }

        private void btnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelKarti fr = new Formlar.Personel.FrmPersonelKarti();
            fr.Show();
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // FrmPersonelListesi formunun açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Personel.FrmPersonelListesi)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Personel.FrmPersonelListesi fr = new Formlar.Personel.FrmPersonelListesi
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void btnMusteriKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafirler.FrmMisafirKarti fr = new Formlar.Misafirler.FrmMisafirKarti();
            fr.Show();
        }

        private void btnMusteriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // FrmMisafirListesi formunun açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Misafirler.FrmMisafirListesi)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Misafirler.FrmMisafirListesi fr = new Formlar.Misafirler.FrmMisafirListesi
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRezervasyonKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyonlar.FrmRezervasyonKarti fr = new Formlar.Rezervasyonlar.FrmRezervasyonKarti();
            fr.Show();
        }

        private void btnTumRezervasyonListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // FrmTumRezervasyonListesi formunun açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Rezervasyonlar.FrmTumRezervasyonListesi)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Rezervasyonlar.FrmTumRezervasyonListesi fr = new Formlar.Rezervasyonlar.FrmTumRezervasyonListesi
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void btnAktifRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // FrmTumRezervasyonListesi formunun açık olup olmadığını kontrol et
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Rezervasyonlar.FrmAktifRezervasyonlar)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Rezervasyonlar.FrmAktifRezervasyonlar fr = new Formlar.Rezervasyonlar.FrmAktifRezervasyonlar
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void btnIptalEdilenRez_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Rezervasyonlar.FrmIptalEdilenRezervasyonlar)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Rezervasyonlar.FrmIptalEdilenRezervasyonlar fr = new Formlar.Rezervasyonlar.FrmIptalEdilenRezervasyonlar
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void btnGecmisRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Rezervasyonlar.FrmGecmisRezervasyonlar)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Rezervasyonlar.FrmGecmisRezervasyonlar fr = new Formlar.Rezervasyonlar.FrmGecmisRezervasyonlar
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göster
        }

        private void btnGelecekRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Rezervasyonlar.FrmGelecekRezervasyonlar)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Rezervasyonlar.FrmGelecekRezervasyonlar fr = new Formlar.Rezervasyonlar.FrmGelecekRezervasyonlar
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göste
        }

        private void btnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.Araclar.FrmKurlar)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.Araclar.FrmKurlar fr = new Formlar.Araclar.FrmKurlar
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göste
        }

        private void btnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnAnaMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is Formlar.AnaSayfa.FrmAnaSayfa)
                {
                    form.Close(); // Eğer form açıksa kapat
                    return; // İşlemi sonlandır
                }
            }

            // Eğer form açık değilse, yeni bir form oluştur ve göster
            Formlar.AnaSayfa.FrmAnaSayfa fr = new Formlar.AnaSayfa.FrmAnaSayfa
            {
                MdiParent = this, // Ana formu MDI Parent olarak ayarla
                Dock = DockStyle.Bottom, // Formu alt kısma sabitle
                Height = 407 // Formun yüksekliğini belirle
            };

            fr.Show(); // Formu göste
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Admin formunu göster
            FrmGirisEkrani adminForm = new FrmGirisEkrani();
            adminForm.Show();

            // Mevcut formu kapat
            this.Close();
        }

        private void btnTakvim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmTakvim fr = new Formlar.Araclar.FrmTakvim();
            fr.Show();
        }
    }
}
