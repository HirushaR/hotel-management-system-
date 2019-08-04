namespace WindowsFormsApp1
{
    partial class BillViewer
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
            this.dataGridView_Bill = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_RoomNumber
            // 
            this.lbl_RoomNumber.AutoSize = true;
            this.lbl_RoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNumber.Location = new System.Drawing.Point(19, 14);
            this.lbl_RoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RoomNumber.Name = "lbl_RoomNumber";
            this.lbl_RoomNumber.Size = new System.Drawing.Size(0, 31);
            this.lbl_RoomNumber.TabIndex = 0;
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerName.Location = new System.Drawing.Point(19, 44);
            this.lbl_CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(0, 31);
            this.lbl_CustomerName.TabIndex = 1;
            // 
            // dataGridView_Bill
            // 
            this.dataGridView_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bill.Location = new System.Drawing.Point(25, 79);
            this.dataGridView_Bill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Bill.Name = "dataGridView_Bill";
            this.dataGridView_Bill.Size = new System.Drawing.Size(589, 185);
            this.dataGridView_Bill.TabIndex = 2;
            this.dataGridView_Bill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Bill_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pass to Main Bill";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.Location = new System.Drawing.Point(413, 44);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(0, 31);
            this.lbl_TotalPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(413, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOTAL BILL";
            // 
            // BillViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Bill);
            this.Controls.Add(this.lbl_CustomerName);
            this.Controls.Add(this.lbl_RoomNumber);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BillViewer";
            this.Text = "BillViewer";
            this.Load += new System.EventHandler(this.BillViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RoomNumber;
        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.DataGridView dataGridView_Bill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label label2;
    }
}