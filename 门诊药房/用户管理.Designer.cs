namespace 门诊药房
{
    partial class Frm_Useradmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_uid = new System.Windows.Forms.TextBox();
            this.Txt_oldpsw = new System.Windows.Forms.TextBox();
            this.Txt_newpsw = new System.Windows.Forms.TextBox();
            this.Txt_pswconfirm = new System.Windows.Forms.TextBox();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "原密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(30, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // Txt_uid
            // 
            this.Txt_uid.Location = new System.Drawing.Point(95, 32);
            this.Txt_uid.Multiline = true;
            this.Txt_uid.Name = "Txt_uid";
            this.Txt_uid.Size = new System.Drawing.Size(207, 21);
            this.Txt_uid.TabIndex = 4;
            // 
            // Txt_oldpsw
            // 
            this.Txt_oldpsw.Location = new System.Drawing.Point(95, 75);
            this.Txt_oldpsw.Multiline = true;
            this.Txt_oldpsw.Name = "Txt_oldpsw";
            this.Txt_oldpsw.PasswordChar = '*';
            this.Txt_oldpsw.Size = new System.Drawing.Size(207, 21);
            this.Txt_oldpsw.TabIndex = 5;
            // 
            // Txt_newpsw
            // 
            this.Txt_newpsw.Location = new System.Drawing.Point(95, 116);
            this.Txt_newpsw.Multiline = true;
            this.Txt_newpsw.Name = "Txt_newpsw";
            this.Txt_newpsw.PasswordChar = '*';
            this.Txt_newpsw.Size = new System.Drawing.Size(207, 21);
            this.Txt_newpsw.TabIndex = 6;
            // 
            // Txt_pswconfirm
            // 
            this.Txt_pswconfirm.Location = new System.Drawing.Point(95, 153);
            this.Txt_pswconfirm.Multiline = true;
            this.Txt_pswconfirm.Name = "Txt_pswconfirm";
            this.Txt_pswconfirm.PasswordChar = '*';
            this.Txt_pswconfirm.Size = new System.Drawing.Size(207, 21);
            this.Txt_pswconfirm.TabIndex = 7;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(123, 199);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 32);
            this.Btn_Confirm.TabIndex = 8;
            this.Btn_Confirm.Text = "确认";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(227, 199);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 32);
            this.Btn_Close.TabIndex = 9;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Frm_Useradmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 243);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Txt_pswconfirm);
            this.Controls.Add(this.Txt_newpsw);
            this.Controls.Add(this.Txt_oldpsw);
            this.Controls.Add(this.Txt_uid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Useradmin";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.Frm_useradmin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_uid;
        private System.Windows.Forms.TextBox Txt_oldpsw;
        private System.Windows.Forms.TextBox Txt_newpsw;
        private System.Windows.Forms.TextBox Txt_pswconfirm;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Close;
    }
}