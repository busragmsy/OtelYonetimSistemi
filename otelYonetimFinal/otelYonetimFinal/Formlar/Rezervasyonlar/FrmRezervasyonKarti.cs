using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    public partial class FrmRezervasyonKarti : Form
    {
        private RezervasyonService _rezervasyonService;
        public int RezervasyonID { get; set; }


        public FrmRezervasyonKarti()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();
        }

        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            LoadMisafirList();
            LoadOdaList();
            LoadDurum();
        }

        private void LoadMisafirList()
        {
            try
            {
                var misafirList = _rezervasyonService.GetMisafirList();
                cmbAdSoyad.DataSource = new BindingSource(misafirList, null);
                cmbAdSoyad.DisplayMember = "Value"; // AdSoyad'ı göster
                cmbAdSoyad.ValueMember = "Key"; // MisafirID değerini tut
                cmbAdSoyad.SelectedIndex = -1; // Varsayılan olarak boş bırak
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Misafir listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOdaList()
        {
            try
            {
                var odaList = _rezervasyonService.GetOdaList();
                cmbOda.DataSource = new BindingSource(odaList, null);
                cmbOda.DisplayMember = "Value"; // OdaNo'yu göster
                cmbOda.ValueMember = "Key"; // OdaID değerini tut
                cmbOda.SelectedIndex = -1; // Varsayılan olarak boş bırak
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda listesi yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDurum()
        {
            var durumList = _rezervasyonService.GetAllDurum();
            cmbDurum.DataSource = new BindingSource(durumList, null);
            cmbDurum.DisplayMember = "Value";
            cmbDurum.ValueMember = "Key";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Gerekli alanların kontrolü
                if (cmbAdSoyad.SelectedIndex == -1 || cmbOda.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtKisiAd.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Rezervasyon nesnesini doldurma
                var rezervasyon = new Rezervasyon
                {
                    MisafirID = Convert.ToInt32(cmbAdSoyad.SelectedValue), // Misafir ID
                    OdaID = Convert.ToInt32(cmbOda.SelectedValue),         // Oda ID
                    GirisTarih = dtpGirisTarihi.Value.Date,                // Giriş Tarihi
                    CikisTarih = dtpCikisTarihi.Value.Date,                // Çıkış Tarihi
                    Kisi = nudKisiSayisi.Value.ToString(),                 // Kişi Sayısı
                    RezervasyonAdSoyad = txtKisiAd.Text,                   // Rezervasyon Ad Soyad
                    Telefon = txtTelefon.Text,                            // Telefon
                    Aciklama = txtAciklama.Text,                          // Açıklama
                    Durum = 1 // Varsayılan olarak aktif
                };

                // Rezervasyon kaydı ekleme
                _rezervasyonService.AddRezervasyon(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbAdSoyad.SelectedIndex = -1; // Misafir seçim kutusu temizleniyor
            cmbOda.SelectedIndex = -1;    // Oda seçim kutusu temizleniyor
            dtpGirisTarihi.Value = DateTime.Now; // Giriş tarihi bugüne ayarlanıyor
            dtpCikisTarihi.Value = DateTime.Now; // Çıkış tarihi bugüne ayarlanıyor
            nudKisiSayisi.Value = 1;             // Varsayılan kişi sayısı
            txtKisiAd.Clear();                   // Rezervasyon Ad Soyad temizleniyor
            txtTelefon.Clear();                  // Telefon temizleniyor
            txtAciklama.Clear();                 // Açıklama temizleniyor
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdSoyad.SelectedIndex == -1 || cmbOda.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var rezervasyon = new Rezervasyon
                {
                    RezervasyonID = this.RezervasyonID, // Güncellenecek kayıt
                    MisafirID = Convert.ToInt32(cmbAdSoyad.SelectedValue),
                    OdaID = Convert.ToInt32(cmbOda.SelectedValue),
                    //GirisTarih = dtpGirisTarih.Value.Date,
                    //CikisTarih = dtpCikisTarih.Value.Date,
                    Kisi = nudKisiSayisi.Value.ToString(),
                    Telefon = txtTelefon.Text,
                    Aciklama = txtAciklama.Text,
                    Durum = Convert.ToInt32(cmbDurum.SelectedValue)
                };

                _rezervasyonService.UpdateRezervasyon(rezervasyon);
                MessageBox.Show("Rezervasyon başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon güncellenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
