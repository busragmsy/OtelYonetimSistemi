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
    public partial class FrmAktifRezervasyonlar : Form
    {
        private RezervasyonService _rezervasyonService;

        public FrmAktifRezervasyonlar()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();
        }

        private void FrmAktifRezervasyonlar_Load(object sender, EventArgs e)
        {
            LoadAktifRezervasyonlar();
        }

        private void LoadAktifRezervasyonlar()
        {
            try
            {
                var aktifRezervasyonlar = _rezervasyonService.GetAktifRezervasyonlar();
                dgvAktifRez.DataSource = aktifRezervasyonlar;

                // Sütun başlıklarını düzenle
                dgvAktifRez.Columns["RezervasyonID"].Visible = false; // ID'yi gizle
                dgvAktifRez.Columns["Misafir"].HeaderText = "Misafir";
                dgvAktifRez.Columns["GirisTarih"].HeaderText = "Giriş Tarihi";
                dgvAktifRez.Columns["CikisTarih"].HeaderText = "Çıkış Tarihi";
                dgvAktifRez.Columns["Kisi"].HeaderText = "Kişi Sayısı";
                dgvAktifRez.Columns["Oda"].HeaderText = "Oda No";
                dgvAktifRez.Columns["RezervasyonAdSoyad"].HeaderText = "Rezervasyon Adı";
                dgvAktifRez.Columns["Telefon"].HeaderText = "Telefon";
                dgvAktifRez.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAktifRez_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
