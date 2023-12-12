namespace FTU_StudentOnlineService
{
    partial class StudentForm_Home
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_swithView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_registration = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_welcome = new System.Windows.Forms.Label();
            this.panel_home = new System.Windows.Forms.Panel();
            this.btn_transactionHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Exit.Location = new System.Drawing.Point(19, 36);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(143, 41);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.btn_transactionHistory);
            this.panel1.Controls.Add(this.btn_swithView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_registration);
            this.panel1.Location = new System.Drawing.Point(1218, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 783);
            this.panel1.TabIndex = 1;
            // 
            // btn_swithView
            // 
            this.btn_swithView.BackColor = System.Drawing.Color.Orange;
            this.btn_swithView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_swithView.Location = new System.Drawing.Point(61, 433);
            this.btn_swithView.Name = "btn_swithView";
            this.btn_swithView.Size = new System.Drawing.Size(224, 50);
            this.btn_swithView.TabIndex = 5;
            this.btn_swithView.Text = "Swith View";
            this.btn_swithView.UseVisualStyleBackColor = false;
            this.btn_swithView.Enter += new System.EventHandler(this.btn_swithView_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTU_StudentOnlineService.Properties.Resources.Logo_Dai_hoc_FPT1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_registration
            // 
            this.btn_registration.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_registration.Location = new System.Drawing.Point(61, 289);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(224, 50);
            this.btn_registration.TabIndex = 1;
            this.btn_registration.Text = "Registration";
            this.btn_registration.UseVisualStyleBackColor = false;
            this.btn_registration.Enter += new System.EventHandler(this.btn_registration_Enter);
            this.btn_registration.Leave += new System.EventHandler(this.btn_registration_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.txt_welcome);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 103);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_welcome
            // 
            this.txt_welcome.AutoSize = true;
            this.txt_welcome.Location = new System.Drawing.Point(194, 49);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(65, 16);
            this.txt_welcome.TabIndex = 1;
            this.txt_welcome.Text = "Welcome";
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.Green;
            this.panel_home.Location = new System.Drawing.Point(12, 121);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(1200, 675);
            this.panel_home.TabIndex = 3;
            // 
            // btn_transactionHistory
            // 
            this.btn_transactionHistory.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_transactionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_transactionHistory.Location = new System.Drawing.Point(61, 359);
            this.btn_transactionHistory.Name = "btn_transactionHistory";
            this.btn_transactionHistory.Size = new System.Drawing.Size(224, 50);
            this.btn_transactionHistory.TabIndex = 6;
            this.btn_transactionHistory.Text = "Service Transaction History";
            this.btn_transactionHistory.UseVisualStyleBackColor = false;
            this.btn_transactionHistory.Enter += new System.EventHandler(this.btn_transactionHistory_Enter);
            this.btn_transactionHistory.Leave += new System.EventHandler(this.btn_transactionHistory_Leave);
            // 
            // StudentForm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.panel_home);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm_Home";
            this.Text = "StudentForm_Home";
            this.Load += new System.EventHandler(this.StudentForm_Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.Button btn_swithView;
        private System.Windows.Forms.Button btn_transactionHistory;
    }
}