namespace otelYonetimFinal.Formlar.Rezervasyonlar
{
    partial class FrmTumRezervasyonListesi
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
            this.dataGridViewRezervasyon = new System.Windows.Forms.DataGridView();
            this.contextMenuRezervasyon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).BeginInit();
            this.contextMenuRezervasyon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRezervasyon
            // 
            this.dataGridViewRezervasyon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervasyon.ContextMenuStrip = this.contextMenuRezervasyon;
            this.dataGridViewRezervasyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRezervasyon.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRezervasyon.Name = "dataGridViewRezervasyon";
            this.dataGridViewRezervasyon.RowTemplate.Height = 28;
            this.dataGridViewRezervasyon.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewRezervasyon.TabIndex = 2;
            // 
            // contextMenuRezervasyon
            // 
            this.contextMenuRezervasyon.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuRezervasyon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSil,
            this.menuItemGuncelle});
            this.contextMenuRezervasyon.Name = "contextMenuPersonel";
            this.contextMenuRezervasyon.Size = new System.Drawing.Size(151, 64);
            // 
            // menuItemSil
            // 
            this.menuItemSil.Name = "menuItemSil";
            this.menuItemSil.Size = new System.Drawing.Size(150, 30);
            this.menuItemSil.Text = "Sil";
            this.menuItemSil.Click += new System.EventHandler(this.menuItemSil_Click);
            // 
            // menuItemGuncelle
            // 
            this.menuItemGuncelle.Name = "menuItemGuncelle";
            this.menuItemGuncelle.Size = new System.Drawing.Size(150, 30);
            this.menuItemGuncelle.Text = "Güncelle";
            this.menuItemGuncelle.Click += new System.EventHandler(this.menuItemGuncelle_Click);
            // 
            // FrmTumRezervasyonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRezervasyon);
            this.Name = "FrmTumRezervasyonListesi";
            this.Text = "Tüm Rezervasyonlar Tablosu";
            this.Load += new System.EventHandler(this.FrmTumRezervasyonListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).EndInit();
            this.contextMenuRezervasyon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervasyon;
        private System.Windows.Forms.ContextMenuStrip contextMenuRezervasyon;
        private System.Windows.Forms.ToolStripMenuItem menuItemSil;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuncelle;
    }
}