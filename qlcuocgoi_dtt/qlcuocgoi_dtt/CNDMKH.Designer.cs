namespace qlcuocgoi_dtt
{
    partial class CNDMKH
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
            this.dataGV_kh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sothuebao = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.SoThueBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThueBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiThueBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tenthuebao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_socmnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_loaithuebao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_kh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thuê bao";
            // 
            // dataGV_kh
            // 
            this.dataGV_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThueBao,
            this.TenThueBao,
            this.NgaySinh,
            this.DiaChi,
            this.SoCMND,
            this.LoaiThueBao});
            this.dataGV_kh.Location = new System.Drawing.Point(12, 55);
            this.dataGV_kh.Name = "dataGV_kh";
            this.dataGV_kh.Size = new System.Drawing.Size(643, 261);
            this.dataGV_kh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(389, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CẬP NHẬT DANH MỤC KHÁCH HÀNG";
            // 
            // txt_sothuebao
            // 
            this.txt_sothuebao.Location = new System.Drawing.Point(112, 24);
            this.txt_sothuebao.Name = "txt_sothuebao";
            this.txt_sothuebao.Size = new System.Drawing.Size(200, 20);
            this.txt_sothuebao.TabIndex = 3;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(127, 199);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(112, 76);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysinh.TabIndex = 5;
            this.dtp_ngaysinh.Value = new System.DateTime(2022, 3, 21, 0, 0, 0, 0);
            // 
            // SoThueBao
            // 
            this.SoThueBao.HeaderText = "Số Thuê Bao";
            this.SoThueBao.Name = "SoThueBao";
            // 
            // TenThueBao
            // 
            this.TenThueBao.HeaderText = "Tên Thuê Bao";
            this.TenThueBao.Name = "TenThueBao";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // SoCMND
            // 
            this.SoCMND.HeaderText = "Số CMND";
            this.SoCMND.Name = "SoCMND";
            // 
            // LoaiThueBao
            // 
            this.LoaiThueBao.HeaderText = "Loại Thuê Bao";
            this.LoaiThueBao.Name = "LoaiThueBao";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.txt_loaithuebao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_socmnd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tenthuebao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.txt_sothuebao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(661, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_tenthuebao
            // 
            this.txt_tenthuebao.Location = new System.Drawing.Point(112, 50);
            this.txt_tenthuebao.Name = "txt_tenthuebao";
            this.txt_tenthuebao.Size = new System.Drawing.Size(200, 20);
            this.txt_tenthuebao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên thuê bao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(112, 102);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(200, 20);
            this.txt_diachi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa chỉ";
            // 
            // txt_socmnd
            // 
            this.txt_socmnd.Location = new System.Drawing.Point(112, 128);
            this.txt_socmnd.Name = "txt_socmnd";
            this.txt_socmnd.Size = new System.Drawing.Size(200, 20);
            this.txt_socmnd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số CMND";
            // 
            // txt_loaithuebao
            // 
            this.txt_loaithuebao.Location = new System.Drawing.Point(112, 154);
            this.txt_loaithuebao.Name = "txt_loaithuebao";
            this.txt_loaithuebao.Size = new System.Drawing.Size(200, 20);
            this.txt_loaithuebao.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Loại thuê bao";
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(237, 199);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // CNDMKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV_kh);
            this.Name = "CNDMKH";
            this.Text = "CNDMKH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_kh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGV_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThueBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThueBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiThueBao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sothuebao;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_loaithuebao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_socmnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenthuebao;
        private System.Windows.Forms.Label label3;
    }
}