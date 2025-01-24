namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    partial class FrmIptalEdilenRezervasyonlar
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
            this.dgvIptalRez = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptalRez)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIptalRez
            // 
            this.dgvIptalRez.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIptalRez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIptalRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIptalRez.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIptalRez.Location = new System.Drawing.Point(0, 0);
            this.dgvIptalRez.Name = "dgvIptalRez";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            this.dgvIptalRez.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIptalRez.RowTemplate.Height = 28;
            this.dgvIptalRez.Size = new System.Drawing.Size(800, 450);
            this.dgvIptalRez.TabIndex = 2;
            // 
            // FrmIptalEdilenRezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIptalRez);
            this.Name = "FrmIptalEdilenRezervasyonlar";
            this.Text = "İptal Edilen Rezervasyonlar";
            this.Load += new System.EventHandler(this.FrmIptalEdilenRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIptalRez)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIptalRez;
    }
}