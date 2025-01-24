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
    public partial class FrmGorev : Form
    {
        private GorevService _gorevService;

        public FrmGorev()
        {
            InitializeComponent();
            _gorevService = new GorevService();
            this.Load += FrmGorev_Load; // Load olayını bağla
        }

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            LoadDepartmanlar();
            LoadDurumlar();
            LoadGorevler();
        }

        // Departmanları ComboBox'a yükle
        private void LoadDepartmanlar()
        {
            cmbDepartman.DataSource = _gorevService.GetDepartmanlar();
            cmbDepartman.DisplayMember = "DepartmanAd"; // Gösterilecek alan
            cmbDepartman.ValueMember = "DepartmanID";   // Seçilen değerin ID'si
            cmbDepartman.SelectedIndex = -1;            // Varsayılan seçimsiz
        }

        // Durumları ComboBox'a yükle
        private void LoadDurumlar()
        {
            cmbDurum.DataSource = _gorevService.GetDurumlar();
            cmbDurum.DisplayMember = "DurumAd"; // Gösterilecek alan
            cmbDurum.ValueMember = "DurumID";   // Seçilen değerin ID'si
            cmbDurum.SelectedIndex = -1;        // Varsayılan seçimsiz
        }

        // Görevleri DataGridView'e yükle
        private void LoadGorevler()
        {
            var gorevler = _gorevService.GetAllGorevler(); // Görevleri Service katmanından al

            // DataGridView'e verileri bağla
            dataGridViewGorev.DataSource = null;
            dataGridViewGorev.DataSource = gorevler;

            // ID sütununu gizle
            if (dataGridViewGorev.Columns["GorevId"] != null)
            {
                dataGridViewGorev.Columns["GorevId"].Visible = false;
            }

            // Başlıkları özelleştir
            CustomizeDataGridViewHeaders();
        }

        private void CustomizeDataGridViewHeaders()
        {
            // Başlıkları özelleştir
            if (dataGridViewGorev.Columns["GorevAd"] != null)
            {
                dataGridViewGorev.Columns["GorevAd"].HeaderText = "Görev Adı";
            }
            if (dataGridViewGorev.Columns["Departman"] != null)
            {
                dataGridViewGorev.Columns["Departman"].HeaderText = "Departman";
            }
            if (dataGridViewGorev.Columns["Durum"] != null)
            {
                dataGridViewGorev.Columns["Durum"].HeaderText = "Durum";
            }
        }


        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'lardan seçilen ID'leri al
                int departmanId = Convert.ToInt32(cmbDepartman.SelectedValue);
                int durumId = Convert.ToInt32(cmbDurum.SelectedValue);

                // TextBox'tan Görev Adı değerini al
                string gorevAd = txtGorevAd.Text.Trim();

                // Eğer Görev Adı boşsa uyarı göster
                if (string.IsNullOrWhiteSpace(gorevAd))
                {
                    MessageBox.Show("Görev Adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni görev oluştur
                Gorev yeniGorev = new Gorev
                {
                    GorevAd = gorevAd,
                    Departman = departmanId.ToString(), // ID gönderiliyor
                    Durum = durumId.ToString()         // ID gönderiliyor
                };

                // Veritabanına ekle
                _gorevService.AddGorev(yeniGorev);

                // DataGridView'i yenile
                LoadGorevler();
                MessageBox.Show("Görev başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGorevAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtGorevAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadGorevler();
            }
            else
            {
                var filtrelenmisGorevler = _gorevService.GetAllGorevler()
                    .Where(g => g.GorevAd.ToLower().Contains(aramaMetni) ||
                                g.Departman.ToLower().Contains(aramaMetni) ||
                                g.Durum.ToLower().Contains(aramaMetni))
                    .ToList();

                dataGridViewGorev.DataSource = null;
                dataGridViewGorev.DataSource = filtrelenmisGorevler;
            }
        }

        private void txtGorevAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtGorevAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadGorevler();
            }
            else
            {
                var filtrelenmisGorevler = _gorevService.GetAllGorevler()
                    .Where(g => g.GorevAd.ToLower().Contains(aramaMetni) ||
                                g.Departman.ToLower().Contains(aramaMetni) ||
                                g.Durum.ToLower().Contains(aramaMetni))
                    .ToList();

                dataGridViewGorev.DataSource = null;
                dataGridViewGorev.DataSource = filtrelenmisGorevler;
            }
        }

        private void txtGorevAra_Enter(object sender, EventArgs e)
        {
            if (txtGorevAra.Text == "Ara...")
            {
                txtGorevAra.Text = "";
                txtGorevAra.ForeColor = Color.Black;
            }
        }

        private void txtGorevAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGorevAra.Text))
            {
                txtGorevAra.Text = "Ara...";
                txtGorevAra.ForeColor = Color.Gray;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // DataGridView'den seçilen satırın ID'sini al
                if (dataGridViewGorev.SelectedRows.Count > 0)
                {
                    int selectedGorevId = Convert.ToInt32(dataGridViewGorev.SelectedRows[0].Cells["GorevId"].Value);

                    // Kullanıcıya onay sorusu sor
                    DialogResult dialogResult = MessageBox.Show(
                        "Bu görevi silmek istediğinize emin misiniz?",
                        "Silme Onayı",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Görevi veritabanından sil
                        _gorevService.DeleteGorev(selectedGorevId);

                        // Kullanıcıya bilgi ver
                        MessageBox.Show("Görev başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        LoadGorevler();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz görevi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DataGridView'den bir satır seçili mi kontrol edin
            if (dataGridViewGorev.SelectedRows.Count > 0)
            {
                // Seçili satırın ID'sini ve mevcut Görev Adını alın
                int id = Convert.ToInt32(dataGridViewGorev.SelectedRows[0].Cells["GorevID"].Value);
                string eskiAd = dataGridViewGorev.SelectedRows[0].Cells["GorevAd"].Value.ToString();

                // Kullanıcıdan yeni Görev Adı bilgisini alın
                string yeniAd = Interaction.InputBox($"Görev Adını Güncelle\nEski Ad: {eskiAd}", "Güncelle", eskiAd);

                // Yeni ad boş değil ve eski adla aynı değilse işlem yap
                if (!string.IsNullOrWhiteSpace(yeniAd) && yeniAd != eskiAd)
                {
                    try
                    {
                        // Görev nesnesini oluştur ve güncelle
                        _gorevService.UpdateGorevAd(new Gorev
                        {
                            GorevId = id,
                            GorevAd = yeniAd
                        });

                        // DataGridView'i yenile
                        LoadGorevler();
                        MessageBox.Show("Görev başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi iptal edildi veya değişiklik yapılmadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir görev seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewGorev_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
