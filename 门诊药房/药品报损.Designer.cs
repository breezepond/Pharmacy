namespace 门诊药房
{
    partial class Frm_Medicinebroken
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_account = new System.Windows.Forms.TextBox();
            this.Txt_Inno = new System.Windows.Forms.TextBox();
            this.Btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_Abbreviation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Txt_commitid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_supplyunit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dtp_producedate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_baseinfo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.Cmb_reporter = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Dtp_reportdate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.Cmb_reason = new System.Windows.Forms.ComboBox();
            this.Btn_report = new System.Windows.Forms.Button();
            this.Btn_close = new System.Windows.Forms.Button();
            this.Txt_produceunit = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "报损数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "入库号:";
            // 
            // Txt_account
            // 
            this.Txt_account.Location = new System.Drawing.Point(507, 51);
            this.Txt_account.Name = "Txt_account";
            this.Txt_account.Size = new System.Drawing.Size(110, 21);
            this.Txt_account.TabIndex = 4;
            // 
            // Txt_Inno
            // 
            this.Txt_Inno.Location = new System.Drawing.Point(91, 70);
            this.Txt_Inno.Name = "Txt_Inno";
            this.Txt_Inno.Size = new System.Drawing.Size(144, 21);
            this.Txt_Inno.TabIndex = 5;
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(361, 539);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(75, 23);
            this.Btn_search.TabIndex = 6;
            this.Btn_search.Text = "查询";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_produceunit);
            this.groupBox1.Controls.Add(this.Txt_Abbreviation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Rbtn_no);
            this.groupBox1.Controls.Add(this.Rbtn_yes);
            this.groupBox1.Controls.Add(this.Dtp_stackdate);
            this.groupBox1.Controls.Add(this.Dtp_uselife);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.Txt_warehousingid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Dtp_validity);
            this.groupBox1.Controls.Add(this.Txt_Inno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Txt_commitid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Txt_supplyunit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Dtp_producedate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Txt_baseinfo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "药品基本信息：";
            // 
            // Txt_Abbreviation
            // 
            this.Txt_Abbreviation.Location = new System.Drawing.Point(301, 111);
            this.Txt_Abbreviation.Name = "Txt_Abbreviation";
            this.Txt_Abbreviation.Size = new System.Drawing.Size(110, 21);
            this.Txt_Abbreviation.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "药名缩写:";
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
            // Dtp_producedate
            // 
            this.Dtp_producedate.Location = new System.Drawing.Point(478, 26);
            this.Dtp_producedate.Name = "Dtp_producedate";
            this.Dtp_producedate.Size = new System.Drawing.Size(127, 21);
            this.Dtp_producedate.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "生产日期：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "生产单位：";
            // 
            // Txt_baseinfo
            // 
            this.Txt_baseinfo.Location = new System.Drawing.Point(91, 26);
            this.Txt_baseinfo.Multiline = true;
            this.Txt_baseinfo.Name = "Txt_baseinfo";
            this.Txt_baseinfo.Size = new System.Drawing.Size(144, 21);
            this.Txt_baseinfo.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "药品基本信息：";
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(12, 308);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(619, 150);
            this.Dgv.TabIndex = 8;
            this.Dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 496);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "报损人:";
            // 
            // Cmb_reporter
            // 
            this.Cmb_reporter.FormattingEnabled = true;
            this.Cmb_reporter.Location = new System.Drawing.Point(90, 493);
            this.Cmb_reporter.Name = "Cmb_reporter";
            this.Cmb_reporter.Size = new System.Drawing.Size(90, 20);
            this.Cmb_reporter.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(213, 496);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "报损日期:";
            // 
            // Dtp_reportdate
            // 
            this.Dtp_reportdate.Location = new System.Drawing.Point(278, 490);
            this.Dtp_reportdate.Name = "Dtp_reportdate";
            this.Dtp_reportdate.Size = new System.Drawing.Size(124, 21);
            this.Dtp_reportdate.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(431, 496);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "报损原因:";
            // 
            // Cmb_reason
            // 
            this.Cmb_reason.FormattingEnabled = true;
            this.Cmb_reason.Location = new System.Drawing.Point(490, 491);
            this.Cmb_reason.Name = "Cmb_reason";
            this.Cmb_reason.Size = new System.Drawing.Size(79, 20);
            this.Cmb_reason.TabIndex = 14;
            // 
            // Btn_report
            // 
            this.Btn_report.Location = new System.Drawing.Point(446, 539);
            this.Btn_report.Name = "Btn_report";
            this.Btn_report.Size = new System.Drawing.Size(75, 23);
            this.Btn_report.TabIndex = 15;
            this.Btn_report.Text = "报损";
            this.Btn_report.UseVisualStyleBackColor = true;
            this.Btn_report.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_close
            // 
            this.Btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_close.Location = new System.Drawing.Point(527, 539);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 16;
            this.Btn_close.Text = "关闭";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.button3_Click);
            // 
            // Txt_produceunit
            // 
            this.Txt_produceunit.Location = new System.Drawing.Point(301, 26);
            this.Txt_produceunit.Name = "Txt_produceunit";
            this.Txt_produceunit.Size = new System.Drawing.Size(110, 21);
            this.Txt_produceunit.TabIndex = 31;
            // 
            // Frm_Medicinebroken
            // 
            this.AcceptButton = this.Btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_close;
            this.ClientSize = new System.Drawing.Size(646, 574);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.Btn_report);
            this.Controls.Add(this.Cmb_reason);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Dtp_reportdate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Cmb_reporter);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Txt_account);
            this.Controls.Add(this.label2);
            this.KeyPreview = true;
            this.Name = "Frm_Medicinebroken";
            this.Text = "药品报损";
            this.Load += new System.EventHandler(this.Frm_Medicinebroken_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_account;
        private System.Windows.Forms.TextBox Txt_Inno;
        private System.Windows.Forms.Button Btn_search;
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
        private System.Windows.Forms.TextBox Txt_commitid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_supplyunit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Dtp_producedate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Txt_baseinfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Cmb_reporter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker Dtp_reportdate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Cmb_reason;
        private System.Windows.Forms.Button Btn_report;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.TextBox Txt_Abbreviation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_produceunit;
    }
}