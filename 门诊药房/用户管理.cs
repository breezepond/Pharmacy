using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 门诊药房
{
    public partial class Frm_Useradmin : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Useradmin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Frm_useradmin_Load_1(object sender, EventArgs e)
        {
      
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString ="Server=(Local);Database=PharmacySystem;Integrated Security=false;UID='" + uid + "';Password='" + psw + "';";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "select * from UserAdministration where userid='" + Txt_uid + "' and UserPassWord='" + Txt_oldpsw + "'";
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；             
            if (rowCount == 1)                                                                          //若查得所输用户号相应的1行记录；
            {
                SqlCommand sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection = sqlConnection;
                sqlCommand2.CommandText = "UPDATE UserAdministration SET UserPassWord='" + Txt_newpsw + "' WHERE where  UserId='" + Txt_uid + "' and UserPassWord='" + Txt_oldpsw + "'";
                sqlConnection.Open();
                int rowAffected = sqlCommand.ExecuteNonQuery();                                                 //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                sqlConnection.Close();                                                                          //关闭SQL连接；
                MessageBox.Show("更新成功!");                                      //在消息框显示受影响行数；                                       
                this.Hide();
                Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
                form2.uid = uid;
                form2.ser = ser;
                form2.psw = psw;
                form2.ShowDialog();
                //显示正确提示；
            }
            else
            {
                MessageBox.Show("登录失败，请检查用户名及密码是否正确", "错误！");
                this.Txt_oldpsw.SelectAll();                                                          //密码文本框内所有文本被选中；}
            }
        }
    }
}
