using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        bool checkNumber(string input)
        {
            Regex regex = new Regex("^-?[0-9]+$");
            return regex.IsMatch(input);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "He thong", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            return;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string a = txtSt1.Text;
            string b = txtSt2.Text;
            string c = txtSt3.Text;
            if (!checkNumber(a) || !checkNumber(b) || !checkNumber(c))
            {
                MessageBox.Show("Du lieu khong hop le!", "He thong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int st1 = int.Parse(a);
            int st2 = int.Parse(b);
            int st3 = int.Parse(c);
            int max = st1;
            int min = st2;
            if (st1 < st2)
            {
                min = st1;
                max = st2;
                if (st2 < st3)
                {
                    max = st3;
                }
                if (st3 < st1)
                {
                    min = st3;
                }
            } else
            {
                if (st1 < st3)
                {
                    max = st3;
                }
                if (st2 > st3)
                {
                    min = st3;
                }
            }
            lblMinValue.Text = min.ToString();
            lblMaxValue.Text = max.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSt1.Text = "";
            txtSt2.Text = "";
            txtSt3.Text = "";
            lblMinValue.Text = "0";
            lblMaxValue.Text = "0";
        }
    }
}
