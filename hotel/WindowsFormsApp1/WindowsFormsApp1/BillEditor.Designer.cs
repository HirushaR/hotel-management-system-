namespace WindowsFormsApp1
{
    partial class BillEditor
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
            this.lbl_RoomNumber = new System.Windows.Forms.Label();
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.txt_RoomNumberInput = new System.Windows.Forms.TextBox();
            this.btn_Room = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ItemNumberInput = new System.Windows.Forms.TextBox();
            this.txt_QuantityInput = new System.Windows.Forms.TextBox();
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_ItemNumber = new System.Windows.Forms.Label();
            this.lbl_ItemPrice = new System.Windows.Forms.Label();
            this.lbl_ItemTotal = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dataGridView_Bill = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNumber.Location = new System.Drawing.Point(12, 9);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(0, 25);
            this.lbl_RoomNumber.TabIndex = 0;
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(13, 34);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(0, 24);
            this.lbl_CustomerName.TabIndex = 1;
            // 
            // txt_RoomNumberInput
            // 
            this.txt_RoomNumberInput.Location = new System.Drawing.Point(6, 19);
            this.txt_RoomNumberInput.Name = "txt_RoomNumberInput";
            this.txt_RoomNumberInput.Size = new System.Drawing.Size(39, 20);
            this.txt_RoomNumberInput.TabIndex = 2;
            // 
            // btn_Room
            // 
            this.btn_Room.Location = new System.Drawing.Point(58, 19);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Size = new System.Drawing.Size(39, 23);
            this.btn_Room.TabIndex = 4;
            this.btn_Room.Text = "GO";
            this.btn_Room.UseVisualStyleBackColor = true;
            this.btn_Room.Click += new System.EventHandler(this.Btn_Room_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantity";
            // 
            // txt_ItemNumberInput
            // 
            this.txt_ItemNumberInput.Location = new System.Drawing.Point(82, 88);
            this.txt_ItemNumberInput.Name = "txt_ItemNumberInput";
            this.txt_ItemNumberInput.Size = new System.Drawing.Size(100, 20);
            this.txt_ItemNumberInput.TabIndex = 7;
            this.txt_ItemNumberInput.TextChanged += new System.EventHandler(this.Txt_ItemNumberInput_TextChanged);
            // 
            // txt_QuantityInput
            // 
            this.txt_QuantityInput.Location = new System.Drawing.Point(82, 111);
            this.txt_QuantityInput.Name = "txt_QuantityInput";
            this.txt_QuantityInput.Size = new System.Drawing.Size(100, 20);
            this.txt_QuantityInput.TabIndex = 8;
            this.txt_QuantityInput.TextChanged += new System.EventHandler(this.Txt_QuantityInput_TextChanged);
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemName.Location = new System.Drawing.Point(6, 24);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Size = new System.Drawing.Size(0, 20);
            this.lbl_ItemName.TabIndex = 9;
            // 
            // lbl_ItemNumber
            // 
            this.lbl_ItemNumber.AutoSize = true;
            this.lbl_ItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemNumber.Location = new System.Drawing.Point(77, 41);
            this.lbl_ItemNumber.Name = "lbl_ItemNumber";
            this.lbl_ItemNumber.Size = new System.Drawing.Size(0, 20);
            this.lbl_ItemNumber.TabIndex = 10;
            this.lbl_ItemNumber.Click += new System.EventHandler(this.Lbl_ItemNumber_Click);
            // 
            // lbl_ItemPrice
            // 
            this.lbl_ItemPrice.AutoSize = true;
            this.lbl_ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemPrice.Location = new System.Drawing.Point(69, 59);
            this.lbl_ItemPrice.Name = "lbl_ItemPrice";
            this.lbl_ItemPrice.Size = new System.Drawing.Size(0, 20);
            this.lbl_ItemPrice.TabIndex = 11;
            // 
            // lbl_ItemTotal
            // 
            this.lbl_ItemTotal.AutoSize = true;
            this.lbl_ItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemTotal.Location = new System.Drawing.Point(69, 77);
            this.lbl_ItemTotal.Name = "lbl_ItemTotal";
            this.lbl_ItemTotal.Size = new System.Drawing.Size(0, 20);
            this.lbl_ItemTotal.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Add.Location = new System.Drawing.Point(17, 139);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // dataGridView_Bill
            // 
            this.dataGridView_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bill.Location = new System.Drawing.Point(20, 226);
            this.dataGridView_Bill.Name = "dataGridView_Bill";
            this.dataGridView_Bill.Size = new System.Drawing.Size(450, 150);
            this.dataGridView_Bill.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Detailed Bill:";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(395, 197);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 16;
            this.btn_Calculate.Text = "Calculate Bill";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(314, 198);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_RoomNumberInput);
            this.groupBox1.Controls.Add(this.btn_Room);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(351, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 53);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Room";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_ItemName);
            this.groupBox2.Controls.Add(this.lbl_ItemNumber);
            this.groupBox2.Controls.Add(this.lbl_ItemPrice);
            this.groupBox2.Controls.Add(this.lbl_ItemTotal);
            this.groupBox2.Location = new System.Drawing.Point(270, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 114);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unit Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Price:";
            // 
            // BillEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_Bill);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_QuantityInput);
            this.Controls.Add(this.txt_ItemNumberInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_RoomNumber);
            this.Name = "BillEditor";
            this.Text = "Bill Editor";
            this.Load += new System.EventHandler(this.BillEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomNumber;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.TextBox txt_RoomNumberInput;
        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ItemNumberInput;
        private System.Windows.Forms.TextBox txt_QuantityInput;
        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_ItemNumber;
        private System.Windows.Forms.Label lbl_ItemPrice;
        private System.Windows.Forms.Label lbl_ItemTotal;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dataGridView_Bill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}