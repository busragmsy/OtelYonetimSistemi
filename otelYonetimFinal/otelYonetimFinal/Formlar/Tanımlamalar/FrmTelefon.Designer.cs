namespace otelYonetimFinal.Formlar.Tanımlamalar
{
    partial class FrmTelefon
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
            this.btnTelefonAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefonAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTelefonEkle = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.dataGridViewTelefon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTelefonAra
            // 
            this.btnTelefonAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTelefonAra.Location = new System.Drawing.Point(562, 30);
            this.btnTelefonAra.Name = "btnTelefonAra";
            this.btnTelefonAra.Size = new System.Drawing.Size(92, 32);
            this.btnTelefonAra.TabIndex = 14;
            this.btnTelefonAra.Text = "ARA";
            this.btnTelefonAra.UseVisualStyleBackColor = true;
            this.btnTelefonAra.Click += new System.EventHandler(this.btnTelefonAra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Telefon Ara:";
            // 
            // txtTelefonAra
            // 
            this.txtTelefonAra.Location = new System.Drawing.Point(157, 30);
            this.txtTelefonAra.Multiline = true;
            this.txtTelefonAra.Name = "txtTelefonAra";
            this.txtTelefonAra.Size = new System.Drawing.Size(393, 32);
            this.txtTelefonAra.TabIndex = 12;
            this.txtTelefonAra.TextChanged += new System.EventHandler(this.txtTelefonAra_TextChanged);
            this.txtTelefonAra.Enter += new System.EventHandler(this.txtTelefonAra_Enter);
            this.txtTelefonAra.Leave += new System.EventHandler(this.txtTelefonAra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Açıklama:";
            // 
            // btnTelefonEkle
            // 
            this.btnTelefonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTelefonEkle.Location = new System.Drawing.Point(496, 471);
            this.btnTelefonEkle.Name = "btnTelefonEkle";
            this.btnTelefonEkle.Size = new System.Drawing.Size(158, 99);
            this.btnTelefonEkle.TabIndex = 10;
            this.btnTelefonEkle.Text = "EKLE";
            this.btnTelefonEkle.UseVisualStyleBackColor = true;
            this.btnTelefonEkle.Click += new System.EventHandler(this.btnTelefonEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(238, 525);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(237, 45);
            this.txtTelefon.TabIndex = 9;
            // 
            // dataGridViewTelefon
            // 
            this.dataGridViewTelefon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTelefon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefon.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTelefon.Location = new System.Drawing.Point(30, 85);
            this.dataGridViewTelefon.Name = "dataGridViewTelefon";
            this.dataGridViewTelefon.ReadOnly = true;
            this.dataGridViewTelefon.RowTemplate.Height = 28;
            this.dataGridViewTelefon.Size = new System.Drawing.Size(624, 355);
            this.dataGridViewTelefon.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.guncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 64);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefon numarası:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(157, 471);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(318, 45);
            this.txtAciklama.TabIndex = 17;
            // 
            // FrmTelefon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(679, 582);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTelefonAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefonAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelefonEkle);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.dataGridViewTelefon);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelefon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefon Tanımlamaları";
            this.Load += new System.EventHandler(this.FrmTelefon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelefonAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefonAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTelefonEkle;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.DataGridView dataGridViewTelefon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
    }
}