namespace C_HINHCHUNHAT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnchuvi = new System.Windows.Forms.Button();
            this.btndientich = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChuVi = new System.Windows.Forms.RadioButton();
            this.rdbDienTich = new System.Windows.Forms.RadioButton();
            this.lbltinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Hình Chữ Nhật";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(335, 95);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(335, 124);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKQ.Location = new System.Drawing.Point(263, 171);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(44, 13);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(335, 168);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 6;
            // 
            // btnchuvi
            // 
            this.btnchuvi.Location = new System.Drawing.Point(266, 253);
            this.btnchuvi.Name = "btnchuvi";
            this.btnchuvi.Size = new System.Drawing.Size(75, 23);
            this.btnchuvi.TabIndex = 7;
            this.btnchuvi.Text = "chu vi";
            this.btnchuvi.UseVisualStyleBackColor = true;
            this.btnchuvi.Click += new System.EventHandler(this.btnchuvi_Click);
            // 
            // btndientich
            // 
            this.btndientich.Location = new System.Drawing.Point(417, 253);
            this.btndientich.Name = "btndientich";
            this.btndientich.Size = new System.Drawing.Size(75, 23);
            this.btndientich.TabIndex = 8;
            this.btndientich.Text = "diện tich";
            this.btndientich.UseVisualStyleBackColor = true;
            this.btndientich.Click += new System.EventHandler(this.btndientich_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDienTich);
            this.groupBox1.Controls.Add(this.rdbChuVi);
            this.groupBox1.Location = new System.Drawing.Point(686, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 132);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdbChuVi
            // 
            this.rdbChuVi.AutoSize = true;
            this.rdbChuVi.Location = new System.Drawing.Point(34, 36);
            this.rdbChuVi.Name = "rdbChuVi";
            this.rdbChuVi.Size = new System.Drawing.Size(55, 17);
            this.rdbChuVi.TabIndex = 0;
            this.rdbChuVi.TabStop = true;
            this.rdbChuVi.Text = "Chu vi";
            this.rdbChuVi.UseVisualStyleBackColor = true;
            this.rdbChuVi.CheckedChanged += new System.EventHandler(this.rdbChuVi_CheckedChanged);
            // 
            // rdbDienTich
            // 
            this.rdbDienTich.AutoSize = true;
            this.rdbDienTich.Location = new System.Drawing.Point(34, 59);
            this.rdbDienTich.Name = "rdbDienTich";
            this.rdbDienTich.Size = new System.Drawing.Size(69, 17);
            this.rdbDienTich.TabIndex = 1;
            this.rdbDienTich.TabStop = true;
            this.rdbDienTich.Text = "Diện tích";
            this.rdbDienTich.UseVisualStyleBackColor = true;
            this.rdbDienTich.CheckedChanged += new System.EventHandler(this.rdbDienTich_CheckedChanged);
            // 
            // lbltinh
            // 
            this.lbltinh.Location = new System.Drawing.Point(822, 221);
            this.lbltinh.Name = "lbltinh";
            this.lbltinh.Size = new System.Drawing.Size(75, 20);
            this.lbltinh.TabIndex = 11;
            this.lbltinh.Text = "tính";
            this.lbltinh.UseVisualStyleBackColor = true;
            this.lbltinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1125, 450);
            this.Controls.Add(this.lbltinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndientich);
            this.Controls.Add(this.btnchuvi);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDienTich;
        private System.Windows.Forms.RadioButton rdbChuVi;
        private System.Windows.Forms.Button lbltinh;
    }
}

