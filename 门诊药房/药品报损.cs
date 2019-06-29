using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace 门诊药房
{
    public partial class Frm_Medicinebroken : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Medicinebroken()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form = new Frm_Menu();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Server=(Local);Database='PharmacySystem';Integrated Security=false;UID='sa';Password='2wsx@WSX';");
                SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //声明并实例化SQL命令；
                sqlCommand.Connection = sqlConnection;                                                          //将SQL命令的连接属性指向SQL连接；
                sqlCommand.CommandText = " INSERT report(MedicineName,ReportAccount,InNo,ProduceUnit,ProduceDate,Supplyunit,Stackdate,Commitid,Validity,Qualified,Warehousingid,Uselife,Reporter,ReportDate,ReportReason,Abbreviation)values(@MedicineName,@ReportAccount,@Inno,@Produceunit,@Producedate,@Supplyunit,@Stackdate,@Commitid,@Validity,@Qualified,@Warehousingid,@UseLife,@Reporter,@ReportDate,@ReportReason,@Abbreviation)";
                sqlCommand.Parameters.AddWithValue("@MedicineName", this.Txt_baseinfo.Text.Trim());                         //向SQL命令的参数集合添加参数的名称、值；
                sqlCommand.Parameters.AddWithValue("@ReportAccount", this.Txt_account.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Inno", this.Txt_Inno.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@ProduceUnit", Txt_produceunit.Text);
                sqlCommand.Parameters.AddWithValue("@ProduceDate", this.Dtp_producedate.Value);
                sqlCommand.Parameters.AddWithValue("@Supplyunit", this.Txt_supplyunit.Text);
                sqlCommand.Parameters.AddWithValue("@Stackdate", this.Dtp_stackdate.Value);
                sqlCommand.Parameters.AddWithValue("@Commitid", this.Txt_commitid.Text);
                sqlCommand.Parameters.AddWithValue("@Validity", this.Dtp_validity.Value);
                sqlCommand.Parameters.AddWithValue("@Qualified", (bool)this.Rbtn_yes.Checked);
                sqlCommand.Parameters.AddWithValue("@Warehousingid", this.Txt_warehousingid.Text);
                sqlCommand.Parameters.AddWithValue("@UseLife", this.Dtp_uselife.Value);
                sqlCommand.Parameters.AddWithValue("@Reporter", this.Cmb_reporter.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@ReportDate", this.Dtp_reportdate.Value);
                sqlCommand.Parameters.AddWithValue("@ReportReason", this.Cmb_reason.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Abbreviation", this.Txt_Abbreviation.Text.Trim());


                sqlConnection.Open();                                                                           //打开SQL连接；
                int rowAffected = sqlCommand.ExecuteNonQuery();                                                 //调用SQL命令的方法ExecuteNonQuery来执行命令，向数据库写入数据，并返回受影响行数；
                sqlConnection.Close();                                                                          //关闭SQL连接；
                MessageBox.Show("更新" + rowAffected.ToString() + "行。");                                      //在消息框显示受影响行数；
            }
            catch (Exception ex)
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
            Dgv.DataSource = d.Tables["t"];
        }

        private void Frm_Medicinebroken_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data1 = Dgv.CurrentRow.Cells[0].Value.ToString();
            Txt_baseinfo.Text = data1;
            string data2 = Dgv.CurrentRow.Cells[10].Value.ToString();
            DateTime dt5 = DateTime.Parse(data2);
            Dtp_reportdate.Value = dt5;
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
        }
    }
}
