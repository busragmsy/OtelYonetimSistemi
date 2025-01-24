namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    partial class FrmGelecekRezervasyonlar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGelecekRez = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelecekRez)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGelecekRez
            // 
            this.dgvGelecekRez.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGelecekRez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGelecekRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGelecekRez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGelecekRez.Location = new System.Drawing.Point(0, 0);
            this.dgvGelecekRez.Name = "dgvGelecekRez";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvGelecekRez.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGelecekRez.RowTemplate.Height = 28;
            this.dgvGelecekRez.Size = new System.Drawing.Size(800, 450);
            this.dgvGelecekRez.TabIndex = 0;
            // 
            // FrmGelecekRezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGelecekRez);
            this.Name = "FrmGelecekRezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gelecek Rezervasyonlar";
            this.Load += new System.EventHandler(this.FrmGelecekRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelecekRez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGelecekRez;
    }
}