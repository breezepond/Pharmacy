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
        public Frm_Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void 房存处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 药品请领ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineneck form0 = new Frm_Medicineneck(); // Form2为跳转页面的窗体名称
            form0.ShowDialog();
        }

        private void 药品入房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_MedicineIn form1 = new Frm_MedicineIn(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }
        private void Frm_menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Hide();
            }
        }

        private void 药品退房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineoff form1 = new Frm_Medicineoff(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 药品出房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicinesale form1 = new Frm_Medicinesale(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 边缘库存报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_BoardReport form1 = new Frm_BoardReport(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 药房备药ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_MedicineReady form1 = new Frm_MedicineReady(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 过期药品报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Overreport form1 = new Frm_Overreport(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 药品盘点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicinecount form1 = new Frm_Medicinecount(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 药品破损ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicinebroken form1 = new Frm_Medicinebroken(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 药房退库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Medicineback form1 = new Frm_Medicineback(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 入房记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_InRecord form = new Frm_InRecord();
            form.ShowDialog();
        }

        private void 用户管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Useradmin form1 = new Frm_Useradmin(); // Form2为跳转页面的窗体名称
            form1.ShowDialog();
        }

        private void 破损记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Brv form = new Frm_Brv();
            form.ShowDialog();
        }

        private void 门诊退房记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 房存明细查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Ivd form = new Frm_Ivd();
            form.ShowDialog();
        }

        private void 盘点记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_IvRecord form = new Frm_IvRecord();
            form.ShowDialog();
        }

        private void 房存属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
