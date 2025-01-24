namespace otelYonetimFinal.Formlar.AnaSayfa
{
    partial class FrmAnaSayfa
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMisafir = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOda = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chartControlRezervasyon = new DevExpress.XtraCharts.ChartControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chartControlOda = new DevExpress.XtraCharts.ChartControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafir)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOda)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlRezervasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlOda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMisafir);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bugün Gelecek Misafirler";
            // 
            // dgvMisafir
            // 
            this.dgvMisafir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisafir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMisafir.Location = new System.Drawing.Point(3, 22);
            this.dgvMisafir.Name = "dgvMisafir";
            this.dgvMisafir.RowTemplate.Height = 28;
            this.dgvMisafir.Size = new System.Drawing.Size(776, 273);
            this.dgvMisafir.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOda);
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Boş odalar Listesi";
            // 
            // dgvOda
            // 
            this.dgvOda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOda.Location = new System.Drawing.Point(3, 22);
            this.dgvOda.Name = "dgvOda";
            this.dgvOda.Size = new System.Drawing.Size(773, 262);
            this.dgvOda.TabIndex = 1;
            this.dgvOda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOda_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chartControlRezervasyon);
            this.groupBox3.Location = new System.Drawing.Point(800, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezervasyon Grafiği";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chartControlRezervasyon
            // 
            this.chartControlRezervasyon.BackColor = System.Drawing.Color.Bisque;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlRezervasyon.Diagram = xyDiagram1;
            this.chartControlRezervasyon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlRezervasyon.IndicatorsPaletteName = "Module";
            this.chartControlRezervasyon.Location = new System.Drawing.Point(3, 22);
            this.chartControlRezervasyon.Name = "chartControlRezervasyon";
            this.chartControlRezervasyon.PaletteName = "Apex";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            this.chartControlRezervasyon.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlRezervasyon.Size = new System.Drawing.Size(680, 273);
            this.chartControlRezervasyon.TabIndex = 0;
            this.chartControlRezervasyon.Click += new System.EventHandler(this.chartControlRezervasyon_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chartControlOda);
            this.groupBox4.Location = new System.Drawing.Point(800, 313);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(689, 290);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Oda Doluluk Oranı";
            // 
            // chartControlOda
            // 
            this.chartControlOda.BackColor = System.Drawing.Color.SlateGray;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.chartControlOda.Diagram = simpleDiagram3D1;
            this.chartControlOda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlOda.IndicatorsPaletteName = "Equity";
            this.chartControlOda.Location = new System.Drawing.Point(3, 22);
            this.chartControlOda.Name = "chartControlOda";
            this.chartControlOda.PaletteName = "Equity";
            series2.Name = "Series 1";
            series2.SeriesID = 0;
            series2.View = pie3DSeriesView1;
            this.chartControlOda.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlOda.Size = new System.Drawing.Size(683, 265);
            this.chartControlOda.TabIndex = 0;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1484, 623);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisafir)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlRezervasyon)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlOda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraCharts.ChartControl chartControlRezervasyon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvMisafir;
        private System.Windows.Forms.DataGridView dgvOda;
        private DevExpress.XtraCharts.ChartControl chartControlOda;
    }
}