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

namespace otelYonetimFinal.Formlar.Giris
{
    public partial class FrmGirisEkrani : Form
    {
        private readonly AdminService _adminService;

        public FrmGirisEkrani()
        {
            InitializeComponent();

            _adminService = new AdminService();

            // Şifre kısmında girilen karakterlerin yerine nokta görünmesi
            txtSifre.PasswordChar = '\u25CF';

            BilgileriGetir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAd = txtKullanici.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAd) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool girisBasarili = _adminService.GirisYap(kullaniciAd, sifre);

            if (girisBasarili)
            {
                BilgileriKaydet();
                // Ana sayfa formunu aç
                Form1 anaSayfa = new Form1();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla)
            {
                txtKullanici.Text = Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Properties.Settings.Default.Parola;
                checkBoxBeniHatirla.Checked = true;
            }
            else
            {
                txtKullanici.Text = string.Empty;
                txtSifre.Text = string.Empty;
                checkBoxBeniHatirla.Checked = false;
            }
        }

        private void BilgileriKaydet()
        {
            if (checkBoxBeniHatirla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = txtKullanici.Text;
                Properties.Settings.Default.Parola = txtSifre.Text;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = string.Empty;
                Properties.Settings.Default.Parola = string.Empty;
                Properties.Settings.Default.BeniHatirla = false;
            }
            Properties.Settings.Default.Save();
        }


        private void linkLabelSifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Kullanıcı adı al
                string kullaniciAd = Microsoft.VisualBasic.Interaction.InputBox(
                    "Lütfen kullanıcı adınızı giriniz:",
                    "Kullanıcı Adı Doğrulama",
                    "");

                if (string.IsNullOrEmpty(kullaniciAd))
                {
                    MessageBox.Show("Kullanıcı adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kullanıcı adı doğrulaması
                AdminService adminService = new AdminService();
                bool kullaniciVarMi = adminService.KullaniciVarMi(kullaniciAd);

                if (!kullaniciVarMi)
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı sistemde bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Yeni şifre al
                string yeniSifre = Microsoft.VisualBasic.Interaction.InputBox(
                    "Lütfen yeni şifrenizi giriniz:",
                    "Şifre Yenileme",
                    "");

                if (string.IsNullOrEmpty(yeniSifre))
                {
                    MessageBox.Show("Şifre boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Şifreyi güncelle
                adminService.UpdatePassword(kullaniciAd, yeniSifre);

                MessageBox.Show("Şifreniz başarıyla yenilenmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şifre yenilenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
