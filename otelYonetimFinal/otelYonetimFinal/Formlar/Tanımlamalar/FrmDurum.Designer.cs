namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmDurum
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
            this.dataGridViewDurum = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDurumAd = new System.Windows.Forms.TextBox();
            this.btnDurumEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDurumAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDurum)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDurum
            // 
            this.dataGridViewDurum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDurum.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewDurum.Location = new System.Drawing.Point(19, 83);
            this.dataGridViewDurum.Name = "dataGridViewDurum";
            this.dataGridViewDurum.ReadOnly = true;
            this.dataGridViewDurum.RowTemplate.Height = 28;
            this.dataGridViewDurum.Size = new System.Drawing.Size(624, 355);
            this.dataGridViewDurum.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.guncelleToolStripMenuItem});
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
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // txtDurumAd
            // 
            this.txtDurumAd.Location = new System.Drawing.Point(232, 469);
            this.txtDurumAd.Multiline = true;
            this.txtDurumAd.Name = "txtDurumAd";
            this.txtDurumAd.Size = new System.Drawing.Size(219, 48);
            this.txtDurumAd.TabIndex = 1;
            // 
            // btnDurumEkle
            // 
            this.btnDurumEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurumEkle.Location = new System.Drawing.Point(485, 469);
            this.btnDurumEkle.Name = "btnDurumEkle";
            this.btnDurumEkle.Size = new System.Drawing.Size(141, 48);
            this.btnDurumEkle.TabIndex = 2;
            this.btnDurumEkle.Text = "EKLE";
            this.btnDurumEkle.UseVisualStyleBackColor = true;
            this.btnDurumEkle.Click += new System.EventHandler(this.btnDurumEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yeni durum giriniz:";
            // 
            // txtDurumAra
            // 
            this.txtDurumAra.Location = new System.Drawing.Point(133, 28);
            this.txtDurumAra.Multiline = true;
            this.txtDurumAra.Name = "txtDurumAra";
            this.txtDurumAra.Size = new System.Drawing.Size(406, 32);
            this.txtDurumAra.TabIndex = 5;
            this.txtDurumAra.TextChanged += new System.EventHandler(this.txtDurumAra_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Durum Ara:";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(551, 28);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 32);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click_1);
            // 
            // FrmDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(650, 540);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDurumAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDurumEkle);
            this.Controls.Add(this.txtDurumAd);
            this.Controls.Add(this.dataGridViewDurum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durum Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmDurum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDurum)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDurum;
        private System.Windows.Forms.TextBox txtDurumAd;
        private System.Windows.Forms.Button btnDurumEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDurumAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAra;
    }
}