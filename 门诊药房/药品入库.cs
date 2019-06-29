using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//添加调用：
using System.Data.SqlClient;                                                                                //包含访问SQL Server所需的各类对象；
using System.IO;                                                                                            //包含输入输出对象；
using System.Drawing.Imaging;
namespace 门诊药房
{
    public partial class Frm_MedicineIn : Form
    {
        public string uid;
        public string psw;
        public string ser;
        private string PhotoFileName;
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


        private void Btn_in_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();                                                 //声明并实例化内存流，用于读取照片的字节数据；
                this.Pb_label.Image.Save(memoryStream, ImageFormat.Bmp);                                       //调用图像框的图像的静态方法Save，将图像保存至内存流；
                byte[] photoBytes = new byte[memoryStream.Length];                                              //声明并实例化字节数组，用于保存照片数据；数组长度对应内存流长度；
                memoryStream.Seek(0, SeekOrigin.Begin);                                                         //保存后的内存流的偏移位置在末尾，需通过查找来将偏移位置设为起始；
                memoryStream.Read(photoBytes, 0, photoBytes.Length);                                            //将内存流读入字节数组；
                SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database='PharmacySystem';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
                SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //声明并实例化SQL命令；
                sqlCommand.Connection = sqlConnection;                                                          //将SQL命令的连接属性指向SQL连接；
                sqlCommand.CommandText = " INSERT MedicineInformation (MedicineName,Produceunit,Producedate,Supplyunit,Stackdate,Commitid,Validity,Qualified,Warehousingid,Uselife,Label,Inno,Abbreviation)values(@MedicineName,@Produceunit,@Producedate,@Supplyunit,@Stackdate,@Commitid,@Validity,@Qualified,@Warehousingid,@UseLife,@Label,@Inno,@Abbreviation)";
                sqlCommand.Parameters.AddWithValue("@MedicineName", this.Txt_baseinfo.Text.Trim());                         //向SQL命令的参数集合添加参数的名称、值；
                sqlCommand.Parameters.AddWithValue("@Produceunit", this.Txt_produceunit.Text);
                sqlCommand.Parameters.AddWithValue("@Producedate", this.Dtp_producedate.Value);
                sqlCommand.Parameters.AddWithValue("@Supplyunit", this.Txt_supplyunit.Text);
                sqlCommand.Parameters.AddWithValue("@Stackdate", this.Dtp_stackdate.Value);
                sqlCommand.Parameters.AddWithValue("@Commitid", this.Txt_commitid.Text);
                sqlCommand.Parameters.AddWithValue("@Validity", this.Dtp_validity.Value);
                sqlCommand.Parameters.AddWithValue("@Qualified", (bool)this.Rbtn_yes.Checked);
                sqlCommand.Parameters.AddWithValue("@Warehousingid", this.Txt_warehousingid.Text);
                sqlCommand.Parameters.AddWithValue("@UseLife", this.Dtp_uselife.Value);
                sqlCommand.Parameters.AddWithValue("@Label", photoBytes);
                sqlCommand.Parameters.AddWithValue("@Stackid", this.Txt_stackid.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Inno", this.Txt_Inno.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Abbreviation", this.Txt_Abbreviation.Text.Trim());

                sqlConnection.Open();                                                                           //打开SQL连接；
                int rowAffected = sqlCommand.ExecuteNonQuery();                                                 //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                sqlConnection.Close();                                                                          //关闭SQL连接；
                MessageBox.Show("更新" + rowAffected.ToString() + "行。");                                      //在消息框显示受影响行数；
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_search_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database='PharmacySystem';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter("select * from MedicineInformation ", sqlConnection);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            DGV.DataSource = d.Tables["t"];
        }

        private void Pb_label_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()                                           //声明并实例化打开文件对话框；
            {                                                                                           //在初始化器中，设置打开文件对话框的各属性；
                Title = "打开照片文件（位图格式）"                                                      //对话框标题；
                   ,
                Filter = "BMP Files (*.bmp)|*.bmp"                                                    //文件格式过滤器；
                   ,
                InitialDirectory = @"C:\"                                                             //初始目录；
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)                                            //显示打开文件对话框，若打开文件对话框的对话结果为点击OK键；
            {
                this.PhotoFileName = openPhotoDialog.FileName;                                              //将对话框获得的文件名，存入本窗体的私有字段中；
                this.Pb_label.Image = Image.FromFile(this.PhotoFileName);                                  //调用图像的静态方法FromFile从指定文件中读取图像，并赋予图像框；
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}