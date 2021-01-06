
namespace RestaurantAssistant.Views
{
    partial class OfferCRUDForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.tbP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridFoodItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(803, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(193, 57);
            this.label14.TabIndex = 33;
            this.label14.Text = "Discount Offers";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridFoodItem
            // 
            this.GridFoodItem.BackgroundColor = System.Drawing.Color.Black;
            this.GridFoodItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFoodItem.Location = new System.Drawing.Point(759, 79);
            this.GridFoodItem.Name = "GridFoodItem";
            this.GridFoodItem.Size = new System.Drawing.Size(333, 546);
            this.GridFoodItem.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.SearchButton);
            this.groupBox2.Controls.Add(this.tbSearch);
            this.groupBox2.Controls.Add(this.DeleteButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UpdateButton);
            this.groupBox2.Controls.Add(this.tbP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbN);
            this.groupBox2.Location = new System.Drawing.Point(397, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 616);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(117, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(28, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 35);
            this.label13.TabIndex = 25;
            this.label13.Text = "ID:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Pink;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(229, 86);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(84, 42);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(31, 100);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(180, 20);
            this.tbSearch.TabIndex = 23;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(42, 409);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(120, 59);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(51, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 57);
            this.label7.TabIndex = 11;
            this.label7.Text = "Update/Delete Offer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(28, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 35);
            this.label9.TabIndex = 13;
            this.label9.Text = "Name:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(177, 409);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(120, 59);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(117, 261);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(180, 20);
            this.tbP.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(28, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 35);
            this.label12.TabIndex = 15;
            this.label12.Text = "Price:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(117, 217);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(180, 20);
            this.tbN.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(29, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 616);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Offer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(177, 373);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 59);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(117, 162);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(180, 20);
            this.tbPrice.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(117, 108);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 20);
            this.tbName.TabIndex = 12;
            // 
            // OfferCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1120, 634);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GridFoodItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OfferCRUDForm";
            this.Text = "OfferCRUDForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridFoodItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView GridFoodItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
    }
}