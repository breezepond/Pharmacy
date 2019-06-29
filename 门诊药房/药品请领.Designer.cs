namespace 门诊药房
{
    partial class Frm_Medicineneck
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
            this.lbl_medicinename = new System.Windows.Forms.Label();
            this.Txt_medicinename = new System.Windows.Forms.TextBox();
            this.lbl_account = new System.Windows.Forms.Label();
            this.Txt_accounts = new System.Windows.Forms.TextBox();
            this.lbl_countname = new System.Windows.Forms.Label();
            this.Btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.Txt_reporter = new System.Windows.Forms.TextBox();
            this.Btn_Neck = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ps = new System.Windows.Forms.TextBox();
            this.Lbl_NeckDate = new System.Windows.Forms.Label();
            this.Dtp_NeckDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_medicinename
            // 
            this.lbl_medicinename.AutoSize = true;
            this.lbl_medicinename.Location = new System.Drawing.Point(25, 26);
            this.lbl_medicinename.Name = "lbl_medicinename";
            this.lbl_medicinename.Size = new System.Drawing.Size(65, 12);
            this.lbl_medicinename.TabIndex = 0;
            this.lbl_medicinename.Text = "药品名称：";
            this.lbl_medicinename.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txt_medicinename
            // 
            this.Txt_medicinename.Location = new System.Drawing.Point(96, 23);
            this.Txt_medicinename.Multiline = true;
            this.Txt_medicinename.Name = "Txt_medicinename";
            this.Txt_medicinename.Size = new System.Drawing.Size(166, 21);
            this.Txt_medicinename.TabIndex = 1;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(280, 26);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(65, 12);
            this.lbl_account.TabIndex = 2;
            this.lbl_account.Text = "请领数量：";
            // 
            // Txt_accounts
            // 
            this.Txt_accounts.Location = new System.Drawing.Point(342, 23);
            this.Txt_accounts.Multiline = true;
            this.Txt_accounts.Name = "Txt_accounts";
            this.Txt_accounts.Size = new System.Drawing.Size(99, 21);
            this.Txt_accounts.TabIndex = 3;
            // 
            // lbl_countname
            // 
            this.lbl_countname.AutoSize = true;
            this.lbl_countname.Location = new System.Drawing.Point(418, 26);
            this.lbl_countname.Name = "lbl_countname";
            this.lbl_countname.Size = new System.Drawing.Size(0, 12);
            this.lbl_countname.TabIndex = 4;
            // 
            // Btn_add
            // 
            this.Btn_add.Location = new System.Drawing.Point(420, 220);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(75, 37);
            this.Btn_add.TabIndex = 5;
            this.Btn_add.Text = "查询";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(460, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(77, 12);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "请领人姓名：";
            // 
            // Txt_reporter
            // 
            this.Txt_reporter.Location = new System.Drawing.Point(532, 23);
            this.Txt_reporter.Multiline = true;
            this.Txt_reporter.Name = "Txt_reporter";
            this.Txt_reporter.Size = new System.Drawing.Size(122, 21);
            this.Txt_reporter.TabIndex = 8;
            // 
            // Btn_Neck
            // 
            this.Btn_Neck.Location = new System.Drawing.Point(516, 219);
            this.Btn_Neck.Name = "Btn_Neck";
            this.Btn_Neck.Size = new System.Drawing.Size(75, 39);
            this.Btn_Neck.TabIndex = 9;
            this.Btn_Neck.Text = "请领";
            this.Btn_Neck.UseVisualStyleBackColor = true;
            this.Btn_Neck.Click += new System.EventHandler(this.Btn_Neck_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(611, 219);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 39);
            this.Btn_cancel.TabIndex = 10;
            this.Btn_cancel.Text = "取消";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(27, 62);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(659, 150);
            this.Dgv.TabIndex = 11;
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "备注:";
            // 
            // Txt_ps
            // 
            this.Txt_ps.Location = new System.Drawing.Point(279, 229);
            this.Txt_ps.Name = "Txt_ps";
            this.Txt_ps.Size = new System.Drawing.Size(135, 21);
            this.Txt_ps.TabIndex = 13;
            // 
            // Lbl_NeckDate
            // 
            this.Lbl_NeckDate.AutoSize = true;
            this.Lbl_NeckDate.Location = new System.Drawing.Point(31, 232);
            this.Lbl_NeckDate.Name = "Lbl_NeckDate";
            this.Lbl_NeckDate.Size = new System.Drawing.Size(59, 12);
            this.Lbl_NeckDate.TabIndex = 14;
            this.Lbl_NeckDate.Text = "请领日期:";
            // 
            // Dtp_NeckDate
            // 
            this.Dtp_NeckDate.Location = new System.Drawing.Point(96, 229);
            this.Dtp_NeckDate.Name = "Dtp_NeckDate";
            this.Dtp_NeckDate.Size = new System.Drawing.Size(136, 21);
            this.Dtp_NeckDate.TabIndex = 15;
            // 
            // Frm_Medicineneck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 264);
            this.Controls.Add(this.Dtp_NeckDate);
            this.Controls.Add(this.Lbl_NeckDate);
            this.Controls.Add(this.Txt_ps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_Neck);
            this.Controls.Add(this.Txt_reporter);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.lbl_countname);
            this.Controls.Add(this.Txt_accounts);
            this.Controls.Add(this.lbl_account);
            this.Controls.Add(this.Txt_medicinename);
            this.Controls.Add(this.lbl_medicinename);
            this.Name = "Frm_Medicineneck";
            this.Text = "药物请领";
            this.Load += new System.EventHandler(this.Frm_Medicineneck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medicinename;
        private System.Windows.Forms.TextBox Txt_medicinename;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.TextBox Txt_accounts;
        private System.Windows.Forms.Label lbl_countname;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox Txt_reporter;
        private System.Windows.Forms.Button Btn_Neck;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ps;
        private System.Windows.Forms.Label Lbl_NeckDate;
        private System.Windows.Forms.DateTimePicker Dtp_NeckDate;
    }
}