namespace QuanLyBanHang
{
    partial class Form1
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
            btnlsp = new Button();
            btnHangSX = new Button();
            SuspendLayout();
            // 
            // btnlsp
            // 
            btnlsp.Location = new Point(105, 70);
            btnlsp.Name = "btnlsp";
            btnlsp.Size = new Size(172, 57);
            btnlsp.TabIndex = 0;
            btnlsp.Text = "Loại Sản Phẩm";
            btnlsp.UseVisualStyleBackColor = true;
            btnlsp.Click += btnlsp_Click;
            // 
            // btnHangSX
            // 
            btnHangSX.Location = new Point(370, 70);
            btnHangSX.Name = "btnHangSX";
            btnHangSX.Size = new Size(172, 57);
            btnHangSX.TabIndex = 1;
            btnHangSX.Text = "Hãng Sản Xuất";
            btnHangSX.UseVisualStyleBackColor = true;
            btnHangSX.Click += btnHangSX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHangSX);
            Controls.Add(btnlsp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnlsp;
        private Button btnHangSX;
    }
}