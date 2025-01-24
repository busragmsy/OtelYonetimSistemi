namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmKasa
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
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKasaAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKasaAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKasaEkle = new System.Windows.Forms.Button();
            this.txtKasaAd = new System.Windows.Forms.TextBox();
            this.dataGridViewKasa = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.txtCikan = new System.Windows.Forms.TextBox();
            this.txtGiren = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasa)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Durum Seçiniz:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(210, 660);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(196, 28);
            this.cmbDurum.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(364, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bakiye:";
            // 
            // btnKasaAra
            // 
            this.btnKasaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaAra.Location = new System.Drawing.Point(546, 25);
            this.btnKasaAra.Name = "btnKasaAra";
            this.btnKasaAra.Size = new System.Drawing.Size(175, 32);
            this.btnKasaAra.TabIndex = 34;
            this.btnKasaAra.Text = "ARA";
            this.btnKasaAra.UseVisualStyleBackColor = true;
            this.btnKasaAra.Click += new System.EventHandler(this.btnKasaAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kasa Ara:";
            // 
            // txtKasaAra
            // 
            this.txtKasaAra.Location = new System.Drawing.Point(150, 25);
            this.txtKasaAra.Multiline = true;
            this.txtKasaAra.Name = "txtKasaAra";
            this.txtKasaAra.Size = new System.Drawing.Size(375, 32);
            this.txtKasaAra.TabIndex = 32;
            this.txtKasaAra.TextChanged += new System.EventHandler(this.txtKasaAra_TextChanged);
            this.txtKasaAra.Enter += new System.EventHandler(this.txtKasaAra_Enter);
            this.txtKasaAra.Leave += new System.EventHandler(this.txtKasaAra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kasa:";
            // 
            // btnKasaEkle
            // 
            this.btnKasaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaEkle.Location = new System.Drawing.Point(450, 643);
            this.btnKasaEkle.Name = "btnKasaEkle";
            this.btnKasaEkle.Size = new System.Drawing.Size(271, 58);
            this.btnKasaEkle.TabIndex = 30;
            this.btnKasaEkle.Text = "EKLE";
            this.btnKasaEkle.UseVisualStyleBackColor = true;
            this.btnKasaEkle.Click += new System.EventHandler(this.btnKasaEkle_Click);
            // 
            // txtKasaAd
            // 
            this.txtKasaAd.Location = new System.Drawing.Point(109, 527);
            this.txtKasaAd.Multiline = true;
            this.txtKasaAd.Name = "txtKasaAd";
            this.txtKasaAd.Size = new System.Drawing.Size(228, 37);
            this.txtKasaAd.TabIndex = 29;
            // 
            // dataGridViewKasa
            // 
            this.dataGridViewKasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKasa.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewKasa.Location = new System.Drawing.Point(35, 84);
            this.dataGridViewKasa.Name = "dataGridViewKasa";
            this.dataGridViewKasa.ReadOnly = true;
            this.dataGridViewKasa.RowTemplate.Height = 28;
            this.dataGridViewKasa.Size = new System.Drawing.Size(686, 420);
            this.dataGridViewKasa.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(364, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Çıkan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(30, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 39;
            this.label6.Text = "Giren:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(471, 527);
            this.txtBakiye.Multiline = true;
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(250, 37);
            this.txtBakiye.TabIndex = 40;
            // 
            // txtCikan
            // 
            this.txtCikan.Location = new System.Drawing.Point(450, 587);
            this.txtCikan.Multiline = true;
            this.txtCikan.Name = "txtCikan";
            this.txtCikan.Size = new System.Drawing.Size(271, 37);
            this.txtCikan.TabIndex = 41;
            // 
            // txtGiren
            // 
            this.txtGiren.Location = new System.Drawing.Point(109, 587);
            this.txtGiren.Multiline = true;
            this.txtGiren.Name = "txtGiren";
            this.txtGiren.Size = new System.Drawing.Size(228, 37);
            this.txtGiren.TabIndex = 42;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.guncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 97);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(754, 718);
            this.Controls.Add(this.txtGiren);
            this.Controls.Add(this.txtCikan);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKasaAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKasaAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKasaEkle);
            this.Controls.Add(this.txtKasaAd);
            this.Controls.Add(this.dataGridViewKasa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Tanımları";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKasa)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKasaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKasaAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKasaEkle;
        private System.Windows.Forms.TextBox txtKasaAd;
        private System.Windows.Forms.DataGridView dataGridViewKasa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.TextBox txtCikan;
        private System.Windows.Forms.TextBox txtGiren;
    }
}