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


namespace otelYonetimFinal.Formlar.Misafirler
{
    public partial class FrmMisafirListesi : Form
    {
        //public int MisafirID { get; set; }
        private MisafirService _misafirService;

        public FrmMisafirListesi()
        {
            InitializeComponent();
            _misafirService = new MisafirService();
            // Dock işlemi için ayarlar
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.None;
        }

        private void FrmMisafirListesi_Load(object sender, EventArgs e)
        {
            LoadMisafirList();

        }

        private void LoadMisafirList()
        {
            try
            {
                var misafirList = _misafirService.GetMisafirList();
                dataGridViewMisafir.DataSource = misafirList;

                if (dataGridViewMisafir.Columns["Durum"] != null)
                    dataGridViewMisafir.Columns["Durum"].Visible = false;

                dataGridViewMisafir.Columns["AdSoyad"].HeaderText = "Ad Soyad";
                dataGridViewMisafir.Columns["TC"].HeaderText = "TC Kimlik No";
                dataGridViewMisafir.Columns["Telefon"].HeaderText = "Telefon";
                dataGridViewMisafir.Columns["Aciklama"].HeaderText = "Açıklama";
                dataGridViewMisafir.Columns["Ulke"].HeaderText = "Ülke";
                dataGridViewMisafir.Columns["Sehir"].HeaderText = "Şehir";
                dataGridViewMisafir.Columns["Ilce"].HeaderText = "İlçe";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMisafir.CurrentRow != null)
            {
                // Seçili satırdaki MisafirID'yi al
                var misafirID = Convert.ToInt32(dataGridViewMisafir.CurrentRow.Cells["MisafirID"].Value);

                // Kullanıcıdan onay al
                var result = MessageBox.Show("Seçilen misafir kaydı silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Misafiri sil
                        _misafirService.DeleteMisafir(misafirID);

                        // Başarı mesajı göster
                        MessageBox.Show("Misafir başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Listeyi yenile
                        LoadMisafirList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir misafir seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuItemGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewMisafir.SelectedRows.Count > 0)
            {
                int misafirID = Convert.ToInt32(dataGridViewMisafir.SelectedRows[0].Cells["MisafirID"].Value);

                FrmMisafirKarti frmMisafirKarti = new FrmMisafirKarti
                {
                    MisafirID = misafirID
                };
                frmMisafirKarti.ShowDialog();

                LoadMisafirList(); // Listeyi yenile
            }
            else
            {
                MessageBox.Show("Lütfen bir misafir seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewMisafir_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewMisafir.CurrentRow != null)
            {
                // Seçili satırdaki MisafirID'yi al
                int misafirID = Convert.ToInt32(dataGridViewMisafir.CurrentRow.Cells["MisafirID"].Value);

                // FrmMisafirKarti'ni aç ve ID'yi gönder
                FrmMisafirKarti fr = new FrmMisafirKarti
                {
                    MisafirID = misafirID // FrmMisafirKarti'ye ID aktarımı
                };
                fr.ShowDialog();

                // Güncellemeden sonra listeyi yenile
                LoadMisafirList();
            }
        }
    }
}
