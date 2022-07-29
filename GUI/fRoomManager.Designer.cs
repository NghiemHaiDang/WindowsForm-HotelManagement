namespace HotelManagement
{
    partial class fRoomManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.cbAddService = new System.Windows.Forms.ComboBox();
            this.btnadDV = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.flpRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(774, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 618);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownCount);
            this.panel3.Controls.Add(this.cbAddService);
            this.panel3.Controls.Add(this.btnadDV);
            this.panel3.Location = new System.Drawing.Point(5, 438);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 65);
            this.panel3.TabIndex = 8;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(4, 33);
            this.numericUpDownCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(140, 23);
            this.numericUpDownCount.TabIndex = 7;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbAddService
            // 
            this.cbAddService.FormattingEnabled = true;
            this.cbAddService.Location = new System.Drawing.Point(4, 3);
            this.cbAddService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbAddService.Name = "cbAddService";
            this.cbAddService.Size = new System.Drawing.Size(136, 23);
            this.cbAddService.TabIndex = 6;
            // 
            // btnadDV
            // 
            this.btnadDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadDV.Location = new System.Drawing.Point(148, 2);
            this.btnadDV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnadDV.Name = "btnadDV";
            this.btnadDV.Size = new System.Drawing.Size(86, 25);
            this.btnadDV.TabIndex = 4;
            this.btnadDV.Text = "THÊM";
            this.btnadDV.UseVisualStyleBackColor = true;
            this.btnadDV.Click += new System.EventHandler(this.btnadDV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteService);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Controls.Add(this.btnAddCustomer);
            this.panel2.Location = new System.Drawing.Point(5, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.Location = new System.Drawing.Point(290, 6);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(86, 37);
            this.btnDeleteService.TabIndex = 3;
            this.btnDeleteService.Text = "XOÁ";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDatPhong.Location = new System.Drawing.Point(165, 6);
            this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(104, 37);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCustomer.Location = new System.Drawing.Point(19, 6);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(125, 37);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Thêm Khách";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckOut.Location = new System.Drawing.Point(260, 438);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(147, 65);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "THANH TOÁN";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Location = new System.Drawing.Point(0, 391);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(407, 40);
            this.panel4.TabIndex = 5;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.txbTotalPrice.Location = new System.Drawing.Point(2, 3);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(199, 33);
            this.txbTotalPrice.TabIndex = 0;
            this.txbTotalPrice.Text = "0";
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 73);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(407, 310);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên dịch vụ";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thành tiền";
            this.columnHeader3.Width = 98;
            // 
            // flpRoom
            // 
            this.flpRoom.AutoScroll = true;
            this.flpRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpRoom.Location = new System.Drawing.Point(13, 52);
            this.flpRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpRoom.Name = "flpRoom";
            this.flpRoom.Size = new System.Drawing.Size(753, 610);
            this.flpRoom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(533, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ CÁC PHÒNG";
            // 
            // fRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fRoomManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAN LY PHONG";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.ComboBox cbAddService;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnadDV;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Label label1;
    }
}