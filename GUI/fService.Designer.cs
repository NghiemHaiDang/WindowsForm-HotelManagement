namespace HotelManagement
{
    partial class fService
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnRepairService = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbNameService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPriceService = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbIDService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPriceService)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(48, 98);
            this.dgvService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(392, 362);
            this.dgvService.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnAddService);
            this.panel10.Controls.Add(this.btnDeleteService);
            this.panel10.Controls.Add(this.btnRepairService);
            this.panel10.Location = new System.Drawing.Point(465, 98);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(330, 44);
            this.panel10.TabIndex = 31;
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddService.Location = new System.Drawing.Point(2, 3);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(104, 37);
            this.btnAddService.TabIndex = 26;
            this.btnAddService.Text = "THÊM";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.Location = new System.Drawing.Point(224, 3);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(104, 37);
            this.btnDeleteService.TabIndex = 28;
            this.btnDeleteService.Text = "XOÁ";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnRepairService
            // 
            this.btnRepairService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRepairService.Location = new System.Drawing.Point(113, 3);
            this.btnRepairService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRepairService.Name = "btnRepairService";
            this.btnRepairService.Size = new System.Drawing.Size(104, 37);
            this.btnRepairService.TabIndex = 27;
            this.btnRepairService.Text = "SỬA";
            this.btnRepairService.UseVisualStyleBackColor = true;
            this.btnRepairService.Click += new System.EventHandler(this.btnRepairService_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbNameService);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 35);
            this.panel1.TabIndex = 32;
            // 
            // txbNameService
            // 
            this.txbNameService.Location = new System.Drawing.Point(90, 5);
            this.txbNameService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbNameService.Name = "txbNameService";
            this.txbNameService.Size = new System.Drawing.Size(234, 23);
            this.txbNameService.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dịch vụ:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPriceService);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 35);
            this.panel2.TabIndex = 33;
            // 
            // txbPriceService
            // 
            this.txbPriceService.Location = new System.Drawing.Point(90, 3);
            this.txbPriceService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbPriceService.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txbPriceService.Name = "txbPriceService";
            this.txbPriceService.Size = new System.Drawing.Size(234, 23);
            this.txbPriceService.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá tiền:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(465, 159);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 137);
            this.panel3.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbIDService);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 35);
            this.panel4.TabIndex = 34;
            // 
            // txbIDService
            // 
            this.txbIDService.Location = new System.Drawing.Point(90, 5);
            this.txbIDService.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbIDService.Name = "txbIDService";
            this.txbIDService.ReadOnly = true;
            this.txbIDService.Size = new System.Drawing.Size(234, 23);
            this.txbIDService.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(382, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dịch vụ";
            // 
            // fService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.dgvService);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fService";
            this.Text = "SERVICE";
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPriceService)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnRepairService;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNameService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown txbPriceService;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbIDService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}