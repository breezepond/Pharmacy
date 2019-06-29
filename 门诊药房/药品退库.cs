using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace 门诊药房
{
    public partial class Frm_Medicineoff : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Medicineoff()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void Btn_in_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "server=(local);database=PharmacySystem;integrated security=no;uid=sa;password=2wsx@WSX";
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnection;
            sqlcommand.CommandText = "delete MedicineInformation where MedicineName='" + Txt_baseinfo.Text + "'";

            sqlConnection.Open();                                                                           //打开SQL连接；
            int rowAffected = sqlcommand.ExecuteNonQuery();                                                 //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
            sqlConnection.Close();                                                                          //关闭SQL连接；
            MessageBox.Show("更新" + rowAffected.ToString() + "行。");                                      //在消息框显示受影响行数；

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data1 = Dgv.CurrentRow.Cells[0].Value.ToString();
            Txt_baseinfo.Text = data1;
            string data3 = Dgv.CurrentRow.Cells[12].Value.ToString();
            Txt_produceunit.Text = data3;
            string data4 = Dgv.CurrentRow.Cells[1].Value.ToString();
            DateTime dt1 = DateTime.Parse(data4);
            Dtp_producedate.Value = dt1;
            string data6 = Dgv.CurrentRow.Cells[2].Value.ToString();
            Txt_supplyunit.Text = data6;
            string data8 = Dgv.CurrentRow.Cells[4].Value.ToString();
            Txt_commitid.Text = data8;
            string data9 = Dgv.CurrentRow.Cells[6].Value.ToString();
            DateTime dt3 = DateTime.Parse(data9);
            Dtp_validity.Value = dt3;
            string data10 = Dgv.CurrentRow.Cells[7].Value.ToString();
            Rbtn_yes.Checked = Convert.ToBoolean(data10);
            string data11 = Dgv.CurrentRow.Cells[8].Value.ToString();
            Txt_warehousingid.Text = data11;
            string data12 = Dgv.CurrentRow.Cells[9].Value.ToString();
            DateTime dt4 = DateTime.Parse(data12);
            Dtp_uselife.Value = dt4;
            string data13 = Dgv.CurrentRow.Cells[11].Value.ToString();
            Txt_Abbreviation.Text = data13;
            string data14 = Dgv.CurrentRow.Cells[13].Value.ToString();
            Txt_Inno.Text = data14;

            SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database='PharmacySystem';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from MedicineInformation ;");
            sqlCommand.Connection = sqlConnection;                                                          //将SQL命令的连接属性指向SQL连接；
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();                                      //调用SQL命令的方法ExecuteReader来执行命令，并获取数据阅读器；
            byte[] photoBytes = null;                                                                       //声明字节数组，用于保存照片数据；但先赋予空值；
           
            if (sqlDataReader.Read())                                                                       //若数据阅读器成功读取到下一条记录（首次查询则表示第一条记录）；
            {
                photoBytes =
                    (sqlDataReader["Label"] == DBNull.Value ? null : (byte[])sqlDataReader["Label"]);       //根据照片是否为数据库空值，分别将空值、转为字节数组的照片数据赋予事先声明的字节数组；
            }
            sqlDataReader.Close();                                                                          //关闭数据阅读器（同时关闭连接）；
            if (photoBytes != null)                                                                         //若学生的照片非空；
            {
                MemoryStream memoryStream = new MemoryStream(photoBytes);                                   //声明并实例化内存流，用于读取照片的字节数据；
                Pb_label.Image = Image.FromStream(memoryStream);                                      //调用图像的静态方法FromStream从内存流中读取图像，并赋予图像框；
            }


        }



        private void Btn_Search_Click_1(object sender, EventArgs e)
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
    }
}
