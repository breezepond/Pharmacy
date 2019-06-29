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
    public partial class Frm_MedicineIn : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_MedicineIn()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Frm_MedicineIn_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void Frm_MedicineIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Btn_in_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection();                                              //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;                             //配置管理器从配置文件读取连接字符串，并将之赋予SQL连接的连接字符串属性；
            SqlCommand sqlCommand = new SqlCommand();                                                       //声明并实例化SQL命令；
            sqlCommand.Connection = sqlConnection;                                                          //将SQL命令的连接属性指向SQL连接；
            sqlCommand.CommandText =                                                                        //指定SQL命令的命令文本；
                " INSERT Tb_medicineinfo"
                + " INTO Baseinfo=@Baseinfo,Produceunit=@Produceunit,Producedatedate=@Producedatedate,Stackid=@Stackid,Supplyunit=@Supplyunit,Stackdate=@Stackdate,Commitid=@Commitid,Label=@Label,Validity=@Validity,Qualified=@Qualified,Warehousingid=@Warehousingid,Uselife=@Uselife,Date=@Date"
                + " WHERE Stackid=@Stackid;";
            sqlCommand.Parameters.AddWithValue("@Bsseinfo", this.Txt_baseinfo.Text.Trim());                         //向SQL命令的参数集合添加参数的名称、值；
            sqlCommand.Parameters.AddWithValue("@Produceunit", this.Txt_produceunit.Text);
            sqlCommand.Parameters.AddWithValue("@Producedate", this.Dtp_producedate.Value);
            //sqlCommand.Parameters.AddWithValue("@Stackid", (int)this.cmb_Class.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@Stackid", this.Txt_stackid.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Supplyunit", this.Txt_supplyunit.Text);
            sqlCommand.Parameters.AddWithValue("@Stackdate", this.Dtp_stackdate.Value);
            sqlCommand.Parameters.AddWithValue("@Commitid", this.Txt_commitid.Text);
            sqlCommand.Parameters.AddWithValue("@Validity", this.Dtp_validity.Value);
            sqlCommand.Parameters.AddWithValue("@Warehousingid", this.Txt_warehousingid.Text);
            sqlCommand.Parameters.AddWithValue("@UseLife", this.Dtp_uselife.Value);
            sqlConnection.Open();                                                                           //打开SQL连接；
            int rowAffected = sqlCommand.ExecuteNonQuery();                                                 //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            sqlConnection.Close();                                                                          //关闭SQL连接；
            MessageBox.Show("更新" + rowAffected.ToString() + "行。");                                      //在消息框显示受影响行数；
        }

    }
}