namespace FTU_StudentOnlineService
{
    partial class Student_registrationService
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
            this.panel_informationchange = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_chooseService = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_totalAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_informationchange
            // 
            this.panel_informationchange.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel_informationchange.Location = new System.Drawing.Point(12, 109);
            this.panel_informationchange.Name = "panel_informationchange";
            this.panel_informationchange.Size = new System.Drawing.Size(1150, 520);
            this.panel_informationchange.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registration";
            // 
            // cbb_chooseService
            // 
            this.cbb_chooseService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_chooseService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbb_chooseService.ForeColor = System.Drawing.Color.Green;
            this.cbb_chooseService.FormattingEnabled = true;
            this.cbb_chooseService.Items.AddRange(new object[] {
            "Information Change Service",
            "Tuition Reduction Service",
            "Student Confirmation Service"});
            this.cbb_chooseService.Location = new System.Drawing.Point(312, 63);
            this.cbb_chooseService.Name = "cbb_chooseService";
            this.cbb_chooseService.Size = new System.Drawing.Size(260, 24);
            this.cbb_chooseService.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(309, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Service";
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_quantity.ForeColor = System.Drawing.Color.Green;
            this.tb_quantity.Location = new System.Drawing.Point(628, 65);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(144, 22);
            this.tb_quantity.TabIndex = 4;
            // 
            // tb_totalAmount
            // 
            this.tb_totalAmount.Enabled = false;
            this.tb_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tb_totalAmount.ForeColor = System.Drawing.Color.Green;
            this.tb_totalAmount.Location = new System.Drawing.Point(855, 60);
            this.tb_totalAmount.Name = "tb_totalAmount";
            this.tb_totalAmount.ReadOnly = true;
            this.tb_totalAmount.Size = new System.Drawing.Size(51, 22);
            this.tb_totalAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(625, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(852, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(912, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.Orange;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_Ok.Location = new System.Drawing.Point(1095, 43);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 39);
            this.btn_Ok.TabIndex = 9;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // Student_registrationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 628);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_totalAmount);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbb_chooseService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_informationchange);
            this.Name = "Student_registrationService";
            this.Text = "Register Service";
            this.Load += new System.EventHandler(this.Student_registrationService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_informationchange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_chooseService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_totalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Ok;
    }
}