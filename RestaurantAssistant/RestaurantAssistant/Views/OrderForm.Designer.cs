
namespace RestaurantAssistant.Views
{
    partial class OrderForm
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
            this.label14 = new System.Windows.Forms.Label();
            this.GridFoodItem = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbItem1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItem2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridFoodItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(459, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 35);
            this.label14.TabIndex = 31;
            this.label14.Text = "Food Menu";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridFoodItem
            // 
            this.GridFoodItem.BackgroundColor = System.Drawing.Color.Black;
            this.GridFoodItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFoodItem.Location = new System.Drawing.Point(366, 58);
            this.GridFoodItem.Name = "GridFoodItem";
            this.GridFoodItem.Size = new System.Drawing.Size(352, 574);
            this.GridFoodItem.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(247, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.Location = new System.Drawing.Point(142, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Confirm";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbItem1
            // 
            this.tbItem1.Location = new System.Drawing.Point(142, 85);
            this.tbItem1.Name = "tbItem1";
            this.tbItem1.Size = new System.Drawing.Size(180, 20);
            this.tbItem1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 30);
            this.label1.TabIndex = 38;
            this.label1.Text = "Item 1 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 40;
            this.label2.Text = "Item 2 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbItem2
            // 
            this.tbItem2.Location = new System.Drawing.Point(142, 138);
            this.tbItem2.Name = "tbItem2";
            this.tbItem2.Size = new System.Drawing.Size(180, 20);
            this.tbItem2.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(145, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "ID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(179, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 47;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(770, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItem2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbItem1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GridFoodItem);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridFoodItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView GridFoodItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItem2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}