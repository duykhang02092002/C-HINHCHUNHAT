﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_HINHCHUNHAT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            if (txtA.Text =="" ||txtB.Text=="")
            {
                MessageBox.Show("phải nhập chiều dài chiều rộng");
                return;
            }    
            Double a, b, ketqua;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            ketqua = (a + b) * 2;

            txtKQ.Text = ketqua.ToString();
           
        }

        private void btndientich_Click(object sender, EventArgs e)
        {
            Double a, b, ketqua;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            ketqua = (a * b);

            txtKQ.Text = ketqua.ToString();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbChuVi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            if (rdbChuVi.Checked)
            {
                //tính chu vi
                lbltinh.Text = "Chu vi";
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("phải nhập chiều dài chiều rộng");
                    return;
                }
                Double a, b, ketqua;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                ketqua = (a + b) * 2;
                txtKQ.Text = ketqua.ToString();
            }

            if (rdbDienTich.Checked)
            {
                //tính diện t
                lbltinh.Text = "Chu vi";
                if (txtA.Text == "" || txtB.Text == "")
                {
                    MessageBox.Show("phải nhập chiều dài chiều rộng");
                    return;
                }
                Double a, b, ketqua;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                ketqua = (a * b);
                txtKQ.Text = ketqua.ToString();
            }

        }

        private void rdbDienTich_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
