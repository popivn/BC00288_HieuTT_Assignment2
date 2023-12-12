namespace FTU_StudentOnlineService
{
    partial class RepositoryService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_serviceID = new System.Windows.Forms.TextBox();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.tb_totalAmount = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tb_departmentID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.table_repositoryService = new System.Windows.Forms.DataGridView();
            this.cbb_status = new System.Windows.Forms.ComboBox();
            this.cbb_search = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_servicetypeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_repositoryService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Repository";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Information";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Orange;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_save.Location = new System.Drawing.Point(888, 328);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 31);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_serviceID
            // 
            this.tb_serviceID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_serviceID.Enabled = false;
            this.tb_serviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_serviceID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_serviceID.Location = new System.Drawing.Point(17, 279);
            this.tb_serviceID.Name = "tb_serviceID";
            this.tb_serviceID.Size = new System.Drawing.Size(283, 27);
            this.tb_serviceID.TabIndex = 7;
            // 
            // tb_userID
            // 
            this.tb_userID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_userID.Enabled = false;
            this.tb_userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_userID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_userID.Location = new System.Drawing.Point(306, 281);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(284, 27);
            this.tb_userID.TabIndex = 8;
            // 
            // tb_totalAmount
            // 
            this.tb_totalAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_totalAmount.Enabled = false;
            this.tb_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_totalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_totalAmount.Location = new System.Drawing.Point(17, 330);
            this.tb_totalAmount.Name = "tb_totalAmount";
            this.tb_totalAmount.Size = new System.Drawing.Size(283, 27);
            this.tb_totalAmount.TabIndex = 10;
            // 
            // tb_quantity
            // 
            this.tb_quantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_quantity.Enabled = false;
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_quantity.Location = new System.Drawing.Point(306, 331);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(284, 27);
            this.tb_quantity.TabIndex = 11;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_search.Location = new System.Drawing.Point(941, 164);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(191, 27);
            this.tb_search.TabIndex = 13;
            // 
            // tb_departmentID
            // 
            this.tb_departmentID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_departmentID.Enabled = false;
            this.tb_departmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_departmentID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_departmentID.Location = new System.Drawing.Point(888, 279);
            this.tb_departmentID.Name = "tb_departmentID";
            this.tb_departmentID.Size = new System.Drawing.Size(283, 27);
            this.tb_departmentID.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button2.Location = new System.Drawing.Point(1124, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Service Repository List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Service ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(303, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "User ID - Name User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(593, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Service Type ID - Name Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(888, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Department ID - Name Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(14, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(303, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(593, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Status";
            // 
            // table_repositoryService
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.table_repositoryService.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.table_repositoryService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_repositoryService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_repositoryService.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.table_repositoryService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_repositoryService.DefaultCellStyle = dataGridViewCellStyle5;
            this.table_repositoryService.Location = new System.Drawing.Point(17, 400);
            this.table_repositoryService.Name = "table_repositoryService";
            this.table_repositoryService.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_repositoryService.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.table_repositoryService.RowHeadersVisible = false;
            this.table_repositoryService.RowHeadersWidth = 51;
            this.table_repositoryService.RowTemplate.Height = 24;
            this.table_repositoryService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_repositoryService.Size = new System.Drawing.Size(1211, 327);
            this.table_repositoryService.TabIndex = 51;
            this.table_repositoryService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_repositoryService_CellClick);
            // 
            // cbb_status
            // 
            this.cbb_status.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.cbb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbb_status.ForeColor = System.Drawing.Color.DarkGreen;
            this.cbb_status.FormattingEnabled = true;
            this.cbb_status.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Rejected"});
            this.cbb_status.Location = new System.Drawing.Point(596, 330);
            this.cbb_status.Name = "cbb_status";
            this.cbb_status.Size = new System.Drawing.Size(283, 28);
            this.cbb_status.TabIndex = 52;
            // 
            // cbb_search
            // 
            this.cbb_search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbb_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbb_search.FormattingEnabled = true;
            this.cbb_search.Items.AddRange(new object[] {
            "Search by UserID"});
            this.cbb_search.Location = new System.Drawing.Point(941, 206);
            this.cbb_search.Name = "cbb_search";
            this.cbb_search.Size = new System.Drawing.Size(191, 28);
            this.cbb_search.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTU_StudentOnlineService.Properties.Resources.Lookup;
            this.pictureBox1.Location = new System.Drawing.Point(1144, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_servicetypeID
            // 
            this.tb_servicetypeID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_servicetypeID.Enabled = false;
            this.tb_servicetypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_servicetypeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_servicetypeID.Location = new System.Drawing.Point(596, 281);
            this.tb_servicetypeID.Name = "tb_servicetypeID";
            this.tb_servicetypeID.Size = new System.Drawing.Size(283, 27);
            this.tb_servicetypeID.TabIndex = 9;
            // 
            // RepositoryService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1197, 883);
            this.Controls.Add(this.cbb_search);
            this.Controls.Add(this.cbb_status);
            this.Controls.Add(this.table_repositoryService);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_departmentID);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.tb_totalAmount);
            this.Controls.Add(this.tb_servicetypeID);
            this.Controls.Add(this.tb_userID);
            this.Controls.Add(this.tb_serviceID);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "RepositoryService";
            this.Text = "RepositoryService";
            this.Load += new System.EventHandler(this.RepositoryService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_repositoryService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_serviceID;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.TextBox tb_totalAmount;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_departmentID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView table_repositoryService;
        private System.Windows.Forms.ComboBox cbb_status;
        private System.Windows.Forms.ComboBox cbb_search;
        private System.Windows.Forms.TextBox tb_servicetypeID;
    }
}