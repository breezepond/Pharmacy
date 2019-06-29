namespace 门诊药房
{
    partial class Frm_MedicineReady
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
            this.Dtp_Startdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_endate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbtn_rortbymedicine = new System.Windows.Forms.RadioButton();
            this.Rbtn_sortbypaitient = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始日期：";
            // 
            // Dtp_Startdate
            // 
            this.Dtp_Startdate.Location = new System.Drawing.Point(74, 20);
            this.Dtp_Startdate.Name = "Dtp_Startdate";
            this.Dtp_Startdate.Size = new System.Drawing.Size(129, 21);
            this.Dtp_Startdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "结束日期：";
            // 
            // Dtp_endate
            // 
            this.Dtp_endate.Location = new System.Drawing.Point(74, 66);
            this.Dtp_endate.Name = "Dtp_endate";
            this.Dtp_endate.Size = new System.Drawing.Size(129, 21);
            this.Dtp_endate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbtn_rortbymedicine);
            this.groupBox1.Controls.Add(this.Rbtn_sortbypaitient);
            this.groupBox1.Location = new System.Drawing.Point(210, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分组方式";
            // 
            // Rbtn_rortbymedicine
            // 
            this.Rbtn_rortbymedicine.AutoSize = true;
            this.Rbtn_rortbymedicine.Location = new System.Drawing.Point(23, 57);
            this.Rbtn_rortbymedicine.Name = "Rbtn_rortbymedicine";
            this.Rbtn_rortbymedicine.Size = new System.Drawing.Size(83, 16);
            this.Rbtn_rortbymedicine.TabIndex = 1;
            this.Rbtn_rortbymedicine.TabStop = true;
            this.Rbtn_rortbymedicine.Text = "按药品分组";
            this.Rbtn_rortbymedicine.UseVisualStyleBackColor = true;
            // 
            // Rbtn_sortbypaitient
            // 
            this.Rbtn_sortbypaitient.AutoSize = true;
            this.Rbtn_sortbypaitient.Location = new System.Drawing.Point(23, 20);
            this.Rbtn_sortbypaitient.Name = "Rbtn_sortbypaitient";
            this.Rbtn_sortbypaitient.Size = new System.Drawing.Size(83, 16);
            this.Rbtn_sortbypaitient.TabIndex = 0;
            this.Rbtn_sortbypaitient.TabStop = true;
            this.Rbtn_sortbypaitient.Text = "按病人分组";
            this.Rbtn_sortbypaitient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "关闭";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(14, 99);
            this.DGV.Name = "DGV";
            this.DGV.RowTemplate.Height = 23;
            this.DGV.Size = new System.Drawing.Size(452, 150);
            this.DGV.TabIndex = 7;
            // 
            // Frm_MedicineReady
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dtp_endate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtp_Startdate);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MedicineReady";
            this.Text = "药房备药";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp_Startdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_endate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbtn_rortbymedicine;
        private System.Windows.Forms.RadioButton Rbtn_sortbypaitient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DGV;
    }
}