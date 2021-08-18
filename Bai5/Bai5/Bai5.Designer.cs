
namespace Bai5
{
    partial class Bai5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grResult = new System.Windows.Forms.GroupBox();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblResultB = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai5.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(539, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(59, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(332, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(62, 49);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(156, 22);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(335, 49);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(162, 22);
            this.txtB.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(62, 112);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(156, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Tính toán";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(335, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset các giá trị";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grResult
            // 
            this.grResult.Controls.Add(this.lblS3);
            this.grResult.Controls.Add(this.lblS2);
            this.grResult.Controls.Add(this.lblS1);
            this.grResult.Controls.Add(this.lblResultB);
            this.grResult.Controls.Add(this.lblResultA);
            this.grResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grResult.ForeColor = System.Drawing.Color.White;
            this.grResult.Location = new System.Drawing.Point(20, 158);
            this.grResult.Name = "grResult";
            this.grResult.Size = new System.Drawing.Size(514, 202);
            this.grResult.TabIndex = 4;
            this.grResult.TabStop = false;
            this.grResult.Text = "Kết quả";
            // 
            // lblResultA
            // 
            this.lblResultA.AutoSize = true;
            this.lblResultA.Location = new System.Drawing.Point(43, 32);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(33, 13);
            this.lblResultA.TabIndex = 0;
            this.lblResultA.Text = "A! = ";
            // 
            // lblResultB
            // 
            this.lblResultB.AutoSize = true;
            this.lblResultB.Location = new System.Drawing.Point(281, 32);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(29, 13);
            this.lblResultB.TabIndex = 0;
            this.lblResultB.Text = "B! =";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.Location = new System.Drawing.Point(43, 73);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(159, 13);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "S1 = 1 + 2 + 3 + 4 + … + A  =";
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.Location = new System.Drawing.Point(43, 114);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(155, 13);
            this.lblS2.TabIndex = 0;
            this.lblS2.Text = "S2 = 1 + 2 + 3 + 4 + … + B =";
            // 
            // lblS3
            // 
            this.lblS3.AutoSize = true;
            this.lblS3.Location = new System.Drawing.Point(43, 155);
            this.lblS3.Name = "lblS3";
            this.lblS3.Size = new System.Drawing.Size(229, 13);
            this.lblS3.TabIndex = 0;
            this.lblS3.Text = "S3 = A^1 + A^2+A^3 + A^4 + … + A^B =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(561, 372);
            this.Controls.Add(this.grResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grResult.ResumeLayout(false);
            this.grResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grResult;
        private System.Windows.Forms.Label lblS3;
        private System.Windows.Forms.Label lblS2;
        private System.Windows.Forms.Label lblS1;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.Label lblResultA;
    }
}

