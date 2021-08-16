
namespace Bai2
{
    partial class Bai2
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblSt1 = new System.Windows.Forms.Label();
            this.lblSt2 = new System.Windows.Forms.Label();
            this.lblSt3 = new System.Windows.Forms.Label();
            this.txtSt1 = new System.Windows.Forms.TextBox();
            this.txtSt2 = new System.Windows.Forms.TextBox();
            this.txtSt3 = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Location = new System.Drawing.Point(129, 134);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tim";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(312, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblSt1
            // 
            this.lblSt1.AutoSize = true;
            this.lblSt1.Location = new System.Drawing.Point(26, 36);
            this.lblSt1.Name = "lblSt1";
            this.lblSt1.Size = new System.Drawing.Size(71, 13);
            this.lblSt1.TabIndex = 1;
            this.lblSt1.Text = "So thu nhat:";
            // 
            // lblSt2
            // 
            this.lblSt2.AutoSize = true;
            this.lblSt2.Location = new System.Drawing.Point(207, 36);
            this.lblSt2.Name = "lblSt2";
            this.lblSt2.Size = new System.Drawing.Size(63, 13);
            this.lblSt2.TabIndex = 2;
            this.lblSt2.Text = "So thu hai:";
            // 
            // lblSt3
            // 
            this.lblSt3.AutoSize = true;
            this.lblSt3.Location = new System.Drawing.Point(391, 36);
            this.lblSt3.Name = "lblSt3";
            this.lblSt3.Size = new System.Drawing.Size(60, 13);
            this.lblSt3.TabIndex = 3;
            this.lblSt3.Text = "So thu ba:";
            // 
            // txtSt1
            // 
            this.txtSt1.Location = new System.Drawing.Point(29, 63);
            this.txtSt1.Name = "txtSt1";
            this.txtSt1.Size = new System.Drawing.Size(100, 22);
            this.txtSt1.TabIndex = 4;
            // 
            // txtSt2
            // 
            this.txtSt2.Location = new System.Drawing.Point(210, 63);
            this.txtSt2.Name = "txtSt2";
            this.txtSt2.Size = new System.Drawing.Size(100, 22);
            this.txtSt2.TabIndex = 4;
            // 
            // txtSt3
            // 
            this.txtSt3.Location = new System.Drawing.Point(394, 63);
            this.txtSt3.Name = "txtSt3";
            this.txtSt3.Size = new System.Drawing.Size(100, 22);
            this.txtSt3.TabIndex = 4;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(65, 203);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(74, 13);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "So nho nhat:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(333, 203);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(70, 13);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "So lon nhat:";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(142, 203);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(13, 13);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "0";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(410, 203);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(13, 13);
            this.lblMaxValue.TabIndex = 2;
            this.lblMaxValue.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Bai2.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(478, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(508, 252);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSt3);
            this.Controls.Add(this.txtSt2);
            this.Controls.Add(this.txtSt1);
            this.Controls.Add(this.lblSt3);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblSt2);
            this.Controls.Add(this.lblSt1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblSt1;
        private System.Windows.Forms.Label lblSt2;
        private System.Windows.Forms.Label lblSt3;
        private System.Windows.Forms.TextBox txtSt1;
        private System.Windows.Forms.TextBox txtSt2;
        private System.Windows.Forms.TextBox txtSt3;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

