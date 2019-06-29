using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database='PharmacySystem';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter("select * from MedicineInformation ", sqlConnection);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            Dgv.DataSource = d.Tables["t"];
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



        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void Btn_Neck_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database=PharmacySystem;Integrated Security=false;UID=sa;Password=2wsx@WSX;");
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "declare @x int,@y char(8)select @x= COUNT(CurrentNo) from Necklist where CAST(NeckDate as date)=CAST(GETDATE() as date)if(@x=0)begin select @y = convert(char(8), getdate(), 112)insert Necklist(MedicineName, Neckcounts, Reporter, Addition, CurrentNo, NeckDate) values('" + Txt_medicinename.Text + "', '" + Txt_accounts.Text + "', '" + Txt_reporter.Text + "', '" + Txt_ps.Text + "', @y+'0001', GETDATE())end else insert Necklist(MedicineName, Neckcounts, Reporter, Addition, CurrentNo, NeckDate) values('" + Txt_medicinename.Text + "', '" + Txt_accounts.Text + "', '" + Txt_reporter.Text + "', '" + Txt_ps.Text + "',(select MAX(CurrentNo) + 1 from Necklist where CAST(NeckDate as date) = CAST(GETDATE() as date)),GETDATE())";
            sqlConnection.Open();                                               //打开SQL连接；
            int rowAffected = sqlCommand.ExecuteNonQuery();                                             //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            sqlConnection.Close();                                                                      //关闭SQL连接；
            if (rowAffected == 1)                                                                       //若成功写入1行记录；
            {
                MessageBox.Show("请领成功。");                                                          //给出正确提示；
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("请领失败！");                                                          //给出错误提示；
            }
            sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data1 = Dgv.CurrentRow.Cells[13].Value.ToString();
            Txt_medicinename.Text = data1;
        }
    }
}
