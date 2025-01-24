namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmDepartman
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDepartmanEkle = new System.Windows.Forms.Button();
            this.txtDepartmanAd = new System.Windows.Forms.TextBox();
            this.btnDepartmanAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartmanAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmanTel = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dataGridViewDepartman = new System.Windows.Forms.DataGridView();
            this.DepartmanAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).BeginInit();
            this.SuspendLayout();
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
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click_1);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.guncelleToolStripMenuItem.Text = "Güncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Departman:";
            // 
            // btnDepartmanEkle
            // 
            this.btnDepartmanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanEkle.Location = new System.Drawing.Point(504, 539);
            this.btnDepartmanEkle.Name = "btnDepartmanEkle";
            this.btnDepartmanEkle.Size = new System.Drawing.Size(154, 80);
            this.btnDepartmanEkle.TabIndex = 6;
            this.btnDepartmanEkle.Text = "EKLE";
            this.btnDepartmanEkle.UseVisualStyleBackColor = true;
            this.btnDepartmanEkle.Click += new System.EventHandler(this.btnDepartmanEkle_Click);
            // 
            // txtDepartmanAd
            // 
            this.txtDepartmanAd.Location = new System.Drawing.Point(149, 539);
            this.txtDepartmanAd.Multiline = true;
            this.txtDepartmanAd.Name = "txtDepartmanAd";
            this.txtDepartmanAd.Size = new System.Drawing.Size(163, 37);
            this.txtDepartmanAd.TabIndex = 5;
            // 
            // btnDepartmanAra
            // 
            this.btnDepartmanAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanAra.Location = new System.Drawing.Point(567, 39);
            this.btnDepartmanAra.Name = "btnDepartmanAra";
            this.btnDepartmanAra.Size = new System.Drawing.Size(91, 32);
            this.btnDepartmanAra.TabIndex = 10;
            this.btnDepartmanAra.Text = "ARA";
            this.btnDepartmanAra.UseVisualStyleBackColor = true;
            this.btnDepartmanAra.Click += new System.EventHandler(this.btnDepartmanAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Departman Ara:";
            // 
            // txtDepartmanAra
            // 
            this.txtDepartmanAra.Location = new System.Drawing.Point(170, 39);
            this.txtDepartmanAra.Multiline = true;
            this.txtDepartmanAra.Name = "txtDepartmanAra";
            this.txtDepartmanAra.Size = new System.Drawing.Size(391, 32);
            this.txtDepartmanAra.TabIndex = 8;
            this.txtDepartmanAra.TextChanged += new System.EventHandler(this.txtDepartmanAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefon:";
            // 
            // txtDepartmanTel
            // 
            this.txtDepartmanTel.Location = new System.Drawing.Point(115, 582);
            this.txtDepartmanTel.Multiline = true;
            this.txtDepartmanTel.Name = "txtDepartmanTel";
            this.txtDepartmanTel.Size = new System.Drawing.Size(197, 37);
            this.txtDepartmanTel.TabIndex = 13;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(329, 582);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(169, 28);
            this.cmbDurum.TabIndex = 14;
            // 
            // dataGridViewDepartman
            // 
            this.dataGridViewDepartman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmanAd,
            this.Telefon,
            this.Durum});
            this.dataGridViewDepartman.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewDepartman.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewDepartman.Name = "dataGridViewDepartman";
            this.dataGridViewDepartman.ReadOnly = true;
            this.dataGridViewDepartman.RowTemplate.Height = 28;
            this.dataGridViewDepartman.Size = new System.Drawing.Size(646, 420);
            this.dataGridViewDepartman.TabIndex = 0;
            this.dataGridViewDepartman.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewDepartman_DataError);
            // 
            // DepartmanAd
            // 
            this.DepartmanAd.DataPropertyName = "DepartmanAd";
            this.DepartmanAd.HeaderText = "Departman Adı";
            this.DepartmanAd.Name = "DepartmanAd";
            this.DepartmanAd.ReadOnly = true;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // Durum
            // 
            this.Durum.DataPropertyName = "Durum";
            this.Durum.HeaderText = "Durum";
            this.Durum.Name = "Durum";
            this.Durum.ReadOnly = true;
            this.Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(324, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Durum Seçiniz:";
            // 
            // FrmDepartman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(672, 651);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.txtDepartmanTel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDepartmanAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartmanAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepartmanEkle);
            this.Controls.Add(this.txtDepartmanAd);
            this.Controls.Add(this.dataGridViewDepartman);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Tanımları";
            this.Load += new System.EventHandler(this.FrmDepartman_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepartmanEkle;
        private System.Windows.Forms.TextBox txtDepartmanAd;
        private System.Windows.Forms.Button btnDepartmanAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartmanAra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmanTel;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DataGridView dataGridViewDepartman;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmanAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewComboBoxColumn Durum;
        private System.Windows.Forms.Label label4;
    }
}