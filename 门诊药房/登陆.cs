using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 门诊药房
{
    public partial class Frm_Login : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            uid = Txt_uid.Text;
            psw = Txt_psw.Text;
            ser = Com_server.Text;
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //声明并实例化SQL连接；

      
            try
            {
                if (Btn_win.Checked == true)
                {
                    sqlConnection.ConnectionString = "Server=(Local);Database='" + ser + "';Integrated Security=sspi"; //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                    //消息框消息内容；
                }
                else if (Btn_sql.Checked == true)
                {
                    sqlConnection.ConnectionString = "Server=(Local);Database='" +ser + "';Integrated Security=false;UID='" + uid + "';Password='" + psw + "';";
                    //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；

                }
                MessageBox.Show("              欢迎你！" + Txt_uid.Text); //在消息框中显示；            
                this.Hide();
                Frm_Userlogin form2 = new Frm_Userlogin();
                form2.psw = psw;
                form2.uid = uid;
                form2.ser = ser;
                form2.ShowDialog();                
            }
            catch (Exception)
            {
                MessageBox.Show("登录失败，请检查用户名及密码是否正确", "错误！");

            }

        }
        public void Frm_login_Load(object sender, EventArgs e)
        {
                        
            Txt_uid.Enabled = false;
            Txt_psw.Enabled = false;
        }
        private void Btn_sql_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn_sql.Checked == true)
            {
                Txt_uid.Enabled = true;
                Txt_psw.Enabled = true;
            }

        }
        private void Btn_win_CheckedChanged(object sender, EventArgs e)
        {
            if (Btn_win.Checked == true)
                Txt_uid.Enabled = false;
            Txt_psw.Enabled = false;
        }

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Close();                                               //打开SQL连接；
            MessageBox.Show                                                     //在消息框中显示；
                ("连接已断开");                 //消息框消息内容；
        }



        private void ckb_pub_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_pub.Checked == true)
            {
                Txt_psw.PasswordChar = '\0';
            }
            else
            {
                Txt_psw.PasswordChar = '●';
            }

        }

        private void Frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Btn_confirm_Click(sender, e);
            }
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }



        private void Com_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Com_server.Text != "")

            {
                Btn_confirm.Enabled = true;
            }
        }


        
    }
}

         