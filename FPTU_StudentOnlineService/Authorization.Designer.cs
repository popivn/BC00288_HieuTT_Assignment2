namespace FTU_StudentOnlineService
{
    partial class Authorization
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.table_adminList = new System.Windows.Forms.DataGridView();
            this.table_studentList = new System.Windows.Forms.DataGridView();
            this.tb_adminRefresh = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tb_adminSearch = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ptb_admin = new System.Windows.Forms.PictureBox();
            this.ptb_student = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userID = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_permission = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_adminList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_studentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_student)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(242, -8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authorization";
            // 
            // table_adminList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.table_adminList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_adminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_adminList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_adminList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.table_adminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_adminList.Location = new System.Drawing.Point(10, 228);
            this.table_adminList.Margin = new System.Windows.Forms.Padding(2);
            this.table_adminList.Name = "table_adminList";
            this.table_adminList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_adminList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_adminList.RowHeadersVisible = false;
            this.table_adminList.RowHeadersWidth = 51;
            this.table_adminList.RowTemplate.Height = 24;
            this.table_adminList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_adminList.Size = new System.Drawing.Size(459, 469);
            this.table_adminList.TabIndex = 122;
            this.table_adminList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_adminList_CellClick);
            // 
            // table_studentList
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.table_studentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.table_studentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_studentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.table_studentList.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.table_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_studentList.Location = new System.Drawing.Point(473, 226);
            this.table_studentList.Margin = new System.Windows.Forms.Padding(2);
            this.table_studentList.Name = "table_studentList";
            this.table_studentList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_studentList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table_studentList.RowHeadersVisible = false;
            this.table_studentList.RowHeadersWidth = 51;
            this.table_studentList.RowTemplate.Height = 24;
            this.table_studentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_studentList.Size = new System.Drawing.Size(446, 469);
            this.table_studentList.TabIndex = 123;
            this.table_studentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_studentList_CellClick);
            // 
            // tb_adminRefresh
            // 
            this.tb_adminRefresh.BackColor = System.Drawing.Color.Orange;
            this.tb_adminRefresh.Location = new System.Drawing.Point(357, 191);
            this.tb_adminRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.tb_adminRefresh.Name = "tb_adminRefresh";
            this.tb_adminRefresh.Size = new System.Drawing.Size(112, 30);
            this.tb_adminRefresh.TabIndex = 124;
            this.tb_adminRefresh.Text = "Refresh";
            this.tb_adminRefresh.UseVisualStyleBackColor = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Orange;
            this.btn_refresh.Location = new System.Drawing.Point(807, 189);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(112, 30);
            this.btn_refresh.TabIndex = 125;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // tb_adminSearch
            // 
            this.tb_adminSearch.Location = new System.Drawing.Point(225, 196);
            this.tb_adminSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tb_adminSearch.Name = "tb_adminSearch";
            this.tb_adminSearch.Size = new System.Drawing.Size(130, 22);
            this.tb_adminSearch.TabIndex = 126;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(673, 194);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 22);
            this.textBox2.TabIndex = 127;
            // 
            // ptb_admin
            // 
            this.ptb_admin.Image = global::FTU_StudentOnlineService.Properties.Resources.Lookup;
            this.ptb_admin.Location = new System.Drawing.Point(194, 196);
            this.ptb_admin.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_admin.Name = "ptb_admin";
            this.ptb_admin.Size = new System.Drawing.Size(25, 22);
            this.ptb_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_admin.TabIndex = 128;
            this.ptb_admin.TabStop = false;
            // 
            // ptb_student
            // 
            this.ptb_student.Image = global::FTU_StudentOnlineService.Properties.Resources.Lookup;
            this.ptb_student.Location = new System.Drawing.Point(643, 194);
            this.ptb_student.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_student.Name = "ptb_student";
            this.ptb_student.Size = new System.Drawing.Size(25, 22);
            this.ptb_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_student.TabIndex = 129;
            this.ptb_student.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(467, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 131;
            this.label3.Text = "Student List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(4, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 130;
            this.label2.Text = "Admin List";
            // 
            // tb_userID
            // 
            this.tb_userID.Location = new System.Drawing.Point(231, 124);
            this.tb_userID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_userID.Name = "tb_userID";
            this.tb_userID.Size = new System.Drawing.Size(136, 22);
            this.tb_userID.TabIndex = 132;
            this.tb_userID.TextChanged += new System.EventHandler(this.tb_userID_TextChanged);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(392, 124);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(136, 22);
            this.tb_name.TabIndex = 133;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 135;
            this.label4.Text = "UserID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 136;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 137;
            this.label6.Text = "Permission";
            // 
            // cbb_permission
            // 
            this.cbb_permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_permission.FormattingEnabled = true;
            this.cbb_permission.Location = new System.Drawing.Point(555, 122);
            this.cbb_permission.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_permission.Name = "cbb_permission";
            this.cbb_permission.Size = new System.Drawing.Size(135, 24);
            this.cbb_permission.TabIndex = 140;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Orange;
            this.btn_save.Location = new System.Drawing.Point(694, 120);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 26);
            this.btn_save.TabIndex = 141;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(979, 706);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbb_permission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_userID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptb_student);
            this.Controls.Add(this.ptb_admin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_adminSearch);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.tb_adminRefresh);
            this.Controls.Add(this.table_studentList);
            this.Controls.Add(this.table_adminList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_adminList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_studentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table_adminList;
        private System.Windows.Forms.DataGridView table_studentList;
        private System.Windows.Forms.Button tb_adminRefresh;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox tb_adminSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox ptb_admin;
        private System.Windows.Forms.PictureBox ptb_student;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userID;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_permission;
        private System.Windows.Forms.Button btn_save;
    }
}