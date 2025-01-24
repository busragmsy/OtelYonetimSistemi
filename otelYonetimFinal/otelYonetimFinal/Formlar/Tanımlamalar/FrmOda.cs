using otelYonetimFinal.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmOda : Form
    {
        private OdaService _odaService;
        private DurumService _durumService;

        public FrmOda()
        {
            InitializeComponent();
            _odaService = new OdaService();
            _durumService = new DurumService();
        }

        private void FrmOda_Load(object sender, EventArgs e)
        {
            LoadOda();
            LoadDurum();
            ConfigureDataGridViewColumns();
        }

        private void LoadOda()
        {
            try
            {
                // Verileri OdaService aracılığıyla çek
                var odaListesi = _odaService.GetAllOda();

                // DataGridView'i temizle ve yeniden bağla
                dataGridViewOda.DataSource = null; // Önce eski veri bağlantısını kaldır
                dataGridViewOda.DataSource = odaListesi; // Yeni veriyi bağla

                // DataGridView'deki sütunları düzenle
                dataGridViewOda.Columns["OdaID"].Visible = false; // OdaID sütununu gizle
                dataGridViewOda.Columns["DurumID"].Visible = false; // DurumID sütununu gizle
                dataGridViewOda.Columns["Aciklama"].Visible = false; // Açıklama sütununu gizle

                dataGridViewOda.Columns["OdaNo"].HeaderText = "Oda Numarası"; // Sütun başlığını değiştir
                dataGridViewOda.Columns["Kat"].HeaderText = "Kat"; // Sütun başlığını düzenle
                dataGridViewOda.Columns["Kapasite"].HeaderText = "Kapasite"; // Sütun başlığını düzenle
                dataGridViewOda.Columns["Telefon"].HeaderText = "Telefon"; // Sütun başlığını düzenle
                dataGridViewOda.Columns["DurumAd"].HeaderText = "Durum"; // DurumAd başlığını düzenle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDurum()
        {
            try
            {
                var durumListesi = new DurumService().GetDurumlar();
                cmbDurum.DataSource = durumListesi;
                cmbDurum.DisplayMember = "DurumAd"; // Kullanıcıya gösterilecek alan
                cmbDurum.ValueMember = "DurumID";  // Seçilen değerin ID'si
                cmbDurum.SelectedIndex = -1;       // Varsayılan olarak seçili öğe yok
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Durumlar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            // DataGridView'deki sütunları düzenle
            if (dataGridViewOda.Columns["OdaID"] != null)
                dataGridViewOda.Columns["OdaID"].Visible = false; // OdaID sütununu gizle

            if (dataGridViewOda.Columns["Aciklama"] != null)
                dataGridViewOda.Columns["Aciklama"].Visible = false; // Açıklama sütununu gizle

            if (dataGridViewOda.Columns["DurumID"] != null)
                dataGridViewOda.Columns["DurumID"].Visible = false; // DurumID sütununu gizle

            dataGridViewOda.Columns["OdaNo"].HeaderText = "Oda Numarası"; // Sütun başlığını değiştir
            dataGridViewOda.Columns["Kat"].HeaderText = "Kat"; // Sütun başlığını düzenle
            dataGridViewOda.Columns["Kapasite"].HeaderText = "Kapasite"; // Sütun başlığını düzenle
            dataGridViewOda.Columns["Telefon"].HeaderText = "Telefon"; // Sütun başlığını düzenle
            dataGridViewOda.Columns["DurumAd"].HeaderText = "Durum"; // DurumAd başlığını düzenle
        }

        private void dataGridViewOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan oda numarası al
                string odaNo = txtOdaNo.Text.Trim();

                // Oda numarası kontrolü
                if (string.IsNullOrWhiteSpace(odaNo))
                {
                    MessageBox.Show("Lütfen bir oda numarası girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcıdan durum seçimi al
                if (cmbDurum.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir durum seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int durumId = (int)cmbDurum.SelectedValue;

                // Service katmanını çağır ve güncelleme yap
                _odaService.UpdateOdaByOdaNo(odaNo, durumId);

                // Başarılı güncelleme mesajı
                MessageBox.Show("Oda durumu başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // DataGridView'i yenile
                LoadOda();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtOdaAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadOda(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisOdaListesi = _odaService.GetAllOda()
                    .Where(o => o.OdaNo.ToLower().Contains(aramaMetni) || // Oda Numarası içeren kayıtlar
                                o.Kat.ToLower().Contains(aramaMetni) ||  // Kat içeren kayıtlar
                                o.Kapasite.ToLower().Contains(aramaMetni) || // Kapasite içeren kayıtlar
                                o.Telefon.ToLower().Contains(aramaMetni) || // Telefon içeren kayıtlar
                                o.DurumAd.ToLower().Contains(aramaMetni)) // Durum içeren kayıtlar
                    .ToList();

                dataGridViewOda.DataSource = null; // DataGridView'i temizle
                dataGridViewOda.DataSource = filtrelenmisOdaListesi; // Filtrelenmiş listeyi yükle

                // Sadece gerekli sütunları görüntüle
                ConfigureDataGridViewColumns();
            }
        }

        

        private void txtOdaAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtOdaAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadOda(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisOdaListesi = _odaService.GetAllOda()
                    .Where(o => o.OdaNo.ToLower().Contains(aramaMetni) || // Oda Numarası içeren kayıtlar
                                o.Kat.ToLower().Contains(aramaMetni) ||  // Kat içeren kayıtlar
                                o.Kapasite.ToLower().Contains(aramaMetni) || // Kapasite içeren kayıtlar
                                o.Telefon.ToLower().Contains(aramaMetni) || // Telefon içeren kayıtlar
                                o.DurumAd.ToLower().Contains(aramaMetni)) // Durum içeren kayıtlar
                    .ToList();

                dataGridViewOda.DataSource = null; // DataGridView'i temizle
                dataGridViewOda.DataSource = filtrelenmisOdaListesi; // Filtrelenmiş listeyi yükle

                // Sadece gerekli sütunları görüntüle
                ConfigureDataGridViewColumns();
            }
        }

        private void txtOdaAra_Enter(object sender, EventArgs e)
        {
            if (txtOdaAra.Text == "Ara...")
            {
                txtOdaAra.Text = "";
                txtOdaAra.ForeColor = Color.Black;
            }
        }

        private void txtOdaAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdaAra.Text))
            {
                txtOdaAra.Text = "Ara...";
                txtOdaAra.ForeColor = Color.Gray;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırın OdaID'sini al
                if (dataGridViewOda.SelectedRows.Count > 0)
                {
                    int selectedOdaId = Convert.ToInt32(dataGridViewOda.SelectedRows[0].Cells["OdaID"].Value);

                    // Kullanıcıya onay sorusu sor
                    DialogResult dialogResult = MessageBox.Show(
                        "Bu odayı silmek istediğinize emin misiniz?",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Odayı veritabanından sil
                        _odaService.DeleteOda(selectedOdaId);

                        // Kullanıcıya bilgi ver
                        MessageBox.Show("Oda başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        LoadOda();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz odayı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
