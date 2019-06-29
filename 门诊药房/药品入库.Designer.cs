namespace 门诊药房
{
    partial class Frm_MedicineIn
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pb_label = new System.Windows.Forms.PictureBox();
            this.Txt_Abbreviation = new System.Windows.Forms.TextBox();
            this.Lbl_Abbreviation = new System.Windows.Forms.Label();
            this.Txt_Inno = new System.Windows.Forms.TextBox();
            this.Lbl_Inno = new System.Windows.Forms.Label();
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
            this.Btn_in = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Dtp_date = new System.Windows.Forms.DateTimePicker();
            this.Btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_label)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(19, 16);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(625, 141);
            this.DGV.TabIndex = 0;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pb_label);
            this.groupBox1.Controls.Add(this.Txt_Abbreviation);
            this.groupBox1.Controls.Add(this.Lbl_Abbreviation);
            this.groupBox1.Controls.Add(this.Txt_Inno);
            this.groupBox1.Controls.Add(this.Lbl_Inno);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "药品基本信息：";
            // 
            // Pb_label
            // 
            this.Pb_label.Location = new System.Drawing.Point(301, 108);
            this.Pb_label.Name = "Pb_label";
            this.Pb_label.Size = new System.Drawing.Size(110, 28);
            this.Pb_label.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb_label.TabIndex = 30;
            this.Pb_label.TabStop = false;
            this.Pb_label.Click += new System.EventHandler(this.Pb_label_Click);
            // 
            // Txt_Abbreviation
            // 
            this.Txt_Abbreviation.Location = new System.Drawing.Point(301, 176);
            this.Txt_Abbreviation.Name = "Txt_Abbreviation";
            this.Txt_Abbreviation.Size = new System.Drawing.Size(110, 21);
            this.Txt_Abbreviation.TabIndex = 34;
            // 
            // Lbl_Abbreviation
            // 
            this.Lbl_Abbreviation.AutoSize = true;
            this.Lbl_Abbreviation.Location = new System.Drawing.Point(241, 179);
            this.Lbl_Abbreviation.Name = "Lbl_Abbreviation";
            this.Lbl_Abbreviation.Size = new System.Drawing.Size(59, 12);
            this.Lbl_Abbreviation.TabIndex = 33;
            this.Lbl_Abbreviation.Text = "药名缩写:";
            // 
            // Txt_Inno
            // 
            this.Txt_Inno.Location = new System.Drawing.Point(91, 176);
            this.Txt_Inno.Name = "Txt_Inno";
            this.Txt_Inno.Size = new System.Drawing.Size(144, 21);
            this.Txt_Inno.TabIndex = 32;
            // 
            // Lbl_Inno
            // 
            this.Lbl_Inno.AutoSize = true;
            this.Lbl_Inno.Location = new System.Drawing.Point(26, 179);
            this.Lbl_Inno.Name = "Lbl_Inno";
            this.Lbl_Inno.Size = new System.Drawing.Size(59, 12);
            this.Lbl_Inno.TabIndex = 31;
            this.Lbl_Inno.Text = "入房编号:";
            // 
            // Rbtn_no
            // 
            this.Rbtn_no.AutoSize = true;
            this.Rbtn_no.Location = new System.Drawing.Point(177, 145);
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
            this.Rbtn_yes.Location = new System.Drawing.Point(108, 145);
            this.Rbtn_yes.Name = "Rbtn_yes";
            this.Rbtn_yes.Size = new System.Drawing.Size(35, 16);
            this.Rbtn_yes.TabIndex = 27;
            this.Rbtn_yes.TabStop = true;
            this.Rbtn_yes.Text = "有";
            this.Rbtn_yes.UseVisualStyleBackColor = true;
            // 
            // Dtp_stackdate
            // 
            this.Dtp_stackdate.Location = new System.Drawing.Point(477, 70);
            this.Dtp_stackdate.Name = "Dtp_stackdate";
            this.Dtp_stackdate.Size = new System.Drawing.Size(128, 21);
            this.Dtp_stackdate.TabIndex = 26;
            // 
            // Dtp_uselife
            // 
            this.Dtp_uselife.Location = new System.Drawing.Point(477, 141);
            this.Dtp_uselife.Name = "Dtp_uselife";
            this.Dtp_uselife.Size = new System.Drawing.Size(128, 21);
            this.Dtp_uselife.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "使用期：";
            // 
            // Txt_warehousingid
            // 
            this.Txt_warehousingid.Location = new System.Drawing.Point(301, 144);
            this.Txt_warehousingid.Name = "Txt_warehousingid";
            this.Txt_warehousingid.Size = new System.Drawing.Size(110, 21);
            this.Txt_warehousingid.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "入库发票号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 147);
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
            this.label7.Location = new System.Drawing.Point(20, 114);
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
            this.label4.Location = new System.Drawing.Point(12, 73);
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
            // Btn_in
            // 
            this.Btn_in.Location = new System.Drawing.Point(400, 378);
            this.Btn_in.Name = "Btn_in";
            this.Btn_in.Size = new System.Drawing.Size(75, 40);
            this.Btn_in.TabIndex = 2;
            this.Btn_in.Text = "入房";
            this.Btn_in.UseVisualStyleBackColor = true;
            this.Btn_in.Click += new System.EventHandler(this.Btn_in_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(508, 378);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 40);
            this.Btn_Close.TabIndex = 3;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 4;
            this.label14.Text = "入房时间：";
            // 
            // Dtp_date
            // 
            this.Dtp_date.Location = new System.Drawing.Point(104, 390);
            this.Dtp_date.Name = "Dtp_date";
            this.Dtp_date.Size = new System.Drawing.Size(129, 21);
            this.Dtp_date.TabIndex = 5;
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(295, 378);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(72, 40);
            this.Btn_search.TabIndex = 6;
            this.Btn_search.Text = "查询";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Frm_MedicineIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 432);
            this.Controls.Add(this.Btn_search);
            this.Controls.Add(this.Dtp_date);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_in);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Name = "Frm_MedicineIn";
            this.Text = "药品入房";
            this.Load += new System.EventHandler(this.Frm_MedicineIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_label)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_produceunit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_baseinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_stackid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dtp_producedate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_commitid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_supplyunit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Dtp_validity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_warehousingid;
        private System.Windows.Forms.DateTimePicker Dtp_stackdate;
        private System.Windows.Forms.DateTimePicker Dtp_uselife;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Btn_in;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker Dtp_date;
        private System.Windows.Forms.RadioButton Rbtn_yes;
        private System.Windows.Forms.PictureBox Pb_label;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.RadioButton Rbtn_no;
        private System.Windows.Forms.TextBox Txt_Inno;
        private System.Windows.Forms.Label Lbl_Inno;
        private System.Windows.Forms.TextBox Txt_Abbreviation;
        private System.Windows.Forms.Label Lbl_Abbreviation;
    }
}