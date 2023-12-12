namespace FTU_StudentOnlineService
{
    partial class MiniForm_Home
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
            this.Home_textContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home_textContent
            // 
            this.Home_textContent.AutoSize = true;
            this.Home_textContent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Home_textContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Home_textContent.ForeColor = System.Drawing.Color.Green;
            this.Home_textContent.Location = new System.Drawing.Point(12, 9);
            this.Home_textContent.Name = "Home_textContent";
            this.Home_textContent.Size = new System.Drawing.Size(378, 91);
            this.Home_textContent.TabIndex = 1;
            this.Home_textContent.Text = "Welcome";
            // 
            // MiniForm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 883);
            this.Controls.Add(this.Home_textContent);
            this.Name = "MiniForm_Home";
            this.Text = "MiniForm_Home";
            this.Load += new System.EventHandler(this.MiniForm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Home_textContent;
    }
}