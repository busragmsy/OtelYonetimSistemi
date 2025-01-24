using DevExpress.XtraCharts;
using otelYonetimFinal.Service;
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

namespace otelYonetimFinal.Formlar.AnaSayfa
{
    public partial class FrmAnaSayfa : Form
    {
        private OdaService _odaService;
        private RezervasyonService _rezervasyonService;

        public FrmAnaSayfa()
        {
            InitializeComponent();
            _odaService = new OdaService();
            _rezervasyonService = new RezervasyonService();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            // Rezervasyon grafiğini doldur
            LoadRezervasyonGrafik();

            // Oda doluluk oranı grafiğini doldur
            LoadOdaDolulukGrafik();

            LoadTemizOdalar();
            LoadBugunGelecekMisafirler();
        }

        private void LoadRezervasyonGrafik()
        {
            try
            {
                string query = "SELECT DATE(GirisTarih) AS Tarih, COUNT(*) AS RezervasyonSayisi " +
                   "FROM TblRezervasyon " +
                   "WHERE GirisTarih >= CURDATE() - INTERVAL 7 DAY " +
                   "GROUP BY DATE(GirisTarih) " +
                   "ORDER BY DATE(GirisTarih);";

                DataTable dataTable = ExecuteQuery(query);

                // ChartControl'ü temizle
                chartControlRezervasyon.Series.Clear();

                // Yeni bir seri ekle
                var series = new DevExpress.XtraCharts.Series("Rezervasyonlar", DevExpress.XtraCharts.ViewType.Bar);

                foreach (DataRow row in dataTable.Rows)
                {
                    series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(
                        Convert.ToDateTime(row["Tarih"]).ToShortDateString(),
                        Convert.ToInt32(row["RezervasyonSayisi"])));
                }

                // Çubuk genişliğini ayarlayın
                var view = (DevExpress.XtraCharts.SideBySideBarSeriesView)series.View;
                view.BarWidth = 3.5; // 0.8 veya daha yüksek bir değer ile çubuk kalınlığını artırabilirsiniz

                // Seriyi ChartControl'e ekle
                chartControlRezervasyon.Series.Add(series);

                // Grafik başlıkları
                chartControlRezervasyon.Titles.Clear();
                chartControlRezervasyon.Titles.Add(new DevExpress.XtraCharts.ChartTitle { Text = "Rezervasyon Grafiği" });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadOdaDolulukGrafik()
        {
            try
            {
                // Veritabanından oda durumu verilerini çek
                DataTable odaData = GetOdaDolulukData();

                // ChartControl'ü temizle
                chartControlOda.Series.Clear();

                // Yeni bir seri ekle (3D Pie Chart için)
                var series = new DevExpress.XtraCharts.Series("Oda Doluluk Durumları", DevExpress.XtraCharts.ViewType.Pie3D);

                // Verileri seriye ekle
                foreach (DataRow row in odaData.Rows)
                {
                    series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(
                        row["DurumAd"], // Durum adı
                        Convert.ToInt32(row["OdaSayisi"]))); // Oda sayısı
                }

                // ToolTip ayarları
                chartControlOda.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
                series.ToolTipPointPattern = "{A}: {V} oda (%{VP:0.##})"; // Tooltip'te gösterilecek bilgi

                // Etiketlerin gösterimini ayarla
                series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True; // Etiketleri göster
                var label = (DevExpress.XtraCharts.PieSeriesLabel)series.Label;
                label.TextPattern = "{A}: %{VP:0.##}"; // Durum adı ve yüzdelik oran gösterimi
                label.Font = new Font("Tahoma", 10, FontStyle.Bold); // Yazı tipini ayarla

                
                
                // Seriyi ChartControl'e ekle
                chartControlOda.Series.Add(series);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Oda doluluk grafiği yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private DataTable GetRezervasyonData()
        {
            // Rezervasyon verilerini gruplu şekilde çek
            string query = @"
            SELECT GirisTarih, COUNT(*) AS RezervasyonSayisi
            FROM TblRezervasyon
            WHERE GirisTarih BETWEEN @BaslangicTarihi AND @BitisTarihi
            GROUP BY GirisTarih
            ORDER BY GirisTarih";

            return ExecuteQuery(query);
        }

        private DataTable GetOdaDolulukData()
        {
            string query = @"
        SELECT
            CASE
                WHEN D.DurumAd IN ('Aktif', 'Pasif') THEN 'Dolu'
                ELSE D.DurumAd
            END AS DurumAd,
            COUNT(*) AS OdaSayisi
        FROM TblOda O
        JOIN TblDurum D ON O.Durum = D.DurumID
        GROUP BY CASE
            WHEN D.DurumAd IN ('Aktif', 'Pasif') THEN 'Dolu'
            ELSE D.DurumAd
        END;";
            return ExecuteQuery(query);
        }


        private DataTable ExecuteQuery(string query)
        {
            // Veritabanına bağlan ve sorguyu çalıştır
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("Server=172.21.54.253;Database=25_132330029; User=25_132330029; Password=!nif.ogr29GU;"))
            {
                conn.Open();
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void dgvOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTemizOdalar()
        {
            try
            {
                // Veritabanından temiz odaları getir
                DataTable temizOdalar = _odaService.GetTemizOdalar();

                // Eğer temiz oda yoksa bilgi mesajı göster
                if (temizOdalar.Rows.Count == 0)
                {
                    MessageBox.Show("Temiz oda bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // DataGridView'e temiz odaları yükle
                dgvOda.DataSource = temizOdalar;

                // Sütun başlıklarını düzenle
                dgvOda.Columns["OdaID"].Visible = false; // OdaID gizleniyor
                dgvOda.Columns["Telefon"].Visible = false; // Telefon bilgisi gizleniyor
                //dgvOda.Columns["Aciklama"].Visible = false; // Açıklama sütunu gizleniyor
                dgvOda.Columns["Aciklama"].HeaderText = "Açıklama";
                dgvOda.Columns["OdaNo"].HeaderText = "Oda Numarası";
                dgvOda.Columns["Kat"].HeaderText = "Kat";
                dgvOda.Columns["Kapasite"].HeaderText = "Kapasite";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Temiz odalar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBugunGelecekMisafirler()
        {
            try
            {
                // Bugünün misafirlerini veritabanından getir
                DataTable bugunGelecekMisafirler = _rezervasyonService.GetBugunGelecekMisafirler();

                // Eğer veri yoksa bilgi mesajı göster
                if (bugunGelecekMisafirler.Rows.Count == 0)
                {
                    MessageBox.Show("Bugün gelecek misafir bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMisafir.DataSource = null;
                    return;
                }

                // DataGridView'e veriyi bağla
                dgvMisafir.DataSource = bugunGelecekMisafirler;

                // Sütun başlıklarını düzenle
                dgvMisafir.Columns["RezervasyonID"].Visible = false; // RezervasyonID gizleniyor
                dgvMisafir.Columns["Ad Soyad"].HeaderText = "Ad Soyad";
                dgvMisafir.Columns["Telefon"].HeaderText = "Telefon";
                dgvMisafir.Columns["Giriş Tarihi"].HeaderText = "Giriş Tarihi";
                dgvMisafir.Columns["Çıkış Tarihi"].HeaderText = "Çıkış Tarihi";
                dgvMisafir.Columns["Oda Numarası"].HeaderText = "Oda Numarası";
                dgvMisafir.Columns["Aciklama"].HeaderText = "Açıklama";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bugün gelecek misafirler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartControlRezervasyon_Click(object sender, EventArgs e)
        {

        }
    }
}
