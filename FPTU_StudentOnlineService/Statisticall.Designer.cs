namespace FTU_StudentOnlineService
{
    partial class Statisticall
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.mintab_genneral = new System.Windows.Forms.TabPage();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.table_statisticalSum = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.pchart_statistical = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mintab_genneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_statisticalSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchart_statistical)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(436, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistical";
            // 
            // mintab_genneral
            // 
            this.mintab_genneral.BackColor = System.Drawing.Color.DarkOrange;
            this.mintab_genneral.Controls.Add(this.cbb_month);
            this.mintab_genneral.Controls.Add(this.table_statisticalSum);
            this.mintab_genneral.Controls.Add(this.btn_refresh);
            this.mintab_genneral.Controls.Add(this.btn_export);
            this.mintab_genneral.Controls.Add(this.pchart_statistical);
            this.mintab_genneral.Controls.Add(this.label2);
            this.mintab_genneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.mintab_genneral.Location = new System.Drawing.Point(4, 25);
            this.mintab_genneral.Name = "mintab_genneral";
            this.mintab_genneral.Padding = new System.Windows.Forms.Padding(3);
            this.mintab_genneral.Size = new System.Drawing.Size(1211, 737);
            this.mintab_genneral.TabIndex = 1;
            this.mintab_genneral.Text = "Genneral";
            // 
            // cbb_month
            // 
            this.cbb_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(10, 90);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(144, 28);
            this.cbb_month.TabIndex = 127;
            this.cbb_month.SelectedIndexChanged += new System.EventHandler(this.cbb_month_SelectedIndexChanged);
            // 
            // table_statisticalSum
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.table_statisticalSum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_statisticalSum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_statisticalSum.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_statisticalSum.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.table_statisticalSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_statisticalSum.Location = new System.Drawing.Point(3, 128);
            this.table_statisticalSum.Name = "table_statisticalSum";
            this.table_statisticalSum.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_statisticalSum.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_statisticalSum.RowHeadersVisible = false;
            this.table_statisticalSum.RowHeadersWidth = 51;
            this.table_statisticalSum.RowTemplate.Height = 24;
            this.table_statisticalSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_statisticalSum.Size = new System.Drawing.Size(707, 603);
            this.table_statisticalSum.TabIndex = 125;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_refresh.Location = new System.Drawing.Point(606, 85);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(104, 37);
            this.btn_refresh.TabIndex = 124;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_export.Location = new System.Drawing.Point(481, 85);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(104, 37);
            this.btn_export.TabIndex = 123;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = false;
            // 
            // pchart_statistical
            // 
            chartArea1.Name = "ChartArea1";
            this.pchart_statistical.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pchart_statistical.Legends.Add(legend1);
            this.pchart_statistical.Location = new System.Drawing.Point(721, 0);
            this.pchart_statistical.Name = "pchart_statistical";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Quantity";
            this.pchart_statistical.Series.Add(series1);
            this.pchart_statistical.Size = new System.Drawing.Size(487, 729);
            this.pchart_statistical.TabIndex = 122;
            this.pchart_statistical.Text = "General Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Overview statistis of each services used in the past months";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mintab_genneral);
            this.tabControl1.Location = new System.Drawing.Point(2, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 766);
            this.tabControl1.TabIndex = 0;
            // 
            // Statisticall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1197, 883);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statisticall";
            this.Text = "Statisticall";
            this.Load += new System.EventHandler(this.Statisticall_Load);
            this.mintab_genneral.ResumeLayout(false);
            this.mintab_genneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_statisticalSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchart_statistical)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage mintab_genneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pchart_statistical;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridView table_statisticalSum;
        private System.Windows.Forms.ComboBox cbb_month;
    }
}