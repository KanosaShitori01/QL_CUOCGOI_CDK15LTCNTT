using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace qlcuocgoi_dtt
{
    public partial class DSKH : Form
    {
        SqlConnection conn = new SqlConnection(@"Server=.;Database=QL_CUOCGOI;Integrated Security=true");
        SqlDataAdapter adap;
        DataTable dt;
        public static string commandName = "";
        public DSKH()
        {
            InitializeComponent();
        }
        private void activeDataLB()
        {
            adap = new SqlDataAdapter("SELECT * FROM THUEBAO", conn);
            dt = new DataTable();
            adap.Fill(dt);
            lb_khachhang.DataSource = dt;
            lb_khachhang.DisplayMember = "TenThueBao";
            lb_khachhang.ValueMember = "SoThueBao";
        }
        private void activeCommandBTN(string type)
        {
            string query = "";
            string alert = "";
            switch (type)
            {
                case "Add":
                    query = String.Format("INSERT INTO CUOCGOI(SoThueBao, GioBatDau, GioKetThuc,"+
                    "SoThueBaoGoi) VALUES('{0}', '{1}', '{2}', '{3}')",txt_sothuebao.Text, dtp_giobatdau.Text,
                    dtp_gioketthuc.Text, txt_sothuebaogoi.Text.Trim());
                    alert = String.Format("Đã thêm thành công cuộc gọi: {0}", txt_sothuebao.Text);
                    break;
                case "Edit":
                    query = String.Format("UPDATE CUOCGOI SET SoThueBao = '{0}',"+
                    "GioBatDau='{1}', GioKetThuc='{2}',SoThueBaoGoi='{3}' WHERE id='{4}'", 
                    txt_sothuebao.Text, dtp_giobatdau.Text,
                    dtp_gioketthuc.Text, txt_sothuebaogoi.Text.Trim(), 
                    dataGV_kh.CurrentRow.Cells["ID"].Value);
                    alert = String.Format("Đã sửa thành công cuộc gọi: {0}", txt_sothuebao.Text);
                    break;
                case "Delete":
                    query = String.Format("DELETE FROM CUOCGOI WHERE id={0}", 
                        dataGV_kh.CurrentRow.Cells["ID"].Value);
                    alert = String.Format("Đã xóa cuộc gọi: {0}", txt_sothuebao.Text);
                    break;
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show(alert);
                selectDataKH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Connection.Close();
        }
        private void selectDataKH()
        {
            string query = String.Format("SELECT * FROM CUOCGOI WHERE SoThueBao = '{0}'", lb_khachhang.SelectedValue);
            adap = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            adap.Fill(dt);
            dataGV_kh.DataSource = dt;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox || ctr is DateTimePicker)
                {
                    ctr.Text = "";
                    ctr.DataBindings.Clear();
                    ctr.Enabled = true;
                }
            }
            txt_sothuebao.Enabled = false;
            txt_sothuebao.Text = lb_khachhang.SelectedValue.ToString();
            txt_sothuebaogoi.DataBindings.Add("Text", dt, "SoThueBaoGoi");
            dtp_giobatdau.DataBindings.Add("Value", dt, "GioBatDau");
            dtp_gioketthuc.DataBindings.Add("Value", dt, "GioKetThuc");
            BlockBTN(false);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void BlockBTN(bool check)
        {
            btn_luu.Enabled = check;
            btn_huy.Enabled = check;
            btn_them.Enabled = !check;
            btn_sua.Enabled = !check;
            btn_xoa.Enabled = !check;
            lb_khachhang.Enabled = !check;
            //if(dataGV_kh.RowCount  2)
            //    dataGV_kh.Enabled = !check;
        }
        private void DSKH_Load(object sender, EventArgs e)
        {
            activeDataLB();
            
            foreach (Control ctr in this.Controls)
            {
                if(ctr is Button)
                ctr.Enabled = false;
            }
            btn_inbao.Enabled = true;
            selectDataKH();
        }

        private void lb_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
           selectDataKH();
        }
        private void openCommand(){
            dtp_giobatdau.Text = "";
            dtp_gioketthuc.Text = "";
            txt_sothuebaogoi.Text = "";
            BlockBTN(true);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            openCommand();
            commandName = "Add";
        }

        private void txt_sothuebao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            activeCommandBTN(commandName);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            openCommand();
            commandName = "Edit";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            openCommand();
            commandName = "Delete";
        }

        private void btn_inbao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(commandName);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            selectDataKH();
            BlockBTN(false);
        }
    }
}
