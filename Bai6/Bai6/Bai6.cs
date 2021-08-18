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

namespace Bai6
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        bool checkNumber(string n)
        {
            Regex regex = new Regex(@"^[0-9]+$|[0-9]\.[0-9]+$");
            return regex.IsMatch(n);
        }

        float AverageSubject(float[] arr, int n)
        {
            float s = 0;
            for (int i = 0; i < n; i++)
            {
                s += arr[i];
            }
            return (float)(s / n);
        }

        float MinSubject(float[] arr, int n)
        {
            float min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }

        float MaxSubject(float[] arr, int n)
        {
            float max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        int countPassSubject(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 5)
                {
                    count++;
                }
            }
            return count;
        }

        int countUnPassSubject(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 5)
                {
                    count++;
                }
            }
            return count;
        }

        int count65(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 6.5)
                {
                    count++;
                }
            }
            return count;
        }


        int count5(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 5)
                {
                    count++;
                }
            }
            return count;
        }

        int count35(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 3.5)
                {
                    count++;
                }
            }
            return count;
        }

        int count2(float[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 2)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnInputMark_Click(object sender, EventArgs e)
        {
            string[] arr;
            arr = txtInputMark.Text.Split(',');
            float[] markAfter = new float[100];
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkNumber(arr[i]))
                {
                    markAfter[i] = float.Parse(arr[i]);
                    if (markAfter[i] < 0 || markAfter[i] > 10)
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int j = 0; j < arr.Length; j++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "Môn " + (j + 1).ToString();
                item.SubItems.Add(markAfter[j].ToString());
                listMark.Items.Add(item);
            }
            lblAverageValue.Text = AverageSubject(markAfter, arr.Length).ToString();
            lblMaxValue.Text = MinSubject(markAfter, arr.Length).ToString();
            lblMinValue.Text = MaxSubject(markAfter, arr.Length).ToString();
            lblPassValue.Text = countPassSubject(markAfter, arr.Length).ToString();
            lblUnPassValue.Text = countUnPassSubject(markAfter, arr.Length).ToString();

            float averagedSubject = AverageSubject(markAfter, arr.Length);

            if (averagedSubject >= 8.5 && count65(markAfter, arr.Length) == 0)
            {
                lblResultValue.Text = "Giỏi";
            }
            else if (averagedSubject >= 6.5 && count5(markAfter, arr.Length) == 0)
            {
                lblResultValue.Text = "Khá";
            }
            else if(averagedSubject >= 5 && count35(markAfter, arr.Length) == 0)
            {
                lblResultValue.Text = "Trung bình";
            }
            else if(averagedSubject >= 3.5 && count2(markAfter, arr.Length) == 0)
            {
                lblResultValue.Text = "Yếu";
            } else
            {
                lblResultValue.Text = "Kém";
            }
        }
    }
}
