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
    public partial class FrmTumRezervasyonListesi : Form
    {
        private RezervasyonService _rezervasyonService;


        public FrmTumRezervasyonListesi()
        {
            InitializeComponent();
            _rezervasyonService = new RezervasyonService();

            // Dock işlemi için ayarlar
            this.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            this.TopLevel = false; // MDI Parent içinde açılmasını sağla
            this.Dock = DockStyle.None; // Serbest bırak
        }

        private void FrmTumRezervasyonListesi_Load(object sender, EventArgs e)
        {
            LoadRezervasyonList();
        }

        private void LoadRezervasyonList()
        {
            try
            {
                var rezervasyonList = _rezervasyonService.GetRezervasyonListWithDetails();
                if (rezervasyonList == null || rezervasyonList.Rows.Count == 0)
                {
                    MessageBox.Show("Gösterilecek rezervasyon kaydı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridViewRezervasyon.DataSource = rezervasyonList;

                // DataGridView sütun düzenlemeleri
                if (dataGridViewRezervasyon.Columns["RezervasyonID"] != null)
                    dataGridViewRezervasyon.Columns["RezervasyonID"].Visible = false;

                dataGridViewRezervasyon.Columns["MisafirAdSoyad"].HeaderText = "Misafir";
                dataGridViewRezervasyon.Columns["GirisTarih"].HeaderText = "Giriş Tarihi";
                dataGridViewRezervasyon.Columns["CikisTarih"].HeaderText = "Çıkış Tarihi";
                dataGridViewRezervasyon.Columns["Kisi"].HeaderText = "Kişi Sayısı";
                dataGridViewRezervasyon.Columns["Oda"].HeaderText = "Oda";
                dataGridViewRezervasyon.Columns["RezervasyonAdSoyad"].HeaderText = "Rezervasyon Adı";
                dataGridViewRezervasyon.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}\n\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervasyon.CurrentRow != null)
            {
                // Seçili satırdaki RezervasyonID değerini al
                var rezervasyonID = Convert.ToInt32(dataGridViewRezervasyon.CurrentRow.Cells["RezervasyonID"].Value);

                // Silme işlemi için onay al
                var result = MessageBox.Show("Seçilen rezervasyon silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Rezervasyonu sil
                        _rezervasyonService.DeleteRezervasyon(rezervasyonID);
                        MessageBox.Show("Rezervasyon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeyi yenile
                        LoadRezervasyonList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuItemGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervasyon.SelectedRows.Count > 0)
            {
                // Seçilen satırdan RezervasyonID değerini al
                int rezervasyonID = Convert.ToInt32(dataGridViewRezervasyon.SelectedRows[0].Cells["RezervasyonID"].Value);

                // FrmRezervasyonKarti formunu aç ve RezervasyonID'yi gönder
                FrmRezervasyonKarti frmRezervasyonKarti = new FrmRezervasyonKarti();
                frmRezervasyonKarti.RezervasyonID = rezervasyonID; // FrmRezervasyonKarti'deki public property'ye set et
                frmRezervasyonKarti.ShowDialog();

                // Form kapandıktan sonra listeyi yenile
                LoadRezervasyonList();
            }
            else
            {
                MessageBox.Show("Lütfen bir rezervasyon seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
