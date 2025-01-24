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
using otelYonetimFinal.DAL;
using DevExpress.XtraEditors;

namespace otelYonetimFinal.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        private PersonelService _personelService;
        private string _kimlikOnPath;
        private string _kimlikArkaPath;
        public int PersonelID { get; set; } // Güncelleme için ID


        public FrmPersonelKarti()
        {
            InitializeComponent();
            _personelService = new PersonelService();
            LoadComboboxes();
        }

        private void LoadComboboxes()
        {
            try
            {
                var departmanlar = _personelService.GetDepartmanlar();
                cmbDepartman.DataSource = new BindingSource(departmanlar, null);
                cmbDepartman.DisplayMember = "Value";
                cmbDepartman.ValueMember = "Key";

                var gorevler = _personelService.GetGorevler();
                cmbGorev.DataSource = new BindingSource(gorevler, null);
                cmbGorev.DisplayMember = "Value";
                cmbGorev.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            // PictureEdit özelliklerini ayarla
            pictureEditKimlikOn.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEditKimlikOn.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

            pictureEditKimlikArka.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEditKimlikArka.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;

            // Diğer form yükleme işlemleri
            // Örneğin, departman ve görev combobox'larını doldurma
            LoadComboboxes();

            if (PersonelID > 0) // Güncelleme için ID varsa doldurma işlemi
            {
                // Personel bilgilerini doldur
                var personel = _personelService.GetPersonelByID(PersonelID);
                if (personel != null)
                {
                    txtAdSoyad.Text = personel.AdSoyad;
                    txtTC.Text = personel.TC;
                    txtSifre.Text = personel.Sifre;
                    cmbDepartman.SelectedValue = personel.DepartmanID;
                    cmbGorev.SelectedValue = personel.GorevID;
                   // dtpGirisTarihi.Value = personel.IseGirisTarihi ?? DateTime.Now;
                    dtpCikisTarihi.Value = personel.IstenCikisTarihi ?? DateTime.Now;
                    txtAdres.Text = personel.Adres;
                    txtTelefon.Text = personel.Telefon;
                    txtMail.Text = personel.Mail;
                    txtAciklama.Text = personel.Aciklama;
                    radioBtnYetki1.Checked = personel.Durum == 21;
                    radioBtnYetki2.Checked = personel.Durum == 22;
                    radioBtnYetki3.Checked = personel.Durum == 23;
                    //pictureEditKimlikOn.Image = Image.FromFile(personel.KimlikOn);
                    //pictureEditKimlikArka.Image = Image.FromFile(personel.KimlikArka);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var yeniPersonel = new otelYonetimFinal.DOMAİN.Personel
                {
                    AdSoyad = txtAdSoyad.Text.Trim(),
                    TC = txtTC.Text.Trim(),
                    Sifre = txtSifre.Text.Trim(),
                    DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue),
                    GorevID = Convert.ToInt32(cmbGorev.SelectedValue),
                    IseGirisTarihi = dtpGirisTarihi.Value,
                    IstenCikisTarihi = dtpCikisTarihi.Value,
                    Adres = txtAdres.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Mail = txtMail.Text.Trim(),
                    Aciklama = txtAciklama.Text.Trim(),
                    Durum = radioBtnYetki1.Checked ? 21 : radioBtnYetki2.Checked ? 22 : 23,
                    KimlikOn = _kimlikOnPath,
                    KimlikArka = _kimlikArkaPath
                };

                _personelService.AddPersonel(yeniPersonel);

                MessageBox.Show("Personel başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private object ImageToByteArray(PictureEdit pictureEditKimlikArka)
        {
            throw new NotImplementedException();
        }

        private byte[] ImageToByteArray(PictureBox pictureEdit)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                pictureEdit.Image.Save(ms, pictureEdit.Image.RawFormat);
                return ms.ToArray();
            }
        }

        private void ClearForm()
        {
            txtAdSoyad.Clear();
            txtTC.Clear();
            txtSifre.Clear();
            cmbDepartman.SelectedIndex = -1;
            cmbGorev.SelectedIndex = -1;
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now;
            txtAdres.Clear();
            txtTelefon.Clear();
            txtMail.Clear();
            txtAciklama.Clear();
            radioBtnYetki1.Checked = false;
            radioBtnYetki2.Checked = false;
            radioBtnYetki3.Checked = false;
            pictureEditKimlikOn.Image = null;
            pictureEditKimlikArka.Image = null;
        }

        private void pictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.PictureEdit;
            if (editor != null && editor.Image != null)
            {
                // Kullanıcının seçtiği görselin yolunu alın
                _kimlikOnPath = editor.GetLoadedImageLocation();
            }
        }

        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.PictureEdit;
            if (editor != null && editor.Image != null)
            {
                // Kullanıcının seçtiği görselin yolunu alın
                _kimlikArkaPath = editor.GetLoadedImageLocation();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan onay alın
            var result = MessageBox.Show(
                "Değişiklikler iptal edilecek. Form kapatılsın mı?",
                "Onay",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );

            // Kullanıcı "Yes" seçerse
            if (result == DialogResult.Yes)
            {
                // Formdaki bilgileri temizle
                ClearForm();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Değişiklikler iptal edildi. Form kapanıyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu kapat
                this.Close();
            }
            // Kullanıcı "No" seçerse
            else if (result == DialogResult.No)
            {
                // Formdaki bilgileri temizle
                ClearForm();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Değişiklikler iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Kullanıcı "Cancel" seçerse hiçbir işlem yapılmaz
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // Güncelleme işlemi
                var personel = new otelYonetimFinal.DOMAİN.Personel
                {
                    PersonelID = PersonelID,
                    AdSoyad = txtAdSoyad.Text.Trim(),
                    TC = txtTC.Text.Trim(),
                    Sifre = txtSifre.Text.Trim(),
                    DepartmanID = Convert.ToInt32(cmbDepartman.SelectedValue),
                    GorevID = Convert.ToInt32(cmbGorev.SelectedValue),
                    IseGirisTarihi = dtpGirisTarihi.Value,
                    IstenCikisTarihi = dtpCikisTarihi.Checked ? dtpCikisTarihi.Value : (DateTime?)null,
                    Adres = txtAdres.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Mail = txtMail.Text.Trim(),
                    Aciklama = txtAciklama.Text.Trim(),
                    Durum = radioBtnYetki1.Checked ? 21 : radioBtnYetki2.Checked ? 22 : 23,
                    KimlikOn = _kimlikOnPath, // Daha önce belirlenmiş dosya yolu
                    KimlikArka = _kimlikArkaPath, // Daha önce belirlenmiş dosya yolu
                };


                _personelService.UpdatePersonel(personel); // Güncelleme

                MessageBox.Show("Personel başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); // Formu kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
