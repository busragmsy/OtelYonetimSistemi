using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.SERVICE;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmTelefon : Form
    {
        private TelefonService _telefonService;

        public FrmTelefon()
        {
            InitializeComponent();
            _telefonService = new TelefonService();
        }

        private void FrmTelefon_Load(object sender, EventArgs e)
        {
            LoadTelefon();
        }

        private void LoadTelefon()
        {
            try
            {
                var telefonListesi = _telefonService.GetAllTelefon();

                dataGridViewTelefon.DataSource = null;
                dataGridViewTelefon.DataSource = telefonListesi;

                ConfigureDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            if (dataGridViewTelefon.Columns["TelefonID"] != null)
                dataGridViewTelefon.Columns["TelefonID"].Visible = false;

            dataGridViewTelefon.Columns["Aciklama"].HeaderText = "Açıklama";
            dataGridViewTelefon.Columns["TelefonNo"].HeaderText = "Telefon Numarası";
            dataGridViewTelefon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTelefonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string aciklama = txtAciklama.Text.Trim();
                string telefonNo = txtTelefon.Text.Trim();

                if (string.IsNullOrWhiteSpace(aciklama) || string.IsNullOrWhiteSpace(telefonNo))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Telefon yeniTelefon = new Telefon
                {
                    Aciklama = aciklama,
                    TelefonNo = telefonNo
                };

                _telefonService.AddTelefon(yeniTelefon);
                MessageBox.Show("Telefon başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTelefon();
                txtAciklama.Clear();
                txtTelefon.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTelefon.SelectedRows.Count > 0)
                {
                    int telefonID = Convert.ToInt32(dataGridViewTelefon.SelectedRows[0].Cells["TelefonID"].Value);

                    DialogResult dialogResult = MessageBox.Show("Bu telefonu silmek istediğinize emin misiniz?",
                        "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        _telefonService.DeleteTelefon(telefonID);
                        MessageBox.Show("Telefon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTelefon();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz telefonu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTelefonAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtTelefonAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadTelefon(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisTelefonListesi = _telefonService.GetAllTelefon()
                    .Where(t => t.Aciklama.ToLower().Contains(aramaMetni) || // Açıklama içeren kayıtlar
                                t.TelefonNo.ToLower().Contains(aramaMetni))   // Telefon numarası içeren kayıtlar
                    .ToList();

                // Filtrelenmiş listeyi DataGridView'e yükle
                dataGridViewTelefon.DataSource = null; // Eski veriyi temizle
                dataGridViewTelefon.DataSource = filtrelenmisTelefonListesi; // Yeni filtrelenmiş listeyi bağla

                ConfigureDataGridViewColumns(); // DataGridView sütunlarını yeniden düzenle
            }
        }

        private void txtTelefonAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtTelefonAra.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                LoadTelefon(); // Eğer arama metni boşsa tüm kayıtları yükle
            }
            else
            {
                // Arama kriterine göre filtreleme yap
                var filtrelenmisTelefonListesi = _telefonService.GetAllTelefon()
                    .Where(t => t.Aciklama.ToLower().Contains(aramaMetni) || // Açıklama içeren kayıtlar
                                t.TelefonNo.ToLower().Contains(aramaMetni))   // Telefon numarası içeren kayıtlar
                    .ToList();

                // Filtrelenmiş listeyi DataGridView'e yükle
                dataGridViewTelefon.DataSource = null; // Eski veriyi temizle
                dataGridViewTelefon.DataSource = filtrelenmisTelefonListesi; // Yeni filtrelenmiş listeyi bağla

                ConfigureDataGridViewColumns(); // DataGridView sütunlarını yeniden düzenle
            }
        }

        private void txtTelefonAra_Enter(object sender, EventArgs e)
        {
            if (txtTelefonAra.Text == "Ara...")
            {
                txtTelefonAra.Text = "";
                txtTelefonAra.ForeColor = Color.Black;
            }
        }

        private void txtTelefonAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonAra.Text))
            {
                txtTelefonAra.Text = "Ara...";
                txtTelefonAra.ForeColor = Color.Gray;
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTelefon.SelectedRows.Count > 0)
                {
                    // Seçilen satırdaki TelefonID'yi al
                    int selectedTelefonID = Convert.ToInt32(dataGridViewTelefon.SelectedRows[0].Cells["TelefonID"].Value);

                    // Yeni bilgiler için InputBox kullanımı
                    string yeniAciklama = Microsoft.VisualBasic.Interaction.InputBox("Yeni Açıklamayı Girin:", "Açıklama Güncelle", dataGridViewTelefon.SelectedRows[0].Cells["Aciklama"].Value.ToString());
                    string yeniTelefonNo = Microsoft.VisualBasic.Interaction.InputBox("Yeni Telefon Numarasını Girin:", "Telefon Numarası Güncelle", dataGridViewTelefon.SelectedRows[0].Cells["TelefonNo"].Value.ToString());

                    // Boş alan kontrolü
                    if (string.IsNullOrWhiteSpace(yeniAciklama) || string.IsNullOrWhiteSpace(yeniTelefonNo))
                    {
                        MessageBox.Show("Açıklama ve Telefon Numarası boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Telefon nesnesini oluştur ve güncelle
                    Telefon guncellenecekTelefon = new Telefon
                    {
                        TelefonID = selectedTelefonID,
                        Aciklama = yeniAciklama,
                        TelefonNo = yeniTelefonNo
                    };

                    _telefonService.UpdateTelefon(guncellenecekTelefon);

                    // Başarı mesajı ve liste yenileme
                    MessageBox.Show("Telefon bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTelefon(); // DataGridView'i güncelle
                }
                else
                {
                    MessageBox.Show("Lütfen güncellenecek bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dataGridViewTelefon.SelectedRows.Count == 0)
            {
                e.Cancel = true; // Eğer satır seçili değilse menüyü kapat
            }
        }
    }
}
