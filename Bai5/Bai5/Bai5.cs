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

namespace Bai5
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        bool checkNumber(string input)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        public int PowN(int a, int b)
        {
            int pow = 1;
            for (int i = 1; i <= b; i++)
            {
                pow *= a;
            }
            return pow;
        }

        public int S3(int a, int b)
        {
            int s = 0;
            for (int i = 1; i <= b; i++)
            {
                s = s + PowN(a, i);
            }
            return s;
        }

        public int MultoN(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            return s;
        }

        public int SumToN(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            return s;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            string a = txtA.Text;
            string b = txtB.Text;
            if (!checkNumber(a) || !checkNumber(b))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int st1 = int.Parse(a);
            int st2 = int.Parse(b);
            if (st1 < 1 || st2 < 1)
            {
                MessageBox.Show("Vui lòng nhập các số lớn hơn 0.", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblResultA.Text = "A! = " + MultoN(st1).ToString();
            lblResultB.Text = "B! = " + MultoN(st2).ToString();
            lblS1.Text = "S1 = 1 + 2 + 3 + 4 + … + A = " + SumToN(st1).ToString(); 
            lblS2.Text = "S2 = 1 + 2 + 3 + 4 + … + B = " + SumToN(st2).ToString();
            lblS3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + … + A^B =" + S3(st1, st2).ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblResultA.Text = "A! = ";
            lblResultB.Text = "B! = ";
            txtA.Text = "";
            txtB.Text = "";
            lblS1.Text = "S1 = 1 + 2 + 3 + 4 + … + A = ";
            lblS2.Text = "S2 = 1 + 2 + 3 + 4 + … + B = ";
            lblS3.Text = "S3 = A^1 + A^2 + A^3 + A^4 + … + A^B =";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
