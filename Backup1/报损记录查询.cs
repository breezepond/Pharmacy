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
    public partial class Frm_Brv : Form
    {
        public Frm_Brv()
        {
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            InitializeComponent();
            this.ControlBox = false;   // 设置不出现关闭按钮
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form = new Frm_Menu();
            form.ShowDialog();

        }

        private void Frm_Brv_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
