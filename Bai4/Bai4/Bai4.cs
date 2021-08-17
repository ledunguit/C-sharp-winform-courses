using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        NumberFormatInfo VND = new CultureInfo("vi-VN", false).NumberFormat;

        bool checkNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        private void txtInputCurrency_TextChanged(object sender, EventArgs e)
        {
            string currency = txtInputCurrency.Text;
            if (!checkNumber(currency))
            {
                txtResult.Text = "Dữ liệu không hợp lệ!";
                return;
            }
            int selected = cbbCurrency.SelectedIndex;
            int input = int.Parse(currency);
            switch (selected)
            {
                case 0:
                    txtResult.Text = (input * 22772).ToString("C3", VND);
                    lblRateValue.Text = "1 USD = 22,772 VNĐ";
                    break;
                case 1:
                    txtResult.Text = (input * 28132).ToString("C3", VND);
                    lblRateValue.Text = "1 EUR = 28,132 VNĐ";
                    break;
                case 2:
                    txtResult.Text = (input * 31538).ToString("C3", VND);
                    lblRateValue.Text = "1 GBP = 31,538 VNĐ";
                    break;
                case 3:
                    txtResult.Text = (input * 17286).ToString("C3", VND);
                    lblRateValue.Text = "1 SGD = 17,286 VNĐ";
                    break;
                case 4:
                    txtResult.Text = (input * 214).ToString("C3", VND);
                    lblRateValue.Text = "1 JPY = 214 VNĐ";
                    break;
                default:
                    txtResult.Text = "Dữ liệu không hợp lệ!";
                    lblRateValue.Text = "Không rõ";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCurrency.SelectedIndex = 0;
        }

        private void cbbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currency = txtInputCurrency.Text;
            if (!checkNumber(currency))
            {
                txtResult.Text = "Dữ liệu không hợp lệ!";
                return;
            }
            int selected = cbbCurrency.SelectedIndex;
            int input = int.Parse(currency);
            switch (selected)
            {
                case 0:
                    txtResult.Text = (input * 22772).ToString("C3", VND);
                    lblRateValue.Text = "1 USD = 22,772 VNĐ";
                    break;
                case 1:
                    txtResult.Text = (input * 28132).ToString("C3", VND);
                    lblRateValue.Text = "1 EUR = 28,132 VNĐ";
                    break;
                case 2:
                    txtResult.Text = (input * 31538).ToString("C3", VND);
                    lblRateValue.Text = "1 GBP = 31,538 VNĐ";
                    break;
                case 3:
                    txtResult.Text = (input * 17286).ToString("C3", VND);
                    lblRateValue.Text = "1 SGD = 17,286 VNĐ";
                    break;
                case 4:
                    txtResult.Text = (input * 214).ToString("C3", VND);
                    lblRateValue.Text = "1 JPY = 214 VNĐ";
                    break;
                default:
                    txtResult.Text = "Dữ liệu không hợp lệ!";
                    lblRateValue.Text = "Không rõ";
                    break;
            }
        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
