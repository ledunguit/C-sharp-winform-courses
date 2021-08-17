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

namespace Bai3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        bool checkNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(input))
            {
                int number = int.Parse(input);
                if (number >= 0 && number <= 9)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string a = txtNumber.Text;
            if (!checkNumber(a))
            {
                MessageBox.Show("Du lieu khong hop le", "He thong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int number = int.Parse(a);
            string result;
            switch (number)
            {
                case 0:
                    result = "Không";
                    break;
                case 1:
                    result = "Một";
                    break;
                case 2:
                    result = "Hai";
                    break;
                case 3:
                    result = "Ba";
                    break;
                case 4:
                    result = "Bốn";
                    break;
                case 5:
                    result = "Năm";
                    break;
                case 6:
                    result = "Sáu";
                    break;
                case 7:
                    result = "Bảy";
                    break;
                case 8:
                    result = "Tám";
                    break;
                case 9:
                    result = "Chín";
                    break;
                default:
                    result = "Dữ liệu không hợp lệ!";
                    break;
            }
            txtResult.Text = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
