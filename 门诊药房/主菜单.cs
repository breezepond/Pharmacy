using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 门诊药房
{
    public partial class Frm_Menu : Form
    {
        public string uid;
        public string psw;
        public string ser;
        public Frm_Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        private void 药品请领ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineneck form0 = new Frm_Medicineneck(); // Form2为跳转页面的窗体名称
            form0.uid = uid;
            form0.psw = psw;
            form0.ser = ser;
            form0.ShowDialog();
        }

        private void 药品入房ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Frm_menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Hide();
            }
        }

        private void Menu__Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineneck form0 = new Frm_Medicineneck(); // Form2为跳转页面的窗体名称
            form0.uid = uid;
            form0.psw = psw;
            form0.ser = ser;
            form0.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineoff form1 = new Frm_Medicineoff(); // Form2为跳转页面的窗体名称
            form1.uid = uid;
            form1.psw = psw;
            form1.ser = ser;
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_MedicineIn form1 = new Frm_MedicineIn(); // Form2为跳转页面的窗体名称
            form1.uid = uid;
            form1.psw = psw;
            form1.ser = ser;
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicinebroken form1 = new Frm_Medicinebroken(); // Form2为跳转页面的窗体名称
            form1.uid = uid;
            form1.psw = psw;
            form1.ser = ser;
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Useradmin form1 = new Frm_Useradmin(); // Form2为跳转页面的窗体名称
            form1.uid = uid;
            form1.psw = psw;
            form1.ser = ser;
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要注销？", "注销确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
            this.Hide();
            Frm_Login form2 = new Frm_Login(); // Form2为跳转页面的窗体名称
            form2.uid = uid;
            form2.psw = psw;
            form2.ser = ser;
            form2.ShowDialog();
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭系统吗？", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
