namespace WindowsFormsApp1
{
    partial class MenuItemManager
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
            this.txt_SearchInput = new System.Windows.Forms.TextBox();
            this.btn_SearchByName = new System.Windows.Forms.Button();
            this.btn_SearchByNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ItemNumber = new System.Windows.Forms.TextBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ItemDescription = new System.Windows.Forms.TextBox();
            this.txt_ItemPrice = new System.Windows.Forms.TextBox();
            this.txt_ItemCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchInput
            // 
            this.txt_SearchInput.Location = new System.Drawing.Point(16, 19);
            this.txt_SearchInput.Name = "txt_SearchInput";
            this.txt_SearchInput.Size = new System.Drawing.Size(120, 20);
            this.txt_SearchInput.TabIndex = 1;
            this.txt_SearchInput.Text = "Enter name / number";
            this.txt_SearchInput.Click += new System.EventHandler(this.Txt_SearchInput_Click);
            // 
            // btn_SearchByName
            // 
            this.btn_SearchByName.Location = new System.Drawing.Point(76, 45);
            this.btn_SearchByName.Name = "btn_SearchByName";
            this.btn_SearchByName.Size = new System.Drawing.Size(120, 23);
            this.btn_SearchByName.TabIndex = 2;
            this.btn_SearchByName.Text = "Search by Name";
            this.btn_SearchByName.UseVisualStyleBackColor = true;
            this.btn_SearchByName.Click += new System.EventHandler(this.btn_SearchByName_Click);
            // 
            // btn_SearchByNumber
            // 
            this.btn_SearchByNumber.Location = new System.Drawing.Point(202, 45);
            this.btn_SearchByNumber.Name = "btn_SearchByNumber";
            this.btn_SearchByNumber.Size = new System.Drawing.Size(120, 23);
            this.btn_SearchByNumber.TabIndex = 3;
            this.btn_SearchByNumber.Text = "Search by Number";
            this.btn_SearchByNumber.UseVisualStyleBackColor = true;
            this.btn_SearchByNumber.Click += new System.EventHandler(this.Btn_SearchByNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item Name:";
            // 
            // txt_ItemNumber
            // 
            this.txt_ItemNumber.Location = new System.Drawing.Point(106, 169);
            this.txt_ItemNumber.Name = "txt_ItemNumber";
            this.txt_ItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemNumber.TabIndex = 6;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(106, 195);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Description:";
            // 
            // txt_ItemDescription
            // 
            this.txt_ItemDescription.Location = new System.Drawing.Point(106, 221);
            this.txt_ItemDescription.Name = "txt_ItemDescription";
            this.txt_ItemDescription.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemDescription.TabIndex = 9;
            // 
            // txt_ItemPrice
            // 
            this.txt_ItemPrice.Location = new System.Drawing.Point(106, 247);
            this.txt_ItemPrice.Name = "txt_ItemPrice";
            this.txt_ItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemPrice.TabIndex = 10;
            // 
            // txt_ItemCategory
            // 
            this.txt_ItemCategory.Location = new System.Drawing.Point(106, 273);
            this.txt_ItemCategory.Name = "txt_ItemCategory";
            this.txt_ItemCategory.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemCategory.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Item Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Item Category:";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.Location = new System.Drawing.Point(268, 169);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 37);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.BackColor = System.Drawing.Color.Khaki;
            this.btn_Modify.Location = new System.Drawing.Point(268, 212);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 37);
            this.btn_Modify.TabIndex = 15;
            this.btn_Modify.Text = "MODIFY";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.Btn_Modify_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Delete.Location = new System.Drawing.Point(268, 255);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 37);
            this.btn_Delete.TabIndex = 16;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(16, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Menu Item Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txt_SearchInput);
            this.groupBox1.Controls.Add(this.btn_SearchByName);
            this.groupBox1.Controls.Add(this.btn_SearchByNumber);
            this.groupBox1.Location = new System.Drawing.Point(21, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // MenuItemManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ItemCategory);
            this.Controls.Add(this.txt_ItemPrice);
            this.Controls.Add(this.txt_ItemDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.txt_ItemNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MenuItemManager";
            this.Text = "Menu Item Manager";
            this.Load += new System.EventHandler(this.MenuItemManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SearchInput;
        private System.Windows.Forms.Button btn_SearchByName;
        private System.Windows.Forms.Button btn_SearchByNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ItemNumber;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ItemDescription;
        private System.Windows.Forms.TextBox txt_ItemPrice;
        private System.Windows.Forms.TextBox txt_ItemCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}