namespace WindowsFormsApp1
{
    partial class mainMenuCalculation
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
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_AddModifyDelete = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.panel_Calculate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Go = new System.Windows.Forms.Button();
            this.txt_RoomNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Menu.SuspendLayout();
            this.panel_Calculate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Menu.Controls.Add(this.btn_AddModifyDelete);
            this.panel_Menu.Controls.Add(this.btn_Show);
            this.panel_Menu.Controls.Add(this.label1);
            this.panel_Menu.Location = new System.Drawing.Point(244, 73);
            this.panel_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(469, 164);
            this.panel_Menu.TabIndex = 1;
            // 
            // btn_AddModifyDelete
            // 
            this.btn_AddModifyDelete.Location = new System.Drawing.Point(11, 55);
            this.btn_AddModifyDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddModifyDelete.Name = "btn_AddModifyDelete";
            this.btn_AddModifyDelete.Size = new System.Drawing.Size(209, 74);
            this.btn_AddModifyDelete.TabIndex = 5;
            this.btn_AddModifyDelete.Text = "Add / Modify / Delete";
            this.btn_AddModifyDelete.UseVisualStyleBackColor = true;
            this.btn_AddModifyDelete.Click += new System.EventHandler(this.Btn_AddModifyDelete_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(256, 55);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(209, 74);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show the database";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details of the Main Menu";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(16, 73);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(100, 60);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(16, 176);
            this.btn_Calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(100, 60);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "Calculate a bill for a guest";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Btn_Calculate_Click);
            // 
            // panel_Calculate
            // 
            this.panel_Calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Calculate.Controls.Add(this.label4);
            this.panel_Calculate.Controls.Add(this.btn_Go);
            this.panel_Calculate.Controls.Add(this.txt_RoomNumber);
            this.panel_Calculate.Controls.Add(this.label2);
            this.panel_Calculate.Location = new System.Drawing.Point(244, 73);
            this.panel_Calculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Calculate.Name = "panel_Calculate";
            this.panel_Calculate.Size = new System.Drawing.Size(472, 164);
            this.panel_Calculate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Number: (Optional)";
            // 
            // btn_Go
            // 
            this.btn_Go.Location = new System.Drawing.Point(11, 101);
            this.btn_Go.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(100, 28);
            this.btn_Go.TabIndex = 2;
            this.btn_Go.Text = "Go";
            this.btn_Go.UseVisualStyleBackColor = true;
            this.btn_Go.Click += new System.EventHandler(this.Btn_Go_Click);
            // 
            // txt_RoomNumber
            // 
            this.txt_RoomNumber.Location = new System.Drawing.Point(9, 69);
            this.txt_RoomNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RoomNumber.Name = "txt_RoomNumber";
            this.txt_RoomNumber.Size = new System.Drawing.Size(132, 22);
            this.txt_RoomNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Calculate a bill for a guest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Menu Operations";
            // 
            // mainMenuCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Calculate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainMenuCalculation";
            this.Text = "Main Menu Calculation";
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_Calculate.ResumeLayout(false);
            this.panel_Calculate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Panel panel_Calculate;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_RoomNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_AddModifyDelete;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}