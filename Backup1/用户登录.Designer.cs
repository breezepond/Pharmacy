namespace 门诊药房
{
    partial class Frm_Userlogin
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
            this.lbl_workid = new System.Windows.Forms.Label();
            this.lbl_workpsw = new System.Windows.Forms.Label();
            this.Txt_workid = new System.Windows.Forms.TextBox();
            this.Txt_workpsw = new System.Windows.Forms.TextBox();
            this.Btn_confirm = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_workid
            // 
            this.lbl_workid.AutoSize = true;
            this.lbl_workid.Location = new System.Drawing.Point(31, 34);
            this.lbl_workid.Name = "lbl_workid";
            this.lbl_workid.Size = new System.Drawing.Size(77, 12);
            this.lbl_workid.TabIndex = 0;
            this.lbl_workid.Text = "访问者工号：";
            // 
            // lbl_workpsw
            // 
            this.lbl_workpsw.AutoSize = true;
            this.lbl_workpsw.Location = new System.Drawing.Point(31, 75);
            this.lbl_workpsw.Name = "lbl_workpsw";
            this.lbl_workpsw.Size = new System.Drawing.Size(77, 12);
            this.lbl_workpsw.TabIndex = 1;
            this.lbl_workpsw.Text = "访问者密码：";
            // 
            // Txt_workid
            // 
            this.Txt_workid.Location = new System.Drawing.Point(105, 31);
            this.Txt_workid.Multiline = true;
            this.Txt_workid.Name = "Txt_workid";
            this.Txt_workid.Size = new System.Drawing.Size(175, 21);
            this.Txt_workid.TabIndex = 2;
            // 
            // Txt_workpsw
            // 
            this.Txt_workpsw.Location = new System.Drawing.Point(105, 72);
            this.Txt_workpsw.Name = "Txt_workpsw";
            this.Txt_workpsw.Size = new System.Drawing.Size(175, 21);
            this.Txt_workpsw.TabIndex = 3;
            // 
            // Btn_confirm
            // 
            this.Btn_confirm.Location = new System.Drawing.Point(43, 111);
            this.Btn_confirm.Name = "Btn_confirm";
            this.Btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_confirm.TabIndex = 4;
            this.Btn_confirm.Text = "确定";
            this.Btn_confirm.UseVisualStyleBackColor = true;
            this.Btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_cancel.Location = new System.Drawing.Point(205, 111);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancel.TabIndex = 5;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Frm_Userlogin
            // 
            this.AcceptButton = this.Btn_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_cancel;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_confirm);
            this.Controls.Add(this.Txt_workpsw);
            this.Controls.Add(this.Txt_workid);
            this.Controls.Add(this.lbl_workpsw);
            this.Controls.Add(this.lbl_workid);
            this.KeyPreview = true;
            this.Name = "Frm_Userlogin";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Frm_Userlogin_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_workid;
        private System.Windows.Forms.Label lbl_workpsw;
        private System.Windows.Forms.TextBox Txt_workid;
        private System.Windows.Forms.TextBox Txt_workpsw;
        private System.Windows.Forms.Button Btn_confirm;
        private System.Windows.Forms.Button Btn_cancel;
    }
}