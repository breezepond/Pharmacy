using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 门诊药房
{
    public partial class Frm_Medicineneck : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Medicineneck()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Medicineneck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection sqlconnecting = new SqlConnection( "Server=(Local);Database='"+000+"';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
                //创建SqlDataAdapter对象s
                SqlDataAdapter s = new SqlDataAdapter("select * from MedicineInformation", sqlconnecting);
                //创建DataSet对象d
                DataSet d = new DataSet();
                //使用fill方法填充DataSet
                s.Fill(d, "t");
                //在DataGridView1控件中显示表t
                Dgv.DataSource = d.Tables["t"];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Frm_Medicineneck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_Neck_Click(sender, e);
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void Btn_Neck_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

    }
}
