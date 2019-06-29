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
    public partial class Frm_Overreport : Form
    {
        public Frm_Overreport()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form2 = new Frm_Menu(); // Form2为跳转页面的窗体名称
            form2.ShowDialog();
        }

        private void 过期药品报告_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {

        }
    }
}
