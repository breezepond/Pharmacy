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
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@UID";                                                         //设置SQL参数的名称；
            sqlParameter.Value = this.Txt_uid.Text.Trim();                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 10;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                    //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@PSW", this.Txt_psw.Text.Trim());             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@PSW"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion
            //声明并实例化SQL连接；

      
            try
            {
                if (Btn_win.Checked == true)
                {
                    sqlConnection.ConnectionString = "Server=(Local);Database='" + this.Com_server.Text + "';Integrated Security=sspi"; //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                    //消息框消息内容；
                }
                else if (Btn_sql.Checked == true)
                {
                    sqlConnection.ConnectionString = "Server=(Local);Database='" + this.Com_server.Text + "';Integrated Security=false;UID='" + this.Txt_uid.Text + "';Password='" + this.Txt_psw.Text + "';";
                    //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
                    sqlConnection.Open();                                               //打开SQL连接；
                    MessageBox.Show                                                     //在消息框中显示；
                        ("连接状态：" + sqlConnection.State.ToString()                  //消息框消息内容；
                        + "\n工作站标识：" + sqlConnection.WorkstationId
                        + "\n服务器地址：" + sqlConnection.DataSource
                        + "\n服务器版本：" + sqlConnection.ServerVersion
                        + "\n数据库名称：" + sqlConnection.Database
                        + "\n\n（单击【确定】后将关闭SQL连接）");
                    sqlConnection.Close();

                }
                MessageBox.Show("              欢迎你！" + Txt_uid.Text); //在消息框中显示；            
                this.Hide();
                Frm_Userlogin form2 = new Frm_Userlogin();
                form2.psw = Txt_psw.Text;
                form2.uid = Txt_uid.Text;
                form2.ser = Com_server.Text;
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

        private static void Txt_uid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_uid_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void Com_server_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Com_server.Text != "")

            {
                Btn_confirm.Enabled = true;
            }
        }

        private void Txt_psw_TextChanged(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
    }
}

         