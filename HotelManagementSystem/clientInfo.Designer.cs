namespace HotelManagementSystem
{
    partial class clientInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.client_fullName = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.client_clear = new System.Windows.Forms.Button();
            this.client_bookBtn = new System.Windows.Forms.Button();
            this.client_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.client_gender = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.client_contact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.client_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientfullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.client_bookID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.client_fullName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // client_fullName
            // 
            this.client_fullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.client_fullName.Controls.Add(this.label3);
            this.client_fullName.Controls.Add(this.label1);
            this.client_fullName.Controls.Add(this.label2);
            this.client_fullName.Controls.Add(this.close);
            this.client_fullName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.client_fullName.Dock = System.Windows.Forms.DockStyle.Top;
            this.client_fullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.client_fullName.Location = new System.Drawing.Point(0, 0);
            this.client_fullName.Name = "client_fullName";
            this.client_fullName.Size = new System.Drawing.Size(849, 41);
            this.client_fullName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(816, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(977, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(1238, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.client_clear);
            this.panel2.Controls.Add(this.client_bookBtn);
            this.panel2.Controls.Add(this.client_address);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.client_gender);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.client_contact);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.client_email);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clientfullName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.client_bookID);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 489);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // client_clear
            // 
            this.client_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.client_clear.FlatAppearance.BorderSize = 0;
            this.client_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_clear.ForeColor = System.Drawing.Color.White;
            this.client_clear.Location = new System.Drawing.Point(455, 403);
            this.client_clear.Name = "client_clear";
            this.client_clear.Size = new System.Drawing.Size(204, 37);
            this.client_clear.TabIndex = 25;
            this.client_clear.Text = "Làm mới";
            this.client_clear.UseVisualStyleBackColor = false;
            this.client_clear.Click += new System.EventHandler(this.client_clear_Click);
            // 
            // client_bookBtn
            // 
            this.client_bookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.client_bookBtn.FlatAppearance.BorderSize = 0;
            this.client_bookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_bookBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookBtn.ForeColor = System.Drawing.Color.White;
            this.client_bookBtn.Location = new System.Drawing.Point(156, 403);
            this.client_bookBtn.Name = "client_bookBtn";
            this.client_bookBtn.Size = new System.Drawing.Size(213, 37);
            this.client_bookBtn.TabIndex = 24;
            this.client_bookBtn.Text = "Đặt phòng";
            this.client_bookBtn.UseVisualStyleBackColor = false;
            this.client_bookBtn.Click += new System.EventHandler(this.client_bookBtn_Click);
            // 
            // client_address
            // 
            this.client_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_address.Location = new System.Drawing.Point(517, 206);
            this.client_address.Multiline = true;
            this.client_address.Name = "client_address";
            this.client_address.Size = new System.Drawing.Size(164, 74);
            this.client_address.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(447, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Địa chỉ:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // client_gender
            // 
            this.client_gender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_gender.FormattingEnabled = true;
            this.client_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.client_gender.Location = new System.Drawing.Point(517, 164);
            this.client_gender.Name = "client_gender";
            this.client_gender.Size = new System.Drawing.Size(164, 25);
            this.client_gender.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Giới tính:";
            // 
            // client_contact
            // 
            this.client_contact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_contact.Location = new System.Drawing.Point(175, 255);
            this.client_contact.Name = "client_contact";
            this.client_contact.Size = new System.Drawing.Size(164, 25);
            this.client_contact.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số điện thoại:";
            // 
            // client_email
            // 
            this.client_email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_email.Location = new System.Drawing.Point(175, 209);
            this.client_email.Name = "client_email";
            this.client_email.Size = new System.Drawing.Size(164, 25);
            this.client_email.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // clientfullName
            // 
            this.clientfullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientfullName.Location = new System.Drawing.Point(175, 164);
            this.clientfullName.Name = "clientfullName";
            this.clientfullName.Size = new System.Drawing.Size(164, 25);
            this.clientfullName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Họ và tên:";
            // 
            // client_bookID
            // 
            this.client_bookID.AutoSize = true;
            this.client_bookID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_bookID.Location = new System.Drawing.Point(172, 128);
            this.client_bookID.Name = "client_bookID";
            this.client_bookID.Size = new System.Drawing.Size(22, 17);
            this.client_bookID.TabIndex = 11;
            this.client_bookID.Text = "ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(81, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "ID Đặt Phòng:";
            // 
            // clientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 548);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.client_fullName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientinfo";
            this.TopMost = true;
            this.client_fullName.ResumeLayout(false);
            this.client_fullName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel client_fullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox client_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientfullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label client_bookID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox client_contact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox client_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox client_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button client_clear;
        private System.Windows.Forms.Button client_bookBtn;
    }
}