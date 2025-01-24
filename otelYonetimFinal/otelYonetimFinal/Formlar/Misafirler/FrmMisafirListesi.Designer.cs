namespace otelYonetimFinal.Formlar.Misafirler
{
    partial class FrmMisafirListesi
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
            this.dataGridViewMisafir = new System.Windows.Forms.DataGridView();
            this.contextMenuMisafir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSil = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisafir)).BeginInit();
            this.contextMenuMisafir.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMisafir
            // 
            this.dataGridViewMisafir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMisafir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMisafir.ContextMenuStrip = this.contextMenuMisafir;
            this.dataGridViewMisafir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMisafir.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMisafir.Name = "dataGridViewMisafir";
            this.dataGridViewMisafir.RowTemplate.Height = 28;
            this.dataGridViewMisafir.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewMisafir.TabIndex = 1;
            this.dataGridViewMisafir.DoubleClick += new System.EventHandler(this.dataGridViewMisafir_DoubleClick);
            // 
            // contextMenuMisafir
            // 
            this.contextMenuMisafir.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuMisafir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSil,
            this.menuItemGuncelle});
            this.contextMenuMisafir.Name = "contextMenuPersonel";
            this.contextMenuMisafir.Size = new System.Drawing.Size(151, 64);
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
            // FrmMisafirListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMisafir);
            this.Name = "FrmMisafirListesi";
            this.Text = "Misafir Listesi";
            this.Load += new System.EventHandler(this.FrmMisafirListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMisafir)).EndInit();
            this.contextMenuMisafir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMisafir;
        private System.Windows.Forms.ContextMenuStrip contextMenuMisafir;
        private System.Windows.Forms.ToolStripMenuItem menuItemSil;
        private System.Windows.Forms.ToolStripMenuItem menuItemGuncelle;
    }
}