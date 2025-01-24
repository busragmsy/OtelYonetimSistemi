namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmGorev
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
            this.btnGorevAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGorevAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.txtGorevAd = new System.Windows.Forms.TextBox();
            this.dataGridViewGorev = new System.Windows.Forms.DataGridView();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorev)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(345, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Durum Seçiniz:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(350, 585);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(169, 28);
            this.cmbDurum.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Departman:";
            // 
            // btnGorevAra
            // 
            this.btnGorevAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevAra.Location = new System.Drawing.Point(588, 31);
            this.btnGorevAra.Name = "btnGorevAra";
            this.btnGorevAra.Size = new System.Drawing.Size(91, 32);
            this.btnGorevAra.TabIndex = 22;
            this.btnGorevAra.Text = "ARA";
            this.btnGorevAra.UseVisualStyleBackColor = true;
            this.btnGorevAra.Click += new System.EventHandler(this.btnGorevAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Görev Ara:";
            // 
            // txtGorevAra
            // 
            this.txtGorevAra.Location = new System.Drawing.Point(191, 31);
            this.txtGorevAra.Multiline = true;
            this.txtGorevAra.Name = "txtGorevAra";
            this.txtGorevAra.Size = new System.Drawing.Size(391, 32);
            this.txtGorevAra.TabIndex = 20;
            this.txtGorevAra.TextChanged += new System.EventHandler(this.txtGorevAra_TextChanged);
            this.txtGorevAra.Enter += new System.EventHandler(this.txtGorevAra_Enter);
            this.txtGorevAra.Leave += new System.EventHandler(this.txtGorevAra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Görev:";
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevEkle.Location = new System.Drawing.Point(525, 533);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(154, 80);
            this.btnGorevEkle.TabIndex = 18;
            this.btnGorevEkle.Text = "EKLE";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // txtGorevAd
            // 
            this.txtGorevAd.Location = new System.Drawing.Point(133, 533);
            this.txtGorevAd.Multiline = true;
            this.txtGorevAd.Name = "txtGorevAd";
            this.txtGorevAd.Size = new System.Drawing.Size(200, 37);
            this.txtGorevAd.TabIndex = 17;
            // 
            // dataGridViewGorev
            // 
            this.dataGridViewGorev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGorev.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewGorev.Location = new System.Drawing.Point(33, 90);
            this.dataGridViewGorev.Name = "dataGridViewGorev";
            this.dataGridViewGorev.ReadOnly = true;
            this.dataGridViewGorev.RowTemplate.Height = 28;
            this.dataGridViewGorev.Size = new System.Drawing.Size(646, 420);
            this.dataGridViewGorev.TabIndex = 16;
            this.dataGridViewGorev.SelectionChanged += new System.EventHandler(this.dataGridViewGorev_SelectionChanged);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Location = new System.Drawing.Point(171, 585);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(162, 28);
            this.cmbDepartman.TabIndex = 27;
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
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
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
            // FrmGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(710, 653);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGorevAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGorevAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.txtGorevAd);
            this.Controls.Add(this.dataGridViewGorev);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGorev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmGorev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorev)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGorevAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGorevAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.TextBox txtGorevAd;
        private System.Windows.Forms.DataGridView dataGridViewGorev;
        private System.Windows.Forms.ComboBox cmbDepartman;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
    }
}