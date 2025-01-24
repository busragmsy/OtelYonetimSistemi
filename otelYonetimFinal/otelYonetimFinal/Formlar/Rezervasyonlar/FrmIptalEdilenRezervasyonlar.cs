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
    public partial class FrmIptalEdilenRezervasyonlar : Form
    {
        private RezervasyonService _rezervasyonService;

        public FrmIptalEdilenRezervasyonlar()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();
        }

        private void FrmIptalEdilenRezervasyonlar_Load(object sender, EventArgs e)
        {
            LoadIptalEdilenRezervasyonlar();
        }

        private void LoadIptalEdilenRezervasyonlar()
        {
            try
            {
                var iptalRezervasyonlar = _rezervasyonService.GetIptalEdilenRezervasyonlar();
                dgvIptalRez.DataSource = iptalRezervasyonlar;

                // Sütun başlıklarını düzenle
                dgvIptalRez.Columns["RezervasyonID"].Visible = false; // ID'yi gizle
                dgvIptalRez.Columns["Misafir"].HeaderText = "Misafir";
                dgvIptalRez.Columns["GirisTarih"].HeaderText = "Giriş Tarihi";
                dgvIptalRez.Columns["CikisTarih"].HeaderText = "Çıkış Tarihi";
                dgvIptalRez.Columns["Kisi"].HeaderText = "Kişi Sayısı";
                dgvIptalRez.Columns["Oda"].HeaderText = "Oda No";
                dgvIptalRez.Columns["RezervasyonAdSoyad"].HeaderText = "Rezervasyon Adı";
                dgvIptalRez.Columns["Telefon"].HeaderText = "Telefon";
                dgvIptalRez.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
