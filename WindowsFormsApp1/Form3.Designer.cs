namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dgv_PC = new System.Windows.Forms.DataGridView();
            this.dgv_KM = new System.Windows.Forms.DataGridView();
            this.dgv_ct = new System.Windows.Forms.DataGridView();
            this.dgv_dgs = new System.Windows.Forms.DataGridView();
            this.dgv_ht = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PC
            // 
            this.dgv_PC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PC.Location = new System.Drawing.Point(12, 47);
            this.dgv_PC.Name = "dgv_PC";
            this.dgv_PC.Size = new System.Drawing.Size(240, 150);
            this.dgv_PC.TabIndex = 0;
            // 
            // dgv_KM
            // 
            this.dgv_KM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KM.Location = new System.Drawing.Point(290, 47);
            this.dgv_KM.Name = "dgv_KM";
            this.dgv_KM.Size = new System.Drawing.Size(240, 150);
            this.dgv_KM.TabIndex = 0;
            // 
            // dgv_ct
            // 
            this.dgv_ct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ct.Location = new System.Drawing.Point(552, 47);
            this.dgv_ct.Name = "dgv_ct";
            this.dgv_ct.Size = new System.Drawing.Size(240, 150);
            this.dgv_ct.TabIndex = 0;
            // 
            // dgv_dgs
            // 
            this.dgv_dgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dgs.Location = new System.Drawing.Point(130, 243);
            this.dgv_dgs.Name = "dgv_dgs";
            this.dgv_dgs.Size = new System.Drawing.Size(240, 150);
            this.dgv_dgs.TabIndex = 0;
            // 
            // dgv_ht
            // 
            this.dgv_ht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ht.Location = new System.Drawing.Point(419, 243);
            this.dgv_ht.Name = "dgv_ht";
            this.dgv_ht.Size = new System.Drawing.Size(240, 150);
            this.dgv_ht.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "trở về truy vấn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "trở lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phiếu Chuyển kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khuyến Mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chi Tiết Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hàng Tồn Kho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đánh Giá Sách";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv_ct);
            this.Controls.Add(this.dgv_KM);
            this.Controls.Add(this.dgv_ht);
            this.Controls.Add(this.dgv_dgs);
            this.Controls.Add(this.dgv_PC);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PC;
        private System.Windows.Forms.DataGridView dgv_KM;
        private System.Windows.Forms.DataGridView dgv_ct;
        private System.Windows.Forms.DataGridView dgv_dgs;
        private System.Windows.Forms.DataGridView dgv_ht;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}