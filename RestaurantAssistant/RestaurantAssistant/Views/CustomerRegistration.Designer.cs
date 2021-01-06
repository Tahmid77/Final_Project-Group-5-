
namespace RestaurantAssistant.Views
{
    partial class CustomerRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(78, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 271);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 20);
            this.tbEmail.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(204, 333);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(120, 59);
            this.buttonAddCustomer.TabIndex = 22;
            this.buttonAddCustomer.Text = "Add ";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(144, 172);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(180, 20);
            this.tbUsername.TabIndex = 26;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(144, 220);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(180, 20);
            this.tbPassword.TabIndex = 28;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(55, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 35);
            this.label5.TabIndex = 31;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(55, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(55, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 118);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 24;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(418, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Name = "CustomerRegistration";
            this.Text = "CustomerRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
    }
}