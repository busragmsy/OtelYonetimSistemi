namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmOda
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
            this.btnOdaAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaGuncelle = new System.Windows.Forms.Button();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.dataGridViewOda = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Durum Seçiniz:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(206, 594);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(196, 28);
            this.cmbDurum.TabIndex = 51;
            // 
            // btnOdaAra
            // 
            this.btnOdaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaAra.Location = new System.Drawing.Point(540, 27);
            this.btnOdaAra.Name = "btnOdaAra";
            this.btnOdaAra.Size = new System.Drawing.Size(175, 32);
            this.btnOdaAra.TabIndex = 49;
            this.btnOdaAra.Text = "ARA";
            this.btnOdaAra.UseVisualStyleBackColor = true;
            this.btnOdaAra.Click += new System.EventHandler(this.btnOdaAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Oda Ara:";
            // 
            // txtOdaAra
            // 
            this.txtOdaAra.Location = new System.Drawing.Point(144, 27);
            this.txtOdaAra.Multiline = true;
            this.txtOdaAra.Name = "txtOdaAra";
            this.txtOdaAra.Size = new System.Drawing.Size(375, 32);
            this.txtOdaAra.TabIndex = 47;
            this.txtOdaAra.TextChanged += new System.EventHandler(this.txtOdaAra_TextChanged);
            this.txtOdaAra.Enter += new System.EventHandler(this.txtOdaAra_Enter);
            this.txtOdaAra.Leave += new System.EventHandler(this.txtOdaAra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "Oda No:";
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaGuncelle.Location = new System.Drawing.Point(444, 537);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(271, 86);
            this.btnOdaGuncelle.TabIndex = 45;
            this.btnOdaGuncelle.Text = "Güncelle";
            this.btnOdaGuncelle.UseVisualStyleBackColor = true;
            this.btnOdaGuncelle.Click += new System.EventHandler(this.btnOdaGuncelle_Click);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(174, 537);
            this.txtOdaNo.Multiline = true;
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(228, 37);
            this.txtOdaNo.TabIndex = 44;
            // 
            // dataGridViewOda
            // 
            this.dataGridViewOda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOda.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewOda.Location = new System.Drawing.Point(29, 85);
            this.dataGridViewOda.Name = "dataGridViewOda";
            this.dataGridViewOda.ReadOnly = true;
            this.dataGridViewOda.RowTemplate.Height = 28;
            this.dataGridViewOda.Size = new System.Drawing.Size(686, 420);
            this.dataGridViewOda.TabIndex = 43;
            this.dataGridViewOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOda_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 34);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // FrmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(746, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.btnOdaAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOdaAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaGuncelle);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.dataGridViewOda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oda Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmOda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnOdaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdaAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaGuncelle;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.DataGridView dataGridViewOda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}