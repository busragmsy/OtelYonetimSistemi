namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmKur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.txtSembol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKurAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKurAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKurEkle = new System.Windows.Forms.Button();
            this.txtKurAd = new System.Windows.Forms.TextBox();
            this.dataGridViewKur = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKur)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(105, 589);
            this.txtDeger.Multiline = true;
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(228, 37);
            this.txtDeger.TabIndex = 57;
            // 
            // txtSembol
            // 
            this.txtSembol.Location = new System.Drawing.Point(540, 589);
            this.txtSembol.Multiline = true;
            this.txtSembol.Name = "txtSembol";
            this.txtSembol.Size = new System.Drawing.Size(234, 37);
            this.txtSembol.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 597);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 54;
            this.label6.Text = "Değer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(413, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sembol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Durum Seçiniz:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(206, 662);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(196, 28);
            this.cmbDurum.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(413, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tarih:";
            // 
            // btnKurAra
            // 
            this.btnKurAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKurAra.Location = new System.Drawing.Point(599, 30);
            this.btnKurAra.Name = "btnKurAra";
            this.btnKurAra.Size = new System.Drawing.Size(175, 32);
            this.btnKurAra.TabIndex = 49;
            this.btnKurAra.Text = "ARA";
            this.btnKurAra.UseVisualStyleBackColor = true;
            this.btnKurAra.Click += new System.EventHandler(this.btnKurAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Kur Ara:";
            // 
            // txtKurAra
            // 
            this.txtKurAra.Location = new System.Drawing.Point(146, 27);
            this.txtKurAra.Multiline = true;
            this.txtKurAra.Name = "txtKurAra";
            this.txtKurAra.Size = new System.Drawing.Size(433, 32);
            this.txtKurAra.TabIndex = 47;
            this.txtKurAra.TextChanged += new System.EventHandler(this.txtKurAra_TextChanged);
            this.txtKurAra.Enter += new System.EventHandler(this.txtKurAra_Enter);
            this.txtKurAra.Leave += new System.EventHandler(this.txtKurAra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Kur:";
            // 
            // btnKurEkle
            // 
            this.btnKurEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKurEkle.Location = new System.Drawing.Point(503, 645);
            this.btnKurEkle.Name = "btnKurEkle";
            this.btnKurEkle.Size = new System.Drawing.Size(271, 58);
            this.btnKurEkle.TabIndex = 45;
            this.btnKurEkle.Text = "EKLE";
            this.btnKurEkle.UseVisualStyleBackColor = true;
            this.btnKurEkle.Click += new System.EventHandler(this.btnKurEkle_Click);
            // 
            // txtKurAd
            // 
            this.txtKurAd.Location = new System.Drawing.Point(105, 529);
            this.txtKurAd.Multiline = true;
            this.txtKurAd.Name = "txtKurAd";
            this.txtKurAd.Size = new System.Drawing.Size(228, 37);
            this.txtKurAd.TabIndex = 44;
            // 
            // dataGridViewKur
            // 
            this.dataGridViewKur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKur.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewKur.Location = new System.Drawing.Point(31, 86);
            this.dataGridViewKur.Name = "dataGridViewKur";
            this.dataGridViewKur.ReadOnly = true;
            this.dataGridViewKur.RowTemplate.Height = 28;
            this.dataGridViewKur.Size = new System.Drawing.Size(743, 420);
            this.dataGridViewKur.TabIndex = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.gncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 64);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // gncelleToolStripMenuItem
            // 
            this.gncelleToolStripMenuItem.Name = "gncelleToolStripMenuItem";
            this.gncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.gncelleToolStripMenuItem.Text = "Güncelle";
            this.gncelleToolStripMenuItem.Click += new System.EventHandler(this.gncelleToolStripMenuItem_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(503, 537);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(271, 26);
            this.dtpTarih.TabIndex = 58;
            // 
            // FrmKur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(802, 732);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.txtSembol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKurAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKurAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKurEkle);
            this.Controls.Add(this.txtKurAd);
            this.Controls.Add(this.dataGridViewKur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kur Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmKur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKur)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.TextBox txtSembol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKurAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKurAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKurEkle;
        private System.Windows.Forms.TextBox txtKurAd;
        private System.Windows.Forms.DataGridView dataGridViewKur;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gncelleToolStripMenuItem;
    }
}