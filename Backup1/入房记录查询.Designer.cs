namespace 门诊药房
{
    partial class Frm_InRecord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Inputspell = new System.Windows.Forms.TextBox();
            this.Txt_Inputno = new System.Windows.Forms.TextBox();
            this.Txt_Inputstandard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Dtp_Begin = new System.Windows.Forms.DateTimePicker();
            this.Dtp_End = new System.Windows.Forms.DateTimePicker();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_Inputstandard);
            this.groupBox1.Controls.Add(this.Txt_Inputno);
            this.groupBox1.Controls.Add(this.Txt_Inputspell);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择药品:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入药品拼音:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "请输入药品编号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入药品规格:";
            // 
            // Txt_Inputspell
            // 
            this.Txt_Inputspell.Location = new System.Drawing.Point(118, 24);
            this.Txt_Inputspell.Name = "Txt_Inputspell";
            this.Txt_Inputspell.Size = new System.Drawing.Size(100, 21);
            this.Txt_Inputspell.TabIndex = 3;
            // 
            // Txt_Inputno
            // 
            this.Txt_Inputno.Location = new System.Drawing.Point(118, 60);
            this.Txt_Inputno.Name = "Txt_Inputno";
            this.Txt_Inputno.Size = new System.Drawing.Size(100, 21);
            this.Txt_Inputno.TabIndex = 4;
            // 
            // Txt_Inputstandard
            // 
            this.Txt_Inputstandard.Location = new System.Drawing.Point(118, 101);
            this.Txt_Inputstandard.Name = "Txt_Inputstandard";
            this.Txt_Inputstandard.Size = new System.Drawing.Size(100, 21);
            this.Txt_Inputstandard.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "起始日期:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "结束日期:";
            // 
            // Dtp_Begin
            // 
            this.Dtp_Begin.Location = new System.Drawing.Point(339, 36);
            this.Dtp_Begin.Name = "Dtp_Begin";
            this.Dtp_Begin.Size = new System.Drawing.Size(122, 21);
            this.Dtp_Begin.TabIndex = 3;
            // 
            // Dtp_End
            // 
            this.Dtp_End.Location = new System.Drawing.Point(338, 75);
            this.Dtp_End.Name = "Dtp_End";
            this.Dtp_End.Size = new System.Drawing.Size(122, 21);
            this.Dtp_End.TabIndex = 4;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(473, 39);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(75, 33);
            this.Btn_Search.TabIndex = 5;
            this.Btn_Search.Text = "查询";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(473, 104);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 37);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 169);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(536, 150);
            this.Dgv.TabIndex = 8;
            // 
            // Frm_InRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 353);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.Dtp_End);
            this.Controls.Add(this.Dtp_Begin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_InRecord";
            this.Text = "入房记录查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Inputstandard;
        private System.Windows.Forms.TextBox Txt_Inputno;
        private System.Windows.Forms.TextBox Txt_Inputspell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dtp_Begin;
        private System.Windows.Forms.DateTimePicker Dtp_End;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView Dgv;
    }
}