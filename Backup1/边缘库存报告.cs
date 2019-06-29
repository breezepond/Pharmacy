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
    public partial class Frm_BoardReport : Form
    {
        public Frm_BoardReport()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
