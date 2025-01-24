namespace otelYonetimFinal.Formlar.Personel
{
    partial class FrmPersonelListesi
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
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.contextMenuPersonel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.contextMenuPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.ContextMenuStrip = this.contextMenuPersonel;
            this.dataGridViewPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.RowTemplate.Height = 28;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(705, 600);
            this.dataGridViewPersonel.TabIndex = 0;
            this.dataGridViewPersonel.DoubleClick += new System.EventHandler(this.dataGridViewPersonel_DoubleClick);
            // 
            // contextMenuPersonel
            // 
            this.contextMenuPersonel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuPersonel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSil,
            this.menuItemGuncelle});
            this.contextMenuPersonel.Name = "contextMenuPersonel";
            this.contextMenuPersonel.Size = new System.Drawing.Size(151, 64);
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
            // FrmPersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 600);
            this.ContextMenuStrip = this.contextMenuPersonel;
            this.Controls.Add(this.dataGridViewPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonelListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.FrmPersonelListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.contextMenuPersonel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.ContextMenuStrip contextMenuPersonel;
        private System.Windows.Forms.ToolStripMenuItem menuItemSil;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuncelle;
    }
}