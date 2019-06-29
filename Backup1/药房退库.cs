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
    public partial class Frm_Medicineback : Form
    {
        public Frm_Medicineback()
        {
            this.ControlBox = false;   // 设置不出现关闭按钮
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Menu form=new Frm_Menu();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
