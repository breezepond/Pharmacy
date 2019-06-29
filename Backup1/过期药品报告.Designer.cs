namespace 门诊药房
{
    partial class Frm_Overreport
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
            this.Rbtn_no = new System.Windows.Forms.RadioButton();
            this.Rbtn_yes = new System.Windows.Forms.RadioButton();
            this.Dtp_stackdate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_uselife = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_warehousingid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dtp_validity = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_label = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_commitid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_supplyunit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_stackid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dtp_producedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_produceunit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_baseinfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbtn_no);
            this.groupBox1.Controls.Add(this.Rbtn_yes);
            this.groupBox1.Controls.Add(this.Dtp_stackdate);
            this.groupBox1.Controls.Add(this.Dtp_uselife);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Txt_warehousingid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Dtp_validity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_label);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Txt_commitid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_supplyunit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_stackid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Dtp_producedate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_produceunit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_baseinfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "药品基本信息：";
            // 
            // Rbtn_no
            // 
            this.Rbtn_no.AutoSize = true;
            this.Rbtn_no.Location = new System.Drawing.Point(177, 151);
            this.Rbtn_no.Name = "Rbtn_no";
            this.Rbtn_no.Size = new System.Drawing.Size(35, 16);
            this.Rbtn_no.TabIndex = 28;
            this.Rbtn_no.TabStop = true;
            this.Rbtn_no.Text = "无";
            this.Rbtn_no.UseVisualStyleBackColor = true;
            // 
            // Rbtn_yes
            // 
            this.Rbtn_yes.AutoSize = true;
            this.Rbtn_yes.Location = new System.Drawing.Point(105, 151);
            this.Rbtn_yes.Name = "Rbtn_yes";
            this.Rbtn_yes.Size = new System.Drawing.Size(35, 16);
            this.Rbtn_yes.TabIndex = 27;
            this.Rbtn_yes.TabStop = true;
            this.Rbtn_yes.Text = "有";
            this.Rbtn_yes.UseVisualStyleBackColor = true;
            // 
            // Dtp_stackdate
            // 
            this.Dtp_stackdate.Location = new System.Drawing.Point(477, 73);
            this.Dtp_stackdate.Name = "Dtp_stackdate";
            this.Dtp_stackdate.Size = new System.Drawing.Size(128, 21);
            this.Dtp_stackdate.TabIndex = 26;
            // 
            // Dtp_uselife
            // 
            this.Dtp_uselife.Location = new System.Drawing.Point(477, 147);
            this.Dtp_uselife.Name = "Dtp_uselife";
            this.Dtp_uselife.Size = new System.Drawing.Size(128, 21);
            this.Dtp_uselife.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "使用期：";
            // 
            // Txt_warehousingid
            // 
            this.Txt_warehousingid.Location = new System.Drawing.Point(301, 147);
            this.Txt_warehousingid.Name = "Txt_warehousingid";
            this.Txt_warehousingid.Size = new System.Drawing.Size(110, 21);
            this.Txt_warehousingid.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "入库发票号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "有无合格证：";
            // 
            // Dtp_validity
            // 
            this.Dtp_validity.Location = new System.Drawing.Point(477, 108);
            this.Dtp_validity.Name = "Dtp_validity";
            this.Dtp_validity.Size = new System.Drawing.Size(128, 21);
            this.Dtp_validity.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "有效期：";
            // 
            // Txt_label
            // 
            this.Txt_label.Location = new System.Drawing.Point(301, 108);
            this.Txt_label.Name = "Txt_label";
            this.Txt_label.Size = new System.Drawing.Size(110, 21);
            this.Txt_label.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "注册商标：";
            // 
            // Txt_commitid
            // 
            this.Txt_commitid.Location = new System.Drawing.Point(91, 108);
            this.Txt_commitid.Name = "Txt_commitid";
            this.Txt_commitid.Size = new System.Drawing.Size(144, 21);
            this.Txt_commitid.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "批准文号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "进货日期：";
            // 
            // Txt_supplyunit
            // 
            this.Txt_supplyunit.Location = new System.Drawing.Point(301, 70);
            this.Txt_supplyunit.Multiline = true;
            this.Txt_supplyunit.Name = "Txt_supplyunit";
            this.Txt_supplyunit.Size = new System.Drawing.Size(110, 21);
            this.Txt_supplyunit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "供货单位：";
            // 
            // Txt_stackid
            // 
            this.Txt_stackid.Location = new System.Drawing.Point(91, 70);
            this.Txt_stackid.Multiline = true;
            this.Txt_stackid.Name = "Txt_stackid";
            this.Txt_stackid.Size = new System.Drawing.Size(144, 21);
            this.Txt_stackid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "出库发票号：";
            // 
            // Dtp_producedate
            // 
            this.Dtp_producedate.Location = new System.Drawing.Point(478, 26);
            this.Dtp_producedate.Name = "Dtp_producedate";
            this.Dtp_producedate.Size = new System.Drawing.Size(127, 21);
            this.Dtp_producedate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "生产日期：";
            // 
            // Txt_produceunit
            // 
            this.Txt_produceunit.Location = new System.Drawing.Point(301, 26);
            this.Txt_produceunit.Multiline = true;
            this.Txt_produceunit.Name = "Txt_produceunit";
            this.Txt_produceunit.Size = new System.Drawing.Size(110, 21);
            this.Txt_produceunit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "生产单位：";
            // 
            // Txt_baseinfo
            // 
            this.Txt_baseinfo.Location = new System.Drawing.Point(91, 26);
            this.Txt_baseinfo.Multiline = true;
            this.Txt_baseinfo.Name = "Txt_baseinfo";
            this.Txt_baseinfo.Size = new System.Drawing.Size(144, 21);
            this.Txt_baseinfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "药品基本信息：";
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(435, 398);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(75, 35);
            this.Btn_Report.TabIndex = 3;
            this.Btn_Report.Text = "报损";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(549, 398);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 35);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(30, 13);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(623, 181);
            this.Dgv.TabIndex = 5;
            // 
            // Frm_Overreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 445);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Overreport";
            this.Text = "过期药品报告";
            this.Load += new System.EventHandler(this.过期药品报告_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbtn_no;
        private System.Windows.Forms.RadioButton Rbtn_yes;
        private System.Windows.Forms.DateTimePicker Dtp_stackdate;
        private System.Windows.Forms.DateTimePicker Dtp_uselife;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_warehousingid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Dtp_validity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_commitid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_supplyunit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_stackid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_producedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_produceunit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_baseinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.DataGridView Dgv;
    }
}