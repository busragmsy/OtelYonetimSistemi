using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otelYonetimFinal.Service;
using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.Service;
using Microsoft.VisualBasic;
using DevExpress.Data.NetCompatibility.Extensions;

namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    public partial class FrmDurum : Form
    {
        private DurumService _durumService = new DurumService();

        public FrmDurum()
        {
            InitializeComponent();
        }

        private void FrmDurum_Load(object sender, EventArgs e)
        {
            LoadDurumlar();
        }
        private void LoadDurumlar()
        {
            var durumlar = _durumService.GetDurumlar();
            dataGridViewDurum.DataSource = null;
            dataGridViewDurum.DataSource = durumlar;
        }


        private void btnDurumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _durumService.AddDurum(new Durum
                {
                    DurumAd = txtDurumAd.Text
                });
                LoadDurumlar(); // Listeyi güncelle
                MessageBox.Show("Durum başarıyla eklendi.");
                txtDurumAd.Clear(); // TextBox'ı temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDurum.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridViewDurum.SelectedRows[0].Cells[0].Value);
                    _durumService.DeleteDurum(id);
                    LoadDurumlar(); // Listeyi güncelle
                    MessageBox.Show("Durum başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz durumu seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDurum.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewDurum.SelectedRows[0].Cells[0].Value);
                string eskiAd = dataGridViewDurum.SelectedRows[0].Cells[1].Value.ToString();

                string yeniAd = Interaction.InputBox("Durum Adını Güncelle\nEski Ad: " + eskiAd,"Güncelle", eskiAd);

                if (!string.IsNullOrWhiteSpace(yeniAd) && yeniAd != eskiAd)
                {
                    try
                    {
                        _durumService.UpdateDurum(new Durum
                        {
                            DurumID = id,
                            DurumAd = yeniAd
                        });

                        LoadDurumlar();
                        MessageBox.Show("Durum başarıyla güncellendi.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi iptal edildi veya değişiklik yapılmadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir durum seçin.");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtDurumAra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(aramaMetni))
            {
                // GetDurumlar'dan tüm durumları al ve arama uygula
                var durumlar = _durumService.GetDurumlar()
                    .Where(d => d.DurumAd.IndexOf(aramaMetni, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (durumlar.Count > 0)
                {
                    dataGridViewDurum.DataSource = null; // Eski bağlamayı temizle
                    dataGridViewDurum.DataSource = durumlar; // Yeni sonuçları bağla
                }
                else
                {
                    dataGridViewDurum.DataSource = null; // Hiçbir kayıt bulunamadığında tabloyu temizle
                    MessageBox.Show("Arama sonucunda hiçbir kayıt bulunamadı.");
                }
            }
            else
            {
                LoadDurumlar(); // Arama metni boşsa tüm verileri yükle
            }
        }


        private void txtDurumAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDurumAra.Text))
            {
                LoadDurumlar(); // Arama metni boşsa tüm verileri yükle
            }
        }

        private void txtDurumAra_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDurumAra.Text))
            {
                LoadDurumlar(); // Arama metni boşsa tüm verileri yükle
            }
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            string aramaMetni = txtDurumAra.Text.Trim();

            if (!string.IsNullOrWhiteSpace(aramaMetni))
            {
                // GetDurumlar'dan tüm durumları al ve arama uygula
                var durumlar = _durumService.GetDurumlar()
                    .Where(d => d.DurumAd.IndexOf(aramaMetni, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();

                if (durumlar.Count > 0)
                {
                    dataGridViewDurum.DataSource = null; // Eski bağlamayı temizle
                    dataGridViewDurum.DataSource = durumlar; // Yeni sonuçları bağla
                }
                else
                {
                    dataGridViewDurum.DataSource = null; // Hiçbir kayıt bulunamadığında tabloyu temizle
                    MessageBox.Show("Arama sonucunda hiçbir kayıt bulunamadı.");
                }
            }
            else
            {
                LoadDurumlar(); // Arama metni boşsa tüm verileri yükle
            }
        }
    }
}
