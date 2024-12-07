namespace WindowsFormsApp1
{
    partial class Form1
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
            this.cbx_cn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_nv = new System.Windows.Forms.ComboBox();
            this.cbx_hd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_kh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_sach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbx_cn
            // 
            this.cbx_cn.FormattingEnabled = true;
            this.cbx_cn.Location = new System.Drawing.Point(213, 57);
            this.cbx_cn.Name = "cbx_cn";
            this.cbx_cn.Size = new System.Drawing.Size(121, 21);
            this.cbx_cn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhân viên";
            // 
            // cbx_nv
            // 
            this.cbx_nv.FormattingEnabled = true;
            this.cbx_nv.Location = new System.Drawing.Point(213, 101);
            this.cbx_nv.Name = "cbx_nv";
            this.cbx_nv.Size = new System.Drawing.Size(121, 21);
            this.cbx_nv.TabIndex = 3;
            // 
            // cbx_hd
            // 
            this.cbx_hd.FormattingEnabled = true;
            this.cbx_hd.Location = new System.Drawing.Point(213, 146);
            this.cbx_hd.Name = "cbx_hd";
            this.cbx_hd.Size = new System.Drawing.Size(121, 21);
            this.cbx_hd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hóa đơn";
            // 
            // cbx_kh
            // 
            this.cbx_kh.FormattingEnabled = true;
            this.cbx_kh.Location = new System.Drawing.Point(213, 185);
            this.cbx_kh.Name = "cbx_kh";
            this.cbx_kh.Size = new System.Drawing.Size(121, 21);
            this.cbx_kh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách Hàng";
            // 
            // cbx_sach
            // 
            this.cbx_sach.FormattingEnabled = true;
            this.cbx_sach.Location = new System.Drawing.Point(213, 222);
            this.cbx_sach.Name = "cbx_sach";
            this.cbx_sach.Size = new System.Drawing.Size(121, 21);
            this.cbx_sach.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sách";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(213, 285);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 5;
            this.btn_tim.Text = "Tìm kiếm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_sach);
            this.Controls.Add(this.cbx_kh);
            this.Controls.Add(this.cbx_hd);
            this.Controls.Add(this.cbx_nv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_cn);
            this.Name = "Form1";
            this.Text = "Truy vấn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_cn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_nv;
        private System.Windows.Forms.ComboBox cbx_hd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_kh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_sach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button button1;
    }
}

