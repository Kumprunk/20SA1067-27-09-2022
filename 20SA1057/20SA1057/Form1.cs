using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20SA1057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtname.Focus();
            txtsop.Visible=false;
            txtrica.Visible=false;
            txtteh.Visible = false;
            txttotal.ReadOnly = true;
        }

        private void sop_ayam_CheckedChanged(object sender, EventArgs e)
        {
            if (sop_ayam.Checked == true) {
                txtsop.Visible = true;
                txtsop.Focus();
            }
            else {
                txtsop.Visible = false;
            }
        }

        private void ayam_rica_CheckedChanged(object sender, EventArgs e)
        {
            if (ayam_rica.Checked == true)
            {
                txtrica.Visible = true;
                txtrica.Focus();
            }
            else
            {
                txtrica.Visible = false;
            }
        }

        private void es_teh_CheckedChanged(object sender, EventArgs e)
        {
            if (es_teh.Checked == true)
            {
                txtteh.Visible = true;
                txtteh.Focus();
            }
            else
            {
                txtteh.Visible = false;
            }
        }

        private void btn_hitung_Click(object sender, EventArgs e)
        {
            double total = 0;
            int sop, rica, teh;

            if (sop_ayam.Checked) {
                sop = int.Parse(txtsop.Text);
                total = total + 9000 * sop;
            }

            if (ayam_rica.Checked)
            {
                rica = int.Parse(txtrica.Text);
                total = total + 8500 * rica;
            }

            if (es_teh.Checked)
            {
                teh = int.Parse(txtteh.Text);
                total = total + 2000 * teh;
            }

            if (rbYa.Checked)
            {
                total = total - 0.25 * total;
                txttotal.Text = total.ToString();
            }

            else 
            {
                txttotal.Text = total.ToString();
            }
        }

        
    }
}
