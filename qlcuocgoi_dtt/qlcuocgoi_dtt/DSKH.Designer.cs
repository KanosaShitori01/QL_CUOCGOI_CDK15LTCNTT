namespace qlcuocgoi_dtt
{
    partial class DSKH
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_giobatdau = new System.Windows.Forms.DateTimePicker();
            this.txt_sothuebao = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGV_kh = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_inbao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sothuebaogoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_gioketthuc = new System.Windows.Forms.DateTimePicker();
            this.lb_khachhang = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thuê bao";
            // 
            // dtp_giobatdau
            // 
            this.dtp_giobatdau.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_giobatdau.Location = new System.Drawing.Point(296, 71);
            this.dtp_giobatdau.Name = "dtp_giobatdau";
            this.dtp_giobatdau.Size = new System.Drawing.Size(266, 20);
            this.dtp_giobatdau.TabIndex = 3;
            this.dtp_giobatdau.Value = new System.DateTime(2022, 3, 21, 9, 5, 0, 0);
            // 
            // txt_sothuebao
            // 
            this.txt_sothuebao.Enabled = false;
            this.txt_sothuebao.Location = new System.Drawing.Point(296, 39);
            this.txt_sothuebao.Name = "txt_sothuebao";
            this.txt_sothuebao.Size = new System.Drawing.Size(211, 20);
            this.txt_sothuebao.TabIndex = 4;
            this.txt_sothuebao.TextChanged += new System.EventHandler(this.txt_sothuebao_TextChanged);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(206, 181);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGV_kh
            // 
            this.dataGV_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_kh.Location = new System.Drawing.Point(206, 210);
            this.dataGV_kh.Name = "dataGV_kh";
            this.dataGV_kh.Size = new System.Drawing.Size(452, 135);
            this.dataGV_kh.TabIndex = 6;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(296, 181);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 7;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(390, 181);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(486, 181);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(583, 181);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 10;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_inbao
            // 
            this.btn_inbao.Location = new System.Drawing.Point(583, 143);
            this.btn_inbao.Name = "btn_inbao";
            this.btn_inbao.Size = new System.Drawing.Size(75, 23);
            this.btn_inbao.TabIndex = 11;
            this.btn_inbao.Text = "In báo";
            this.btn_inbao.UseVisualStyleBackColor = true;
            this.btn_inbao.Click += new System.EventHandler(this.btn_inbao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Giờ bắt đầu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Giờ kết thúc";
            // 
            // txt_sothuebaogoi
            // 
            this.txt_sothuebaogoi.Location = new System.Drawing.Point(296, 140);
            this.txt_sothuebaogoi.Name = "txt_sothuebaogoi";
            this.txt_sothuebaogoi.Size = new System.Drawing.Size(211, 20);
            this.txt_sothuebaogoi.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số thuê bao gọi";
            // 
            // dtp_gioketthuc
            // 
            this.dtp_gioketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_gioketthuc.Location = new System.Drawing.Point(296, 103);
            this.dtp_gioketthuc.Name = "dtp_gioketthuc";
            this.dtp_gioketthuc.Size = new System.Drawing.Size(266, 20);
            this.dtp_gioketthuc.TabIndex = 18;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.FormattingEnabled = true;
            this.lb_khachhang.Location = new System.Drawing.Point(12, 42);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(188, 303);
            this.lb_khachhang.TabIndex = 19;
            this.lb_khachhang.SelectedIndexChanged += new System.EventHandler(this.lb_khachhang_SelectedIndexChanged);
            // 
            // DSKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 357);
            this.Controls.Add(this.lb_khachhang);
            this.Controls.Add(this.dtp_gioketthuc);
            this.Controls.Add(this.txt_sothuebaogoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_inbao);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dataGV_kh);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_sothuebao);
            this.Controls.Add(this.dtp_giobatdau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DSKH";
            this.Text = "DSKH";
            this.Load += new System.EventHandler(this.DSKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_giobatdau;
        private System.Windows.Forms.TextBox txt_sothuebao;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGV_kh;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_inbao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sothuebaogoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_gioketthuc;
        private System.Windows.Forms.ListBox lb_khachhang;
    }
}