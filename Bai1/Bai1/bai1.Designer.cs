
namespace Bai1
{
    partial class bai1
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
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblSt1 = new System.Windows.Forms.Label();
            this.lblSt2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSt1 = new System.Windows.Forms.TextBox();
            this.txtSt2 = new System.Windows.Forms.TextBox();
            this.lblResultValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Bai1.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(453, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSt1
            // 
            this.lblSt1.AutoSize = true;
            this.lblSt1.Location = new System.Drawing.Point(57, 43);
            this.lblSt1.Name = "lblSt1";
            this.lblSt1.Size = new System.Drawing.Size(71, 13);
            this.lblSt1.TabIndex = 1;
            this.lblSt1.Text = "Số thứ nhất:";
            // 
            // lblSt2
            // 
            this.lblSt2.AutoSize = true;
            this.lblSt2.Location = new System.Drawing.Point(57, 89);
            this.lblSt2.Name = "lblSt2";
            this.lblSt2.Size = new System.Drawing.Size(63, 13);
            this.lblSt2.TabIndex = 1;
            this.lblSt2.Text = "Số thứ hai:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(57, 146);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(49, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Kết quả:";
            // 
            // txtSt1
            // 
            this.txtSt1.Location = new System.Drawing.Point(144, 40);
            this.txtSt1.Name = "txtSt1";
            this.txtSt1.Size = new System.Drawing.Size(240, 22);
            this.txtSt1.TabIndex = 2;
            this.txtSt1.TextChanged += new System.EventHandler(this.txtSt1_TextChanged);
            // 
            // txtSt2
            // 
            this.txtSt2.Location = new System.Drawing.Point(144, 86);
            this.txtSt2.Name = "txtSt2";
            this.txtSt2.Size = new System.Drawing.Size(240, 22);
            this.txtSt2.TabIndex = 2;
            this.txtSt2.TextChanged += new System.EventHandler(this.txtSt2_TextChanged);
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultValue.ForeColor = System.Drawing.Color.Orange;
            this.lblResultValue.Location = new System.Drawing.Point(149, 142);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(19, 21);
            this.lblResultValue.TabIndex = 3;
            this.lblResultValue.Text = "0";
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(480, 229);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.txtSt2);
            this.Controls.Add(this.txtSt1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSt2);
            this.Controls.Add(this.lblSt1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai1";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblSt1;
        private System.Windows.Forms.Label lblSt2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSt1;
        private System.Windows.Forms.TextBox txtSt2;
        private System.Windows.Forms.Label lblResultValue;
    }
}

