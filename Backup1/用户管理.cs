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
    public partial class Frm_Useradmin : Form
    {
        public string uid;
        public string psw;
        public Frm_Useradmin()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Frm_useradmin_Load_1(object sender, EventArgs e)
        {
        
            SqlConnection sqlConnection = new SqlConnection();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            #region SQL参数用法1
            SqlParameter sqlParameter = new SqlParameter();                                             //声明并实例化SQL参数；
            sqlParameter.ParameterName = "@UID";                                                         //设置SQL参数的名称；
            sqlParameter.Value = uid;                                           //设置SQL参数的长度；
            sqlParameter.SqlDbType = SqlDbType.Char;                                                    //设置SQL参数对应的SQL Server数据类型；
            sqlParameter.Size = 10;                                                                     //设置SQL参数的长度；
            sqlCommand.Parameters.Add(sqlParameter);                                                    //向SQL命令的参数集合添加SQL参数；
            #endregion
            #region SQL参数用法2
            sqlCommand.Parameters.AddWithValue("@PSW", psw);             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@PSW"].SqlDbType = SqlDbType.VarChar;                           //通过参数名称访问SQL参数，并将密码参数的类型设为变长字符串；由于HASHBYTES函数的参数为NVARCHAR，则SQL参数类型自动设为NVARCHAR；对于相同密码，VARCHAR/NVARCHAR类型所获得的散列值不同，故需手动将SQL参数类型统一设为VARCHAR;
            #endregion
            //声明并实例化SQL连接；
                sqlConnection.ConnectionString =
 "Server=(Local);Database=EduBaseDemo;Integrated Security=false;UID='" + uid + "';Password='" + psw + "';";
                //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；

                sqlConnection.Open();                                               //打开SQL连接；
                MessageBox.Show                                                     //在消息框中显示；
                    ("欢迎你！" + "uid" + "!");
                //消息框消息内容；;
                MessageBox.Show                                                                                                     //在消息框中显示；
               ("连接状态：" + sqlConnection.State.ToString()                                                                  //消息框消息内容；
               + "\n工作站标识：" + sqlConnection.WorkstationId
               + "\n服务器地址：" + sqlConnection.DataSource
               + "\n服务器版本：" + sqlConnection.ServerVersion
               + "\n数据库名称：" + sqlConnection.Database);
                this.Hide();
                Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
                form2.ShowDialog();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
