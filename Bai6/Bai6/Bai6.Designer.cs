
namespace Bai6
{
    partial class Bai6
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
            this.grInput = new System.Windows.Forms.GroupBox();
            this.grResult = new System.Windows.Forms.GroupBox();
            this.listMark = new System.Windows.Forms.ListView();
            this.lblHint = new System.Windows.Forms.Label();
            this.txtInputMark = new System.Windows.Forms.TextBox();
            this.btnInputMark = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMaxSubject = new System.Windows.Forms.Label();
            this.lblMinSubject = new System.Windows.Forms.Label();
            this.lblPassSubject = new System.Windows.Forms.Label();
            this.lblUnPassSubject = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblPassValue = new System.Windows.Forms.Label();
            this.lblUnPassValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.cl1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grInput.SuspendLayout();
            this.grResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(56, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Classification";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bai6.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(644, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai6.Properties.Resources._class;
            this.pictureBox1.Location = new System.Drawing.Point(0, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grInput
            // 
            this.grInput.Controls.Add(this.btnInputMark);
            this.grInput.Controls.Add(this.txtInputMark);
            this.grInput.Controls.Add(this.lblHint);
            this.grInput.Controls.Add(this.listMark);
            this.grInput.ForeColor = System.Drawing.Color.White;
            this.grInput.Location = new System.Drawing.Point(13, 68);
            this.grInput.Name = "grInput";
            this.grInput.Size = new System.Drawing.Size(306, 305);
            this.grInput.TabIndex = 3;
            this.grInput.TabStop = false;
            this.grInput.Text = "Phần nhập điểm";
            // 
            // grResult
            // 
            this.grResult.Controls.Add(this.lblResultValue);
            this.grResult.Controls.Add(this.lblUnPassValue);
            this.grResult.Controls.Add(this.lblResult);
            this.grResult.Controls.Add(this.lblUnPassSubject);
            this.grResult.Controls.Add(this.lblPassValue);
            this.grResult.Controls.Add(this.lblPassSubject);
            this.grResult.Controls.Add(this.lblMinValue);
            this.grResult.Controls.Add(this.lblMinSubject);
            this.grResult.Controls.Add(this.lblMaxValue);
            this.grResult.Controls.Add(this.lblMaxSubject);
            this.grResult.Controls.Add(this.lblAverageValue);
            this.grResult.Controls.Add(this.lblAverage);
            this.grResult.ForeColor = System.Drawing.Color.White;
            this.grResult.Location = new System.Drawing.Point(345, 68);
            this.grResult.Name = "grResult";
            this.grResult.Size = new System.Drawing.Size(306, 305);
            this.grResult.TabIndex = 4;
            this.grResult.TabStop = false;
            this.grResult.Text = "Phần kết quả";
            // 
            // listMark
            // 
            this.listMark.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl1,
            this.cl2});
            this.listMark.HideSelection = false;
            this.listMark.Location = new System.Drawing.Point(7, 111);
            this.listMark.Name = "listMark";
            this.listMark.Size = new System.Drawing.Size(293, 188);
            this.listMark.TabIndex = 0;
            this.listMark.UseCompatibleStateImageBehavior = false;
            this.listMark.View = System.Windows.Forms.View.Details;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(23, 21);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(265, 13);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Mời nhập điểm, định dạng: 8,8.5,7.5,9.25,7,8,7.5,...";
            // 
            // txtInputMark
            // 
            this.txtInputMark.Location = new System.Drawing.Point(11, 42);
            this.txtInputMark.Name = "txtInputMark";
            this.txtInputMark.Size = new System.Drawing.Size(288, 22);
            this.txtInputMark.TabIndex = 2;
            // 
            // btnInputMark
            // 
            this.btnInputMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputMark.Location = new System.Drawing.Point(11, 70);
            this.btnInputMark.Name = "btnInputMark";
            this.btnInputMark.Size = new System.Drawing.Size(288, 23);
            this.btnInputMark.TabIndex = 3;
            this.btnInputMark.Text = "Nhập điểm";
            this.btnInputMark.UseVisualStyleBackColor = true;
            this.btnInputMark.Click += new System.EventHandler(this.btnInputMark_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(29, 45);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(95, 13);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Điểm trung bình:";
            // 
            // lblMaxSubject
            // 
            this.lblMaxSubject.AutoSize = true;
            this.lblMaxSubject.Location = new System.Drawing.Point(29, 70);
            this.lblMaxSubject.Name = "lblMaxSubject";
            this.lblMaxSubject.Size = new System.Drawing.Size(125, 13);
            this.lblMaxSubject.TabIndex = 1;
            this.lblMaxSubject.Text = "Môn có điểm cao nhất:";
            // 
            // lblMinSubject
            // 
            this.lblMinSubject.AutoSize = true;
            this.lblMinSubject.Location = new System.Drawing.Point(29, 97);
            this.lblMinSubject.Name = "lblMinSubject";
            this.lblMinSubject.Size = new System.Drawing.Size(131, 13);
            this.lblMinSubject.TabIndex = 1;
            this.lblMinSubject.Text = "Môn có điểm thấp nhất:";
            // 
            // lblPassSubject
            // 
            this.lblPassSubject.AutoSize = true;
            this.lblPassSubject.Location = new System.Drawing.Point(29, 123);
            this.lblPassSubject.Name = "lblPassSubject";
            this.lblPassSubject.Size = new System.Drawing.Size(72, 13);
            this.lblPassSubject.TabIndex = 1;
            this.lblPassSubject.Text = "Số môn qua:";
            // 
            // lblUnPassSubject
            // 
            this.lblUnPassSubject.AutoSize = true;
            this.lblUnPassSubject.Location = new System.Drawing.Point(29, 148);
            this.lblUnPassSubject.Name = "lblUnPassSubject";
            this.lblUnPassSubject.Size = new System.Drawing.Size(109, 13);
            this.lblUnPassSubject.TabIndex = 1;
            this.lblUnPassSubject.Text = "Số môn không qua:";
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.AutoSize = true;
            this.lblAverageValue.Location = new System.Drawing.Point(182, 45);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(16, 13);
            this.lblAverageValue.TabIndex = 0;
            this.lblAverageValue.Text = "...";
            // 
            // lblMaxValue
            // 
            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(182, 71);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(16, 13);
            this.lblMaxValue.TabIndex = 1;
            this.lblMaxValue.Text = "...";
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(182, 97);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(16, 13);
            this.lblMinValue.TabIndex = 1;
            this.lblMinValue.Text = "...";
            // 
            // lblPassValue
            // 
            this.lblPassValue.AutoSize = true;
            this.lblPassValue.Location = new System.Drawing.Point(182, 123);
            this.lblPassValue.Name = "lblPassValue";
            this.lblPassValue.Size = new System.Drawing.Size(16, 13);
            this.lblPassValue.TabIndex = 1;
            this.lblPassValue.Text = "...";
            // 
            // lblUnPassValue
            // 
            this.lblUnPassValue.AutoSize = true;
            this.lblUnPassValue.Location = new System.Drawing.Point(182, 149);
            this.lblUnPassValue.Name = "lblUnPassValue";
            this.lblUnPassValue.Size = new System.Drawing.Size(16, 13);
            this.lblUnPassValue.TabIndex = 1;
            this.lblUnPassValue.Text = "...";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(29, 237);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Xếp loại:";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Location = new System.Drawing.Point(150, 237);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(16, 13);
            this.lblResultValue.TabIndex = 1;
            this.lblResultValue.Text = "...";
            // 
            // cl1
            // 
            this.cl1.Text = "Môn";
            this.cl1.Width = 121;
            // 
            // cl2
            // 
            this.cl2.Text = "Điểm";
            this.cl2.Width = 115;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(674, 385);
            this.Controls.Add(this.grResult);
            this.Controls.Add(this.grInput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bai6";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grInput.ResumeLayout(false);
            this.grInput.PerformLayout();
            this.grResult.ResumeLayout(false);
            this.grResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grInput;
        private System.Windows.Forms.GroupBox grResult;
        private System.Windows.Forms.Button btnInputMark;
        private System.Windows.Forms.TextBox txtInputMark;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.ListView listMark;
        private System.Windows.Forms.ColumnHeader cl1;
        private System.Windows.Forms.ColumnHeader cl2;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.Label lblUnPassValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblUnPassSubject;
        private System.Windows.Forms.Label lblPassValue;
        private System.Windows.Forms.Label lblPassSubject;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMinSubject;
        private System.Windows.Forms.Label lblMaxValue;
        private System.Windows.Forms.Label lblMaxSubject;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblAverage;
    }
}

