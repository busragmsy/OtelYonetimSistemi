using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.Service;
using otelYonetimFinal.SERVICE;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmKur : Form
    {
        private KurService _kurService;
        private DurumService _durumService;


        public FrmKur()
        {
            InitializeComponent();
            _kurService = new KurService(); // KurService başlat
            _durumService = new DurumService(); // DurumService başlat
            LoadKur();
            LoadDurum();
            dtpTarih.Value = DateTime.Now; // Tarihi bugüne ayarla
        }

        private void FrmKur_Load(object sender, EventArgs e)
        {
            LoadKur(); // Verileri yükle
            LoadDurum(); // Durumları ComboBox'a yükle
            dtpTarih.Value = DateTime.Now; // Tarihi bugüne ayarla

        }

        private void LoadKur()
        {
            // Verileri servisten al
            var kurListesi = _kurService.GetAllKur();

            // DataGridView'i temizle ve yeniden bağla
            dataGridViewKur.DataSource = null; // Eski veriyi temizle
            dataGridViewKur.DataSource = kurListesi;

            // DataGridView sütunlarını düzenle
            dataGridViewKur.Columns["KurID"].Visible = false; // ID sütununu gizle
            dataGridViewKur.Columns["DurumID"].Visible = false; // Durum sütununu gizle
            dataGridViewKur.Columns["Durum"].Visible = false;
            dataGridViewKur.Columns["KurAd"].HeaderText = "Kur Adı";
            dataGridViewKur.Columns["Sembol"].HeaderText = "Sembol";
            dataGridViewKur.Columns["Deger"].HeaderText = "Değer";
            dataGridViewKur.Columns["Tarih"].HeaderText = "Tarih";
            dataGridViewKur.Columns["DurumAd"].HeaderText = "Durum";
        }

        private void LoadDurum()
        {
            var durumListesi = _durumService.GetDurumlar();
            if (durumListesi != null && durumListesi.Count > 0)
            {
                cmbDurum.DataSource = durumListesi;
                cmbDurum.DisplayMember = "DurumAd"; // Kullanıcıya gösterilecek alan
                cmbDurum.ValueMember = "DurumID";  // Seçilen değerin ID'si
                cmbDurum.SelectedIndex = -1;       // Varsayılan olarak seçili öğe yok
            }
            else
            {
                MessageBox.Show("Durum listesi boş geldi!");
            }
        }



        private void btnKurEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // TextBox'tan ve diğer alanlardan bilgileri al
                string kurAd = txtKurAd.Text.Trim();
                string sembol = txtSembol.Text.Trim();
                string degerText = txtDeger.Text.Trim();

                // Eğer alanlar boşsa hata göster
                if (string.IsNullOrWhiteSpace(kurAd) || string.IsNullOrWhiteSpace(sembol) || string.IsNullOrWhiteSpace(degerText))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Decimal değeri kontrol et
                if (!decimal.TryParse(degerText, out decimal deger))
                {
                    MessageBox.Show("Geçerli bir değer girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tarih ve Durum bilgilerini al
                DateTime tarih = dtpTarih.Value;
                if (cmbDurum.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir durum seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int durumId = (int)cmbDurum.SelectedValue; // Burada null kontrolü yapıldı

                // Yeni Kur nesnesi oluştur
                var yeniKur = new Kur
                {
                    KurAd = kurAd,
                    Sembol = sembol,
                    Deger = deger,
                    Tarih = tarih,
                    Durum = durumId.ToString() // Burada doğru atama yapıldı
                };

                // Veritabanına ekle
                _kurService.AddKur(yeniKur);

                // Başarı mesajı göster ve DataGridView'i güncelle
                MessageBox.Show("Kur başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKur();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKurAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtKurAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadKur(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisKurListesi = _kurService.GetAllKur()
                    .Where(k => k.KurAd.ToLower().Contains(aramaMetni) || // Kur Adı içeren kayıtlar
                                k.Sembol.ToLower().Contains(aramaMetni) || // Sembol içeren kayıtlar
                                k.DurumAd.ToLower().Contains(aramaMetni)) // Durum içeren kayıtlar
                    .ToList();

                dataGridViewKur.DataSource = null; // DataGridView'i temizle
                dataGridViewKur.DataSource = filtrelenmisKurListesi; // Filtrelenmiş listeyi yükle
            }
        }

        private void txtKurAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtKurAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadKur(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisKurListesi = _kurService.GetAllKur()
                    .Where(k => k.KurAd.ToLower().Contains(aramaMetni) || // Kur Adı içeren kayıtlar
                                k.Sembol.ToLower().Contains(aramaMetni) || // Sembol içeren kayıtlar
                                k.DurumAd.ToLower().Contains(aramaMetni)) // Durum içeren kayıtlar
                    .ToList();

                dataGridViewKur.DataSource = null; // DataGridView'i temizle
                dataGridViewKur.DataSource = filtrelenmisKurListesi; // Filtrelenmiş listeyi yükle
            }
        }

        private void txtKurAra_Enter(object sender, EventArgs e)
        {
            if (txtKurAra.Text == "Ara...")
            {
                txtKurAra.Text = "";
                txtKurAra.ForeColor = Color.Black;
            }
        }

        private void txtKurAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKurAra.Text))
            {
                txtKurAra.Text = "Ara...";
                txtKurAra.ForeColor = Color.Gray;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırın ID'sini al
                if (dataGridViewKur.SelectedRows.Count > 0)
                {
                    int selectedKurId = Convert.ToInt32(dataGridViewKur.SelectedRows[0].Cells["KurID"].Value);

                    // Kullanıcıya onay sorusu sor
                    DialogResult dialogResult = MessageBox.Show(
                        "Bu kur kaydını silmek istediğinize emin misiniz?",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Kur kaydını veritabanından sil
                        _kurService.DeleteKur(selectedKurId);

                        // Kullanıcıya bilgi ver
                        MessageBox.Show("Kur kaydı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        LoadKur();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kur kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçili satırın ID'sini al
                if (dataGridViewKur.SelectedRows.Count > 0)
                {
                    int selectedKurId = Convert.ToInt32(dataGridViewKur.SelectedRows[0].Cells["KurID"].Value);

                    // Mevcut değerleri al
                    string mevcutKurAd = dataGridViewKur.SelectedRows[0].Cells["KurAd"].Value.ToString();
                    string mevcutSembol = dataGridViewKur.SelectedRows[0].Cells["Sembol"].Value.ToString();
                    string mevcutDeger = dataGridViewKur.SelectedRows[0].Cells["Deger"].Value.ToString();
                    string mevcutTarih = dataGridViewKur.SelectedRows[0].Cells["Tarih"].Value.ToString();
                    string mevcutDurumId = dataGridViewKur.SelectedRows[0].Cells["DurumID"].Value.ToString();

                    // Kullanıcıdan yeni bilgileri al (InputBox ile)
                    string yeniKurAd = Microsoft.VisualBasic.Interaction.InputBox($"Kur Adı ({mevcutKurAd}):", "Kur Güncelle", mevcutKurAd);
                    string yeniSembol = Microsoft.VisualBasic.Interaction.InputBox($"Sembol ({mevcutSembol}):", "Kur Güncelle", mevcutSembol);
                    string yeniDeger = Microsoft.VisualBasic.Interaction.InputBox($"Değer ({mevcutDeger}):", "Kur Güncelle", mevcutDeger);
                    string yeniTarih = Microsoft.VisualBasic.Interaction.InputBox($"Tarih ({mevcutTarih}):", "Kur Güncelle", mevcutTarih);
                    string yeniDurumId = Microsoft.VisualBasic.Interaction.InputBox($"Durum ID ({mevcutDurumId}):", "Kur Güncelle", mevcutDurumId);

                    // Kullanıcı boş bıraktıysa mevcut değerleri kullan
                    yeniKurAd = string.IsNullOrWhiteSpace(yeniKurAd) ? mevcutKurAd : yeniKurAd;
                    yeniSembol = string.IsNullOrWhiteSpace(yeniSembol) ? mevcutSembol : yeniSembol;
                    yeniDeger = string.IsNullOrWhiteSpace(yeniDeger) ? mevcutDeger : yeniDeger;
                    yeniTarih = string.IsNullOrWhiteSpace(yeniTarih) ? mevcutTarih : yeniTarih;
                    yeniDurumId = string.IsNullOrWhiteSpace(yeniDurumId) ? mevcutDurumId : yeniDurumId;

                    // Değerleri kontrol et ve dönüştür
                    if (!decimal.TryParse(yeniDeger, out decimal parsedDeger))
                    {
                        MessageBox.Show("Geçerli bir değer girilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!DateTime.TryParse(yeniTarih, out DateTime parsedTarih))
                    {
                        MessageBox.Show("Geçerli bir tarih girilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(yeniDurumId, out int parsedDurumId))
                    {
                        MessageBox.Show("Geçerli bir Durum ID girilmedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Güncellenecek Kur nesnesini oluştur
                    var guncellenenKur = new Kur
                    {
                        KurID = selectedKurId,
                        KurAd = yeniKurAd,
                        Sembol = yeniSembol,
                        Deger = parsedDeger,
                        Tarih = parsedTarih,
                        Durum = parsedDurumId.ToString()
                    };

                    // Güncelleme işlemini gerçekleştir
                    _kurService.UpdateKur(guncellenenKur);

                    // DataGridView'i yenile
                    LoadKur();
                    MessageBox.Show("Kur başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kur kaydını seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}