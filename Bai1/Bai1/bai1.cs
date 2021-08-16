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

namespace Bai1
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        bool checkNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
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

        private void txtSt1_TextChanged(object sender, EventArgs e)
        {
            string sothunhat = txtSt1.Text;
            if (!checkNumber(sothunhat))
            {
                lblResultValue.Text = "Số thứ nhất không hợp lệ";
            } else
            {
                string sothuhai = txtSt2.Text;
                if (!checkNumber(sothuhai))
                {
                    lblResultValue.Text = "Số thứ hai không hợp lệ";
                }
                else
                {
                    int a = int.Parse(sothunhat);
                    int b = int.Parse(sothuhai);
                    lblResultValue.Text = (a + b).ToString();
                }
            }
        }

        private void txtSt2_TextChanged(object sender, EventArgs e)
        {
            string sothunhat = txtSt1.Text;
            if (!checkNumber(sothunhat))
            {
                lblResultValue.Text = "Số thứ nhất không hợp lệ";
            }
            else
            {
                string sothuhai = txtSt2.Text;
                if (!checkNumber(sothuhai))
                {
                    lblResultValue.Text = "Số thứ hai không hợp lệ";
                }
                else
                {
                    int a = int.Parse(sothunhat);
                    int b = int.Parse(sothuhai);
                    lblResultValue.Text = (a + b).ToString();
                }
            }
        }
    }
}
