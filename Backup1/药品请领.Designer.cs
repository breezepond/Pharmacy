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
            this.Txt_receivecounts = new System.Windows.Forms.TextBox();
            this.lbl_countname = new System.Windows.Forms.Label();
            this.Btn_add = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.Txt_receivename = new System.Windows.Forms.TextBox();
            this.Btn_Neck = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
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
            this.Txt_medicinename.Size = new System.Drawing.Size(271, 21);
            this.Txt_medicinename.TabIndex = 1;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(424, 26);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(65, 12);
            this.lbl_account.TabIndex = 2;
            this.lbl_account.Text = "请领数量：";
            // 
            // Txt_receivecounts
            // 
            this.Txt_receivecounts.Location = new System.Drawing.Point(537, 23);
            this.Txt_receivecounts.Multiline = true;
            this.Txt_receivecounts.Name = "Txt_receivecounts";
            this.Txt_receivecounts.Size = new System.Drawing.Size(99, 21);
            this.Txt_receivecounts.TabIndex = 3;
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
            this.Btn_add.Location = new System.Drawing.Point(688, 14);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(75, 37);
            this.Btn_add.TabIndex = 5;
            this.Btn_add.Text = "添加";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(25, 231);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(77, 12);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "请领人姓名：";
            // 
            // Txt_receivename
            // 
            this.Txt_receivename.Location = new System.Drawing.Point(108, 228);
            this.Txt_receivename.Multiline = true;
            this.Txt_receivename.Name = "Txt_receivename";
            this.Txt_receivename.Size = new System.Drawing.Size(122, 21);
            this.Txt_receivename.TabIndex = 8;
            // 
            // Btn_Neck
            // 
            this.Btn_Neck.Location = new System.Drawing.Point(486, 218);
            this.Btn_Neck.Name = "Btn_Neck";
            this.Btn_Neck.Size = new System.Drawing.Size(75, 39);
            this.Btn_Neck.TabIndex = 9;
            this.Btn_Neck.Text = "请领";
            this.Btn_Neck.UseVisualStyleBackColor = true;
            this.Btn_Neck.Click += new System.EventHandler(this.Btn_Neck_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Location = new System.Drawing.Point(656, 218);
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
            this.Dgv.Size = new System.Drawing.Size(736, 150);
            this.Dgv.TabIndex = 11;
            // 
            // Frm_Medicineneck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 264);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_Neck);
            this.Controls.Add(this.Txt_receivename);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.Btn_add);
            this.Controls.Add(this.lbl_countname);
            this.Controls.Add(this.Txt_receivecounts);
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
        private System.Windows.Forms.TextBox Txt_receivecounts;
        private System.Windows.Forms.Label lbl_countname;
        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox Txt_receivename;
        private System.Windows.Forms.Button Btn_Neck;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.DataGridView Dgv;
    }
}