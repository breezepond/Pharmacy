using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 门诊药房
{
    public partial class Frm_Userlogin : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Userlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            
            try
            {SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.ConnectionString =
 "Server=(Local);Database='" + ser + "';Integrated Security=false;UID='" + uid + "';Password='" + psw + "';";
            //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            sqlCommand.CommandText = "SELECT COUNT(1) FROM UserAdministration WHERE UserId=@workid AND UserPassWord=@workpsw;";   //指定SQL命令的命令文本；命令文本包含参数； 
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@workid";                                                         //设置SQL参数的名称
            sqlParameter.Value = Txt_workid.Text ;                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 10;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                   //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@workpsw", this.Txt_workpsw.Text);             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@workpsw"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion
            //声明并实例化SQL连接；
                
                sqlConnection.Open();                                                                       //打开SQL连接；
                int rowCount = (int)sqlCommand.ExecuteScalar();
                sqlConnection.Close();   
                                           //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；             
                if (rowCount == 1)                                                                          //若查得所输用户号相应的1行记录；
                {
                    MessageBox.Show("登录成功。");
                    sqlConnection.Open();                                               //打开SQL连接；
                    this.Hide();
                    Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
                    form2.ShowDialog();
                                                    //显示正确提示；
                }
            }
            catch          (Exception ex)                                                                            //否则；
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("用户号/密码有误，请重新输入！");                                       //显示错误提示；
                this.Txt_workid.Focus();                                                              //密码文本框获得焦点；
                this.Txt_workpsw.SelectAll();                                                          //密码文本框内所有文本被选中；
            }



            }

     

        private void Frm_userlogin_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Userlogin_Load_1(object sender, EventArgs e)
        {

        }
        private void Frm_Userlogin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Login form =new Frm_Login();
            form.ShowDialog();


        }

    }
}

