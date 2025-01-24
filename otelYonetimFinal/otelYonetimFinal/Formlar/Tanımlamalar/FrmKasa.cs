using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.SERVICE;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        private readonly KasaService _kasaService = new KasaService();

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            // Durumları ComboBox'a yükle
            cmbDurum.DataSource = _kasaService.GetDurumlar(); // Durum verilerini al
            cmbDurum.DisplayMember = "DurumAd"; // Kullanıcıya gösterilecek metin
            cmbDurum.ValueMember = "DurumID";   // Gönderilecek ID

            // Durum verilerini al ve ComboBox'a bağla
            cmbDurum.DataSource = _kasaService.GetDurumlar();
            cmbDurum.DisplayMember = "DurumAd"; // Kullanıcıya gösterilecek metin
            cmbDurum.ValueMember = "DurumID";   // Veritabanına gönderilecek ID

            // Kasaları yükle
            LoadKasalar();
        }

        private void LoadKasalar()
        {
            // Kasa verilerini al
            var kasalar = _kasaService.GetAllKasalar();

            // DataGridView'e veriyi bağla
            dataGridViewKasa.DataSource = null; // Önceki veriyi temizle
            dataGridViewKasa.DataSource = kasalar;

            // İstemediğiniz sütunları gizleyin (KasaID ve DurumID gibi)
            dataGridViewKasa.Columns["KasaID"].Visible = false; // KasaID sütununu gizle
            dataGridViewKasa.Columns["DurumID"].Visible = false; // DurumID sütununu gizle

            // İstemediğiniz sütunları gizleyin (KasaID gibi)
            dataGridViewKasa.Columns["KasaID"].Visible = false;

            // Sütun başlıklarını düzenleyin
            dataGridViewKasa.Columns["KasaAdi"].HeaderText = "Kasa Adı";
            dataGridViewKasa.Columns["Bakiye"].HeaderText = "Bakiye";
            dataGridViewKasa.Columns["Giren"].HeaderText = "Giren";
            dataGridViewKasa.Columns["Cikan"].HeaderText = "Çıkan";
            dataGridViewKasa.Columns["Durum"].HeaderText = "Durum";
        }

        private void txtKasaAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtKasaAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                // Arama metni boşsa tüm kasaları yükle
                LoadKasalar();
            }
            else
            {
                // Arama metnine göre filtreleme
                var filtrelenmisKasalar = _kasaService.GetAllKasalar()
                    .Where(k => k.KasaAdi.ToLower().Contains(aramaMetni) ||
                                k.Durum.ToLower().Contains(aramaMetni))
                    .ToList();

                // Filtrelenmiş verileri DataGridView'e yükle
                dataGridViewKasa.DataSource = null;
                dataGridViewKasa.DataSource = filtrelenmisKasalar;
            }
        }

        private void btnKasaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan verileri alın
                string kasaAdi = txtKasaAd.Text.Trim();
                decimal bakiye = string.IsNullOrWhiteSpace(txtBakiye.Text) ? 0 : Convert.ToDecimal(txtBakiye.Text);
                decimal giren = string.IsNullOrWhiteSpace(txtGiren.Text) ? 0 : Convert.ToDecimal(txtGiren.Text);
                decimal cikan = string.IsNullOrWhiteSpace(txtCikan.Text) ? 0 : Convert.ToDecimal(txtCikan.Text);
                int durumId = Convert.ToInt32(cmbDurum.SelectedValue);

                // Eğer Kasa Adı boşsa uyarı göster
                if (string.IsNullOrWhiteSpace(kasaAdi))
                {
                    MessageBox.Show("Kasa adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni kasa nesnesi oluştur
                Kasa yeniKasa = new Kasa
                {
                    KasaAdi = kasaAdi,
                    Bakiye = bakiye,
                    Giren = giren,
                    Cikan = cikan,
                    DurumID = durumId
                };

                // Servis üzerinden ekleme işlemini yap
                _kasaService.AddKasa(yeniKasa);

                // DataGridView'i yenile
                LoadKasalar();

                // Kullanıcıya mesaj göster
                MessageBox.Show("Kasa başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Giriş alanlarını temizle
                txtKasaAd.Clear();
                txtBakiye.Clear();
                txtGiren.Clear();
                txtCikan.Clear();
                cmbDurum.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKasaAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtKasaAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                // Arama metni boşsa tüm kasaları yükle
                LoadKasalar();
            }
            else
            {
                // Arama metnine göre filtreleme
                var filtrelenmisKasalar = _kasaService.GetAllKasalar()
                    .Where(k => k.KasaAdi.ToLower().Contains(aramaMetni) ||
                                k.Durum.ToLower().Contains(aramaMetni))
                    .ToList();

                // Filtrelenmiş verileri DataGridView'e yükle
                dataGridViewKasa.DataSource = null;
                dataGridViewKasa.DataSource = filtrelenmisKasalar;
            }
        }

        private void txtKasaAra_Enter(object sender, EventArgs e)
        {
            if (txtKasaAra.Text == "Ara...")
            {
                txtKasaAra.Text = "";
                txtKasaAra.ForeColor = Color.Black;
            }
        }

        private void txtKasaAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKasaAra.Text))
            {
                txtKasaAra.Text = "Ara...";
                txtKasaAra.ForeColor = Color.Gray;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırın ID'sini al
                if (dataGridViewKasa.SelectedRows.Count > 0)
                {
                    int selectedKasaId = Convert.ToInt32(dataGridViewKasa.SelectedRows[0].Cells["KasaID"].Value);

                    // Kullanıcıya onay sorusu sor
                    DialogResult dialogResult = MessageBox.Show(
                        "Bu kasayı silmek istediğinize emin misiniz?",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Kasayı veritabanından sil
                        _kasaService.DeleteKasa(selectedKasaId);

                        // Kullanıcıya bilgi ver
                        MessageBox.Show("Kasa başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        LoadKasalar();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kasayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırın ID'sini al
                if (dataGridViewKasa.SelectedRows.Count > 0)
                {
                    int selectedKasaId = Convert.ToInt32(dataGridViewKasa.SelectedRows[0].Cells["KasaID"].Value);

                    // Seçilen satırdaki mevcut verileri al
                    string mevcutKasaAdi = dataGridViewKasa.SelectedRows[0].Cells["KasaAdi"].Value.ToString();
                    decimal mevcutBakiye = Convert.ToDecimal(dataGridViewKasa.SelectedRows[0].Cells["Bakiye"].Value);
                    decimal mevcutGiren = Convert.ToDecimal(dataGridViewKasa.SelectedRows[0].Cells["Giren"].Value);
                    decimal mevcutCikan = Convert.ToDecimal(dataGridViewKasa.SelectedRows[0].Cells["Cikan"].Value);
                    string mevcutDurum = dataGridViewKasa.SelectedRows[0].Cells["Durum"].Value.ToString();

                    // Güncelleme için kullanıcıdan yeni veriler iste
                    string yeniKasaAdi = Interaction.InputBox("Yeni Kasa Adını Girin:", "Kasa Adı Güncelle", mevcutKasaAdi);
                    string yeniBakiye = Interaction.InputBox("Yeni Bakiyeyi Girin:", "Bakiye Güncelle", mevcutBakiye.ToString());
                    string yeniGiren = Interaction.InputBox("Yeni Giren Miktarı Girin:", "Giren Güncelle", mevcutGiren.ToString());
                    string yeniCikan = Interaction.InputBox("Yeni Çıkan Miktarı Girin:", "Çıkan Güncelle", mevcutCikan.ToString());
                    string yeniDurum = Interaction.InputBox("Yeni Durumu Girin (Aktif/Pasif):", "Durum Güncelle", mevcutDurum);

                    // Eğer kullanıcı boş bırakırsa mevcut değerleri koru
                    yeniKasaAdi = string.IsNullOrWhiteSpace(yeniKasaAdi) ? mevcutKasaAdi : yeniKasaAdi;
                    decimal yeniBakiyeValue = string.IsNullOrWhiteSpace(yeniBakiye) ? mevcutBakiye : Convert.ToDecimal(yeniBakiye);
                    decimal yeniGirenValue = string.IsNullOrWhiteSpace(yeniGiren) ? mevcutGiren : Convert.ToDecimal(yeniGiren);
                    decimal yeniCikanValue = string.IsNullOrWhiteSpace(yeniCikan) ? mevcutCikan : Convert.ToDecimal(yeniCikan);
                    int yeniDurumId = (yeniDurum.ToLower() == "aktif") ? 1 : 0;

                    // Güncellenmiş kasa nesnesini oluştur
                    Kasa guncelKasa = new Kasa
                    {
                        KasaID = selectedKasaId,
                        KasaAdi = yeniKasaAdi,
                        Bakiye = yeniBakiyeValue,
                        Giren = yeniGirenValue,
                        Cikan = yeniCikanValue,
                        DurumID = yeniDurumId
                    };

                    // Servis üzerinden güncelleme işlemini gerçekleştir
                    _kasaService.UpdateKasa(guncelKasa);

                    // DataGridView'i güncelle
                    LoadKasalar();

                    // Kullanıcıya bilgi ver
                    MessageBox.Show("Kasa başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kasayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
