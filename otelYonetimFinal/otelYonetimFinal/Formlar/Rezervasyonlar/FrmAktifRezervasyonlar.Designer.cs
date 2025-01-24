namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    partial class FrmAktifRezervasyonlar
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
            this.dgvAktifRez = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifRez)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAktifRez
            // 
            this.dgvAktifRez.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktifRez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAktifRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifRez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktifRez.Location = new System.Drawing.Point(0, 0);
            this.dgvAktifRez.Name = "dgvAktifRez";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            this.dgvAktifRez.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAktifRez.RowTemplate.Height = 28;
            this.dgvAktifRez.Size = new System.Drawing.Size(800, 450);
            this.dgvAktifRez.TabIndex = 2;
            this.dgvAktifRez.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktifRez_CellContentClick);
            // 
            // FrmAktifRezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAktifRez);
            this.Name = "FrmAktifRezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktif Rezervasyonlar";
            this.Load += new System.EventHandler(this.FrmAktifRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifRez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAktifRez;
    }
}