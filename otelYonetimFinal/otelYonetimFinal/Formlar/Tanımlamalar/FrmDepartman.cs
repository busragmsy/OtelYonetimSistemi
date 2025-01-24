using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.NetCompatibility.Extensions;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.Service;
using otelYonetimFinal.SERVICE;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmDepartman : Form
    {
        private DepartmanService _departmanService;

        public FrmDepartman()
        {
            InitializeComponent();
            _departmanService = new DepartmanService();

        }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            
            Durum.DataSource = _departmanService.GetDurumlar();
            var durumlar = _departmanService.GetDurumlar();
            Durum.DataSource = durumlar;
            Durum.ValueMember = "DurumID";
            Durum.DisplayMember = "DurumAd";
            dataGridViewDepartman.DataSource = _departmanService.gettable();
            ComboyaVeriGetir();
          
            // Listele();
            dataGridViewDepartman.AutoGenerateColumns = false;
        }

        private void ComboyaVeriGetir()
        {
            try
            {
                var durumlar = _departmanService.GetDurumlar();
                cmbDurum.DataSource = durumlar;
                cmbDurum.ValueMember = "DurumID";
                cmbDurum.DisplayMember = "DurumAd";
                cmbDurum.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Durumlar yüklenirken hata oluştu: {ex.Message}");
            }
        }

        private void Listele()
        {
            var departmanlar = _departmanService.GetDepartmanlar();
            dataGridViewDepartman.DataSource = departmanlar;
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Verilerin doğruluğunu kontrol et
                if (string.IsNullOrWhiteSpace(txtDepartmanAd.Text) || string.IsNullOrWhiteSpace(txtDepartmanTel.Text) || cmbDurum.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Yeni departman nesnesi oluştur
                Departman yeniDepartman = new Departman
                {
                    DepartmanAd = txtDepartmanAd.Text.Trim(),
                    Telefon = txtDepartmanTel.Text.Trim(),
                    Durum = Convert.ToInt32(cmbDurum.SelectedValue) // ComboBox'tan DurumID alınıyor
                };

                // Veritabanına ekle
                _departmanService.AddDepartman(yeniDepartman);
                MessageBox.Show("Departman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu temizle ve DataGridView'i güncelle
                ClearInputs();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            // Form giriş alanlarını temizle
            txtDepartmanAd.Clear();
            txtDepartmanTel.Clear();
            cmbDurum.SelectedIndex = -1;
        }



        private void btnDepartmanAra_Click(object sender, EventArgs e)
        {
            try
            {
                var arama = txtDepartmanAra.Text.Trim();

                if (!string.IsNullOrWhiteSpace(arama))
                {
                    var aramaSonuc = _departmanService.GetDepartmanlar()
                        .Where(d => d.DepartmanAd.Contains(arama, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    dataGridViewDepartman.DataSource = aramaSonuc;
                }
                else
                {
                    Listele(); // Tüm departmanları listele
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDepartmanAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var arama = txtDepartmanAra.Text.Trim();

                if (!string.IsNullOrWhiteSpace(arama))
                {
                    var aramaSonuc = _departmanService.GetDepartmanlar()
                        .Where(d => d.DepartmanAd.Contains(arama, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    dataGridViewDepartman.DataSource = aramaSonuc;
                }
                else
                {
                    Listele(); // Tüm departmanları listele
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırı kontrol et
                if (dataGridViewDepartman.SelectedRows.Count > 0)
                {
                    var seciliDepartmanID = Convert.ToInt32(dataGridViewDepartman.SelectedRows[0].Cells["DepartmanID"].Value);
                    var mevcutAd = dataGridViewDepartman.SelectedRows[0].Cells["DepartmanAd"].Value.ToString();
                    var mevcutTelefon = dataGridViewDepartman.SelectedRows[0].Cells["Telefon"].Value.ToString();
                    var mevcutDurum = Convert.ToInt32(dataGridViewDepartman.SelectedRows[0].Cells["Durum"].Value);

                    // Güncellemeler için yeni bilgiler al
                    string yeniAd = Microsoft.VisualBasic.Interaction.InputBox("Yeni Departman Adı:", "Güncelle", mevcutAd);
                    string yeniTelefon = Microsoft.VisualBasic.Interaction.InputBox("Yeni Telefon:", "Güncelle", mevcutTelefon);
                    int yeniDurum = mevcutDurum; // Durumu değiştirmek istemiyorsanız bu kalabilir.

                    // Güncelleme işlemi
                    Departman guncellenenDepartman = new Departman
                    {
                        DepartmanID = seciliDepartmanID,
                        DepartmanAd = yeniAd.Trim(),
                        Telefon = yeniTelefon.Trim(),
                        Durum = yeniDurum
                    };

                    _departmanService.UpdateDepartman(guncellenenDepartman);
                    MessageBox.Show("Departman başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // DataGridView'i güncelle
                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz bir satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırı kontrol et
                if (dataGridViewDepartman.SelectedRows.Count > 0)
                {
                    var seciliDepartmanID = Convert.ToInt32(dataGridViewDepartman.SelectedRows[0].Cells["DepartmanID"].Value);

                    // Silme işlemi
                    var sonuc = MessageBox.Show("Seçilen departmanı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.Yes)
                    {
                        _departmanService.DeleteDepartman(seciliDepartmanID);
                        MessageBox.Show("Departman başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // DataGridView'i güncelle
                        Listele();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz bir satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDepartman_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
