using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using otelYonetimFinal.SERVICE;

namespace otelYonetimFinal.Formlar.Personel
{
    public partial class FrmPersonelListesi : Form
    {
        private PersonelService _personelService;

        public FrmPersonelListesi()
        {
            InitializeComponent();
            _personelService = new PersonelService();
            // Dock işlemini desteklemesi için aşağıdaki ayarlar yapılabilir
            this.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            this.TopLevel = false; // Formun MDI Parent içinde açılmasını sağla
            this.Dock = DockStyle.None; // Varsayılan olarak Dock'u serbest bırak
        }

        private void FrmPersonelListesi_Load(object sender, EventArgs e)
        {
            LoadPersonelList();
        }

        private void LoadPersonelList()
        {
            try
            {
                var personelList = _personelService.GetPersonelList();
                dataGridViewPersonel.DataSource = personelList;

                // İstemediğiniz sütunları gizleyin (örneğin ID'ler)
                if (dataGridViewPersonel.Columns["DepartmanID"] != null)
                    dataGridViewPersonel.Columns["DepartmanID"].Visible = false;
               // if (dataGridViewPersonel.Columns["PersonelID"] != null)
                 //   dataGridViewPersonel.Columns["PersonelID"].Visible = false;
                if (dataGridViewPersonel.Columns["GorevID"] != null)
                    dataGridViewPersonel.Columns["GorevID"].Visible = false;
                if (dataGridViewPersonel.Columns["DurumID"] != null)
                    dataGridViewPersonel.Columns["DurumID"].Visible = false;

                // Sütun başlıklarını düzenle
                dataGridViewPersonel.Columns["AdSoyad"].HeaderText = "Ad Soyad";
                dataGridViewPersonel.Columns["TC"].HeaderText = "TC Kimlik No";
                dataGridViewPersonel.Columns["Departman"].HeaderText = "Departman";
                dataGridViewPersonel.Columns["Gorev"].HeaderText = "Görev";
                dataGridViewPersonel.Columns["Durum"].HeaderText = "Durum";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.CurrentRow != null)
            {
                var personelID = Convert.ToInt32(dataGridViewPersonel.CurrentRow.Cells["PersonelID"].Value);

                // Silme işlemi için kullanıcıdan onay al
                var result = MessageBox.Show("Seçilen personel silinecek. Emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _personelService.DeletePersonel(personelID);
                        MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPersonelList(); // Verileri güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuItemGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedRows.Count > 0)
            {
                // Seçilen satırdan PersonelID değerini al
                int personelID = Convert.ToInt32(dataGridViewPersonel.SelectedRows[0].Cells["PersonelID"].Value);

                // FrmPersonelKarti formunu aç ve PersonelID'yi gönder
                FrmPersonelKarti frmPersonelKarti = new FrmPersonelKarti();
                frmPersonelKarti.PersonelID = personelID; // FrmPersonelKarti'deki public property'ye set et
                frmPersonelKarti.ShowDialog();

                // Form kapandıktan sonra listeyi yenile
                LoadPersonelList();
            }
            else
            {
                MessageBox.Show("Lütfen bir personel seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPersonel_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.CurrentRow != null)
            {
                // Seçili satırdaki PersonelID'yi al
                int personelID = Convert.ToInt32(dataGridViewPersonel.CurrentRow.Cells["PersonelID"].Value);

                // FrmPersonelKarti'ni aç ve ID'yi gönder
                FrmPersonelKarti fr = new FrmPersonelKarti
                {
                    PersonelID = personelID // FrmPersonelKarti'ye ID aktarımı
                };
                fr.ShowDialog();

                // Güncellemeden sonra listeyi yenile
                LoadPersonelList();
            }
        }
    }
}
