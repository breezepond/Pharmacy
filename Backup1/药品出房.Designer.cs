namespace 门诊药房
{
    partial class Frm_Medicinesale
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
            this.Txt_Cardid = new System.Windows.Forms.TextBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Btn_Sale = new System.Windows.Forms.Button();
            this.Btn_Showlist = new System.Windows.Forms.Button();
            this.Btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡号：";
            // 
            // Txt_Cardid
            // 
            this.Txt_Cardid.Location = new System.Drawing.Point(55, 18);
            this.Txt_Cardid.Name = "Txt_Cardid";
            this.Txt_Cardid.Size = new System.Drawing.Size(134, 21);
            this.Txt_Cardid.TabIndex = 1;
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(18, 57);
            this.Dgv.Name = "Dgv";
            this.Dgv.RowTemplate.Height = 23;
            this.Dgv.Size = new System.Drawing.Size(510, 216);
            this.Dgv.TabIndex = 2;
            // 
            // Btn_Sale
            // 
            this.Btn_Sale.Location = new System.Drawing.Point(219, 291);
            this.Btn_Sale.Name = "Btn_Sale";
            this.Btn_Sale.Size = new System.Drawing.Size(75, 26);
            this.Btn_Sale.TabIndex = 3;
            this.Btn_Sale.Text = "出房";
            this.Btn_Sale.UseVisualStyleBackColor = true;
            this.Btn_Sale.Click += new System.EventHandler(this.Btn_Sale_Click);
            // 
            // Btn_Showlist
            // 
            this.Btn_Showlist.Location = new System.Drawing.Point(314, 291);
            this.Btn_Showlist.Name = "Btn_Showlist";
            this.Btn_Showlist.Size = new System.Drawing.Size(116, 26);
            this.Btn_Showlist.TabIndex = 4;
            this.Btn_Showlist.Text = "显示出药清单";
            this.Btn_Showlist.UseVisualStyleBackColor = true;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Location = new System.Drawing.Point(453, 291);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 26);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "关闭";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Frm_Medicinesale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 329);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Btn_Showlist);
            this.Controls.Add(this.Btn_Sale);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.Txt_Cardid);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Medicinesale";
            this.Text = "药品出房";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Cardid;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Button Btn_Sale;
        private System.Windows.Forms.Button Btn_Showlist;
        private System.Windows.Forms.Button Btn_Close;
    }
}