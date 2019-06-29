namespace 门诊药房
{
    partial class Frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Com_server = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_psw = new System.Windows.Forms.MaskedTextBox();
            this.Txt_uid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_sql = new System.Windows.Forms.RadioButton();
            this.Btn_win = new System.Windows.Forms.RadioButton();
            this.Btn_confirm = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.ckb_pub = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Com_server);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择服务器";
            // 
            // Com_server
            // 
            this.Com_server.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_server.FormattingEnabled = true;
            this.Com_server.Items.AddRange(new object[] {
            "PharmacySystem"});
            this.Com_server.Location = new System.Drawing.Point(101, 33);
            this.Com_server.Name = "Com_server";
            this.Com_server.Size = new System.Drawing.Size(97, 20);
            this.Com_server.TabIndex = 2;
            this.Com_server.SelectedIndexChanged += new System.EventHandler(this.Com_server_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_psw);
            this.groupBox2.Controls.Add(this.Txt_uid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Btn_sql);
            this.groupBox2.Controls.Add(this.Btn_win);
            this.groupBox2.Location = new System.Drawing.Point(24, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "认证方式";
            // 
            // Txt_psw
            // 
            this.Txt_psw.Location = new System.Drawing.Point(63, 111);
            this.Txt_psw.Name = "Txt_psw";
            this.Txt_psw.PasswordChar = '●';
            this.Txt_psw.Size = new System.Drawing.Size(199, 21);
            this.Txt_psw.TabIndex = 5;
            this.Txt_psw.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txt_psw_TextChanged);
            // 
            // Txt_uid
            // 
            this.Txt_uid.Location = new System.Drawing.Point(63, 84);
            this.Txt_uid.Multiline = true;
            this.Txt_uid.Name = "Txt_uid";
            this.Txt_uid.Size = new System.Drawing.Size(199, 21);
            this.Txt_uid.TabIndex = 4;
            this.Txt_uid.TextChanged += new System.EventHandler(this.Txt_uid_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名：";
            // 
            // Btn_sql
            // 
            this.Btn_sql.AutoSize = true;
            this.Btn_sql.Location = new System.Drawing.Point(33, 52);
            this.Btn_sql.Name = "Btn_sql";
            this.Btn_sql.Size = new System.Drawing.Size(131, 16);
            this.Btn_sql.TabIndex = 1;
            this.Btn_sql.Text = "使用SQL Server验证";
            this.Btn_sql.UseVisualStyleBackColor = true;
            this.Btn_sql.CheckedChanged += new System.EventHandler(this.Btn_sql_CheckedChanged);
            // 
            // Btn_win
            // 
            this.Btn_win.AutoSize = true;
            this.Btn_win.Checked = true;
            this.Btn_win.Location = new System.Drawing.Point(33, 30);
            this.Btn_win.Name = "Btn_win";
            this.Btn_win.Size = new System.Drawing.Size(113, 16);
            this.Btn_win.TabIndex = 0;
            this.Btn_win.TabStop = true;
            this.Btn_win.Text = "使用Windows验证";
            this.Btn_win.UseVisualStyleBackColor = true;
            this.Btn_win.CheckedChanged += new System.EventHandler(this.Btn_win_CheckedChanged);
            // 
            // Btn_confirm
            // 
            this.Btn_confirm.Location = new System.Drawing.Point(148, 248);
            this.Btn_confirm.Name = "Btn_confirm";
            this.Btn_confirm.Size = new System.Drawing.Size(74, 37);
            this.Btn_confirm.TabIndex = 2;
            this.Btn_confirm.Text = "确定";
            this.Btn_confirm.UseVisualStyleBackColor = true;
            this.Btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(250, 248);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(74, 37);
            this.Btn_cancel.TabIndex = 3;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // ckb_pub
            // 
            this.ckb_pub.AutoSize = true;
            this.ckb_pub.Location = new System.Drawing.Point(24, 259);
            this.ckb_pub.Name = "ckb_pub";
            this.ckb_pub.Size = new System.Drawing.Size(72, 16);
            this.ckb_pub.TabIndex = 4;
            this.ckb_pub.Text = "显示密码";
            this.ckb_pub.UseVisualStyleBackColor = true;
            this.ckb_pub.CheckedChanged += new System.EventHandler(this.ckb_pub_CheckedChanged);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 297);
            this.Controls.Add(this.ckb_pub);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_confirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Frm_Login";
            this.Text = "请登录";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_login_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Com_server;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Btn_sql;
        private System.Windows.Forms.RadioButton Btn_win;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Txt_psw;
        private System.Windows.Forms.TextBox Txt_uid;
        private System.Windows.Forms.Button Btn_confirm;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.CheckBox ckb_pub;
    }
}

