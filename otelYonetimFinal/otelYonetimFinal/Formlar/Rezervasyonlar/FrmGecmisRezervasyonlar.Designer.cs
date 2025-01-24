namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    partial class FrmGecmisRezervasyonlar
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
            this.dgvGecmisRez = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisRez)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGecmisRez
            // 
            this.dgvGecmisRez.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGecmisRez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGecmisRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecmisRez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGecmisRez.Location = new System.Drawing.Point(0, 0);
            this.dgvGecmisRez.Name = "dgvGecmisRez";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGecmisRez.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGecmisRez.RowTemplate.Height = 28;
            this.dgvGecmisRez.Size = new System.Drawing.Size(800, 450);
            this.dgvGecmisRez.TabIndex = 1;
            // 
            // FrmGecmisRezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGecmisRez);
            this.Name = "FrmGecmisRezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geçmiş Rezervasyonlar";
            this.Load += new System.EventHandler(this.FrmGecmisRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecmisRez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGecmisRez;
    }
}