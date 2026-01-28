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
            btnlsp.Location = new Point(120, 93);
            btnlsp.Margin = new Padding(3, 4, 3, 4);
            btnlsp.Name = "btnlsp";
            btnlsp.Size = new Size(197, 76);
            btnlsp.TabIndex = 0;
            btnlsp.Text = "Loại Sản Phẩm";
            btnlsp.UseVisualStyleBackColor = true;
            btnlsp.Click += btnlsp_Click;
            // 
            // btnHangSX
            // 
            btnHangSX.Location = new Point(423, 93);
            btnHangSX.Margin = new Padding(3, 4, 3, 4);
            btnHangSX.Name = "btnHangSX";
            btnHangSX.Size = new Size(197, 76);
            btnHangSX.TabIndex = 1;
            btnHangSX.Text = "Hãng Sản Xuất";
            btnHangSX.UseVisualStyleBackColor = true;
            btnHangSX.Click += btnHangSX_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnHangSX);
            Controls.Add(btnlsp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnlsp;
        private Button btnHangSX;
    }
}