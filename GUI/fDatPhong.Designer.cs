namespace HotelManagement
{
    partial class fDatPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddCustomerByRoom = new System.Windows.Forms.Button();
            this.btnDeleteCustomerByRoom = new System.Windows.Forms.Button();
            this.btnUpdateCustomerByRoom = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkInDateInput = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbRoomtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatPhong = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(385, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(14, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 338);
            this.panel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnAddCustomerByRoom);
            this.panel10.Controls.Add(this.btnDeleteCustomerByRoom);
            this.panel10.Controls.Add(this.btnUpdateCustomerByRoom);
            this.panel10.Location = new System.Drawing.Point(7, 8);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 44);
            this.panel10.TabIndex = 32;
            // 
            // btnAddCustomerByRoom
            // 
            this.btnAddCustomerByRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomerByRoom.Location = new System.Drawing.Point(2, 3);
            this.btnAddCustomerByRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddCustomerByRoom.Name = "btnAddCustomerByRoom";
            this.btnAddCustomerByRoom.Size = new System.Drawing.Size(104, 37);
            this.btnAddCustomerByRoom.TabIndex = 26;
            this.btnAddCustomerByRoom.Text = "THÊM";
            this.btnAddCustomerByRoom.UseVisualStyleBackColor = true;
            this.btnAddCustomerByRoom.Click += new System.EventHandler(this.btnAddCustomerByRoom_Click);
            // 
            // btnDeleteCustomerByRoom
            // 
            this.btnDeleteCustomerByRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteCustomerByRoom.Location = new System.Drawing.Point(224, 3);
            this.btnDeleteCustomerByRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCustomerByRoom.Name = "btnDeleteCustomerByRoom";
            this.btnDeleteCustomerByRoom.Size = new System.Drawing.Size(104, 37);
            this.btnDeleteCustomerByRoom.TabIndex = 28;
            this.btnDeleteCustomerByRoom.Text = "XOÁ";
            this.btnDeleteCustomerByRoom.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomerByRoom
            // 
            this.btnUpdateCustomerByRoom.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCustomerByRoom.Location = new System.Drawing.Point(113, 3);
            this.btnUpdateCustomerByRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCustomerByRoom.Name = "btnUpdateCustomerByRoom";
            this.btnUpdateCustomerByRoom.Size = new System.Drawing.Size(104, 37);
            this.btnUpdateCustomerByRoom.TabIndex = 27;
            this.btnUpdateCustomerByRoom.Text = "SỬA";
            this.btnUpdateCustomerByRoom.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkInDateInput);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(9, 189);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 31);
            this.panel3.TabIndex = 4;
            // 
            // checkInDateInput
            // 
            this.checkInDateInput.Location = new System.Drawing.Point(89, 4);
            this.checkInDateInput.Name = "checkInDateInput";
            this.checkInDateInput.Size = new System.Drawing.Size(200, 23);
            this.checkInDateInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bắt đầu từ:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbRoom);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(9, 152);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(331, 31);
            this.panel5.TabIndex = 4;
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(89, 3);
            this.cbRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(140, 23);
            this.cbRoom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbRoomtype);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(9, 106);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(331, 31);
            this.panel4.TabIndex = 4;
            // 
            // cbRoomtype
            // 
            this.cbRoomtype.FormattingEnabled = true;
            this.cbRoomtype.Location = new System.Drawing.Point(88, 2);
            this.cbRoomtype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRoomtype.Name = "cbRoomtype";
            this.cbRoomtype.Size = new System.Drawing.Size(140, 23);
            this.cbRoomtype.TabIndex = 1;
            this.cbRoomtype.SelectedIndexChanged += new System.EventHandler(this.cbRoomtype_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại Phòng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 31);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(304, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(89, 4);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(208, 23);
            this.cbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khách hàng";
            // 
            // dgvDatPhong
            // 
            this.dgvDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatPhong.Location = new System.Drawing.Point(365, 100);
            this.dgvDatPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDatPhong.Name = "dgvDatPhong";
            this.dgvDatPhong.Size = new System.Drawing.Size(726, 338);
            this.dgvDatPhong.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(223, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 19);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "Chỉ hiện chưa trả";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 519);
            this.Controls.Add(this.dgvDatPhong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDatPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbRoomtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatPhong;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddCustomerByRoom;
        private System.Windows.Forms.Button btnDeleteCustomerByRoom;
        private System.Windows.Forms.Button btnUpdateCustomerByRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker checkInDateInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}