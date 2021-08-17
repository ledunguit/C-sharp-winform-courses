
namespace Bai4
{
    partial class Bai4
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRateValue = new System.Windows.Forms.Label();
            this.txtInputCurrency = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cbbCurrency = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(51, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chuyển đổi tiền tệ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bai4.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(457, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai4.Properties.Resources.iconlogobai4;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(26, 79);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(46, 13);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "Số tiền:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(26, 125);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Số tiền đổi được:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(26, 185);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 13);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Tỉ giá:";
            // 
            // lblRateValue
            // 
            this.lblRateValue.AutoSize = true;
            this.lblRateValue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRateValue.Location = new System.Drawing.Point(138, 185);
            this.lblRateValue.Name = "lblRateValue";
            this.lblRateValue.Size = new System.Drawing.Size(109, 13);
            this.lblRateValue.TabIndex = 3;
            this.lblRateValue.Text = "1 USD = 22,772 VNĐ";
            // 
            // txtInputCurrency
            // 
            this.txtInputCurrency.Location = new System.Drawing.Point(141, 76);
            this.txtInputCurrency.Name = "txtInputCurrency";
            this.txtInputCurrency.Size = new System.Drawing.Size(123, 22);
            this.txtInputCurrency.TabIndex = 4;
            this.txtInputCurrency.TextChanged += new System.EventHandler(this.txtInputCurrency_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(141, 122);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(288, 22);
            this.txtResult.TabIndex = 4;
            // 
            // cbbCurrency
            // 
            this.cbbCurrency.FormattingEnabled = true;
            this.cbbCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.cbbCurrency.Location = new System.Drawing.Point(308, 76);
            this.cbbCurrency.Name = "cbbCurrency";
            this.cbbCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbbCurrency.TabIndex = 5;
            this.cbbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbbCurrency_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(486, 247);
            this.Controls.Add(this.cbbCurrency);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInputCurrency);
            this.Controls.Add(this.lblRateValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRateValue;
        private System.Windows.Forms.TextBox txtInputCurrency;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cbbCurrency;
    }
}

