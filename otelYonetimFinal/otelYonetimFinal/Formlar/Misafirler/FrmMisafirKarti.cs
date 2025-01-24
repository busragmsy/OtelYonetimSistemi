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

namespace otelYonetimFinal.Formlar.Misafirler
{
    public partial class FrmMisafirKarti : Form
    {
        private MisafirService _misafirService;
        public int? MisafirID { get; set; } // MisafirID özelliği

        public FrmMisafirKarti()
        {
            InitializeComponent();
            _misafirService = new MisafirService(); // Servis sınıfı başlatılıyor
        }

        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            if (MisafirID.HasValue)
            {
                // Güncelleme işlemi için MisafirID ile veriyi getir
                var misafir = _misafirService.GetMisafirByID(MisafirID.Value);
                if (misafir != null)
                {
                    // Verileri forma doldur
                    txtAdSoyad.Text = misafir.AdSoyad;
                    txtTC.Text = misafir.TC;
                    txtMail.Text = misafir.Mail;
                    txtTelefon.Text = misafir.Telefon;
                    txtAdres.Text = misafir.Adres;
                    txtAciklama.Text = misafir.Aciklama;
                    txtUlke.Text = misafir.Ulke;
                    txtSehir.Text = misafir.Sehir;
                    txtIlce.Text = misafir.Ilce;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var misafir = new Misafir
                {
                    AdSoyad = txtAdSoyad.Text.Trim(),
                    TC = txtTC.Text.Trim(),
                    Mail = txtMail.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adres = txtAdres.Text.Trim(),
                    Aciklama = txtAciklama.Text.Trim(),
                    Ulke = txtUlke.Text.Trim(),
                    Sehir = txtSehir.Text.Trim(),
                    Ilce = txtIlce.Text.Trim(),
                    Durum = 1 // Durum her zaman 1 olacak
                };

                _misafirService.AddMisafir(misafir);

                MessageBox.Show("Misafir başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm(); // Formu temizler
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtAdSoyad.Clear();
            txtTC.Clear();
            txtAdres.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAciklama.Clear();
            txtUlke.Clear();
            txtSehir.Clear();
            txtIlce.Clear();
        }


        private void btnVazgec_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan onay alın
            var result = MessageBox.Show(
                "Değişiklikler iptal edilecek. Form kapatılsın mı?",
                "Onay",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            // Kullanıcı "Yes" seçerse
            if (result == DialogResult.Yes)
            {
                // Formdaki bilgileri temizle
                ClearForm();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Değişiklikler iptal edildi. Form kapanıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu kapat
                this.Close();
            }
            // Kullanıcı "No" seçerse
            else if (result == DialogResult.No)
            {
                // Formdaki bilgileri temizle
                ClearForm();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Değişiklikler iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Kullanıcı "Cancel" seçerse hiçbir işlem yapılmaz
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (MisafirID.HasValue)
                {
                    var misafir = new Misafir
                    {
                        MisafirID = MisafirID.Value,
                        AdSoyad = txtAdSoyad.Text.Trim(),
                        TC = txtTC.Text.Trim(),
                        Mail = txtMail.Text.Trim(),
                        Telefon = txtTelefon.Text.Trim(),
                        Adres = txtAdres.Text.Trim(),
                        Aciklama = txtAciklama.Text.Trim(),
                        Ulke = txtUlke.Text.Trim(),
                        Sehir = txtSehir.Text.Trim(),
                        Ilce = txtIlce.Text.Trim()
                    };

                    _misafirService.UpdateMisafir(misafir);
                    MessageBox.Show("Misafir başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Formu kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
