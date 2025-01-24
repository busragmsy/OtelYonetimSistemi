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
    public partial class FrmGelecekRezervasyonlar : Form
    {
        private RezervasyonService _rezervasyonService;

        public FrmGelecekRezervasyonlar()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();

            // Form özellikleri ayarlanıyor
            this.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            this.TopLevel = false; // Formun MDI Parent içinde açılmasını sağla
            this.Dock = DockStyle.Fill; // Formu tüm alanı kaplayacak şekilde sabitle
        }

        private void FrmGelecekRezervasyonlar_Load(object sender, EventArgs e)
        {
            LoadGelecekRezervasyonlar();
        }

        private void LoadGelecekRezervasyonlar()
        {
            try
            {
                // Gelecek rezervasyonları getir ve DataGridView'e ata
                var rezervasyonList = _rezervasyonService.GetGelecekRezervasyonlar();
                dgvGelecekRez.DataSource = rezervasyonList;

                // Görünmesini istemediğiniz sütunları gizleyin (örneğin ID sütunları)
                if (dgvGelecekRez.Columns["RezervasyonID"] != null)
                    dgvGelecekRez.Columns["RezervasyonID"].Visible = false;

                // Sütun başlıklarını düzenleyin
                dgvGelecekRez.Columns["Misafir"].HeaderText = "Misafir";
                dgvGelecekRez.Columns["GirisTarih"].HeaderText = "Giriş Tarihi";
                dgvGelecekRez.Columns["CikisTarih"].HeaderText = "Çıkış Tarihi";
                dgvGelecekRez.Columns["Kisi"].HeaderText = "Kişi Sayısı";
                dgvGelecekRez.Columns["Oda"].HeaderText = "Oda Numarası";
                dgvGelecekRez.Columns["RezervasyonAdSoyad"].HeaderText = "Rezervasyon Ad Soyad";
                dgvGelecekRez.Columns["Telefon"].HeaderText = "Telefon";
                dgvGelecekRez.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj kutusu ile bilgi ver
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
