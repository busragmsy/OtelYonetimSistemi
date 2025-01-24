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
    public partial class FrmGecmisRezervasyonlar : Form
    {
        private RezervasyonService _rezervasyonService;

        public FrmGecmisRezervasyonlar()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();
        }

        private void FrmGecmisRezervasyonlar_Load(object sender, EventArgs e)
        {
            LoadGecmisRezervasyonlar();
        }

        private void LoadGecmisRezervasyonlar()
        {
            try
            {
                var rezervasyonlar = _rezervasyonService.GetGecmisRezervasyonlar();
                dgvGecmisRez.DataSource = rezervasyonlar;

                // Sütun başlıklarını düzenle
                dgvGecmisRez.Columns["RezervasyonID"].Visible = false; // ID'yi gizle
                dgvGecmisRez.Columns["Misafir"].HeaderText = "Misafir";
                dgvGecmisRez.Columns["GirisTarih"].HeaderText = "Giriş Tarihi";
                dgvGecmisRez.Columns["CikisTarih"].HeaderText = "Çıkış Tarihi";
                dgvGecmisRez.Columns["Kisi"].HeaderText = "Kişi Sayısı";
                dgvGecmisRez.Columns["Oda"].HeaderText = "Oda No";
                dgvGecmisRez.Columns["RezervasyonAdSoyad"].HeaderText = "Rezervasyon Adı";
                dgvGecmisRez.Columns["Telefon"].HeaderText = "Telefon";
                dgvGecmisRez.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
