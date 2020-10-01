using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
    public partial class Form1 : Form
    {
        int kq = 0;
        string pheptinh = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ketqua.Text= Convert.ToString(kq);
        }

        private void bay_Click(object sender, EventArgs e)
        {
            if (pheptinh == null) kq = 7;
            else
            {
                if (pheptinh == "cong") kq += 7;
                else
                {
                    if (pheptinh == "tru") kq -= 7;
                    else
                    {
                        if (pheptinh == "nhan") kq *= 7;
                        else kq /= 7;
                    }                        
                }    
            }
            hienthi.Text = hienthi.Text + "7" ;
            
        }

        private void tam_Click(object sender, EventArgs e)
        {
            if (pheptinh == null) kq = 8;
            else
            {
                if (pheptinh == "cong") kq += 8;
                else
                {
                    if (pheptinh == "tru") kq -= 8;
                    else
                    {
                        if (pheptinh == "nhan") kq *= 8;
                        else kq /= 8;
                    }
                }
            }
            hienthi.Text = hienthi.Text + "8";
        }

        private void chin_Click(object sender, EventArgs e)
        {
            if (pheptinh == null) kq = 9;
            else
            {
                if (pheptinh == "cong") kq += 9;
                else
                {
                    if (pheptinh == "tru") kq -= 9;
                    else
                    {
                        if (pheptinh == "nhan") kq *= 9;
                        else kq /= 9;
                    }
                }
            }
            hienthi.Text = hienthi.Text + "9";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            hienthi.Text = hienthi.Text + " + ";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            hienthi.Text = hienthi.Text + " - ";
        }

        private void del_Click(object sender, EventArgs e)
        {
            hienthi.Text = "";
            ketqua.Text = "";
            kq = 0;
            pheptinh = null;
        }
    }
}
