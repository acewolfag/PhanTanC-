namespace WindowsFormsApp1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_sach = new System.Windows.Forms.DataGridView();
            this.dgv_cn = new System.Windows.Forms.DataGridView();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.dgv_nv = new System.Windows.Forms.DataGridView();
            this.dgv_dh = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "xem thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_sach
            // 
            this.dgv_sach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sach.Location = new System.Drawing.Point(29, 48);
            this.dgv_sach.Name = "dgv_sach";
            this.dgv_sach.Size = new System.Drawing.Size(240, 150);
            this.dgv_sach.TabIndex = 1;
            // 
            // dgv_cn
            // 
            this.dgv_cn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cn.Location = new System.Drawing.Point(132, 221);
            this.dgv_cn.Name = "dgv_cn";
            this.dgv_cn.Size = new System.Drawing.Size(240, 150);
            this.dgv_cn.TabIndex = 2;
            // 
            // dgv_kh
            // 
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kh.Location = new System.Drawing.Point(287, 48);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.Size = new System.Drawing.Size(240, 150);
            this.dgv_kh.TabIndex = 3;
            // 
            // dgv_nv
            // 
            this.dgv_nv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nv.Location = new System.Drawing.Point(427, 221);
            this.dgv_nv.Name = "dgv_nv";
            this.dgv_nv.Size = new System.Drawing.Size(240, 150);
            this.dgv_nv.TabIndex = 4;
            // 
            // dgv_dh
            // 
            this.dgv_dh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dh.Location = new System.Drawing.Point(548, 48);
            this.dgv_dh.Name = "dgv_dh";
            this.dgv_dh.Size = new System.Drawing.Size(240, 150);
            this.dgv_dh.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "trở về truy vấn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chi Nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nhân Viên";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dh);
            this.Controls.Add(this.dgv_nv);
            this.Controls.Add(this.dgv_kh);
            this.Controls.Add(this.dgv_cn);
            this.Controls.Add(this.dgv_sach);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_sach;
        private System.Windows.Forms.DataGridView dgv_cn;
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.DataGridView dgv_nv;
        private System.Windows.Forms.DataGridView dgv_dh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}