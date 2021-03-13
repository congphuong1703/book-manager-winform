namespace BTLHSK
{
    partial class DoiMatKhau
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
            this.xacnhan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quaylaibtn = new System.Windows.Forms.Button();
            this.doimatkhaubtn = new System.Windows.Forms.Button();
            this.matkhaumoi = new System.Windows.Forms.TextBox();
            this.matkhaucu = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xacnhan
            // 
            this.xacnhan.Location = new System.Drawing.Point(272, 226);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.PasswordChar = '*';
            this.xacnhan.Size = new System.Drawing.Size(213, 22);
            this.xacnhan.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // quaylaibtn
            // 
            this.quaylaibtn.Location = new System.Drawing.Point(392, 293);
            this.quaylaibtn.Name = "quaylaibtn";
            this.quaylaibtn.Size = new System.Drawing.Size(104, 32);
            this.quaylaibtn.TabIndex = 24;
            this.quaylaibtn.Text = "Quay lại";
            this.quaylaibtn.UseVisualStyleBackColor = true;
            this.quaylaibtn.Click += new System.EventHandler(this.quaylaibtn_Click);
            // 
            // doimatkhaubtn
            // 
            this.doimatkhaubtn.Location = new System.Drawing.Point(272, 293);
            this.doimatkhaubtn.Name = "doimatkhaubtn";
            this.doimatkhaubtn.Size = new System.Drawing.Size(104, 32);
            this.doimatkhaubtn.TabIndex = 23;
            this.doimatkhaubtn.Text = "Đổi mật khẩu";
            this.doimatkhaubtn.UseVisualStyleBackColor = true;
            this.doimatkhaubtn.Click += new System.EventHandler(this.doimatkhaubtn_Click);
            this.doimatkhaubtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doimatkhaubtn_KeyPress);
            // 
            // matkhaumoi
            // 
            this.matkhaumoi.Location = new System.Drawing.Point(272, 168);
            this.matkhaumoi.Name = "matkhaumoi";
            this.matkhaumoi.PasswordChar = '*';
            this.matkhaumoi.Size = new System.Drawing.Size(213, 22);
            this.matkhaumoi.TabIndex = 22;
            // 
            // matkhaucu
            // 
            this.matkhaucu.Location = new System.Drawing.Point(272, 112);
            this.matkhaucu.Name = "matkhaucu";
            this.matkhaucu.Size = new System.Drawing.Size(213, 22);
            this.matkhaucu.TabIndex = 21;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(153, 112);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(85, 17);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "Mật khẩu cũ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(146, 173);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 17);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "Mật khẩu mới";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(322, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 25);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Đổi mật khẩu";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 380);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quaylaibtn);
            this.Controls.Add(this.doimatkhaubtn);
            this.Controls.Add(this.matkhaumoi);
            this.Controls.Add(this.matkhaucu);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox xacnhan;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button quaylaibtn;
        internal System.Windows.Forms.Button doimatkhaubtn;
        internal System.Windows.Forms.TextBox matkhaumoi;
        internal System.Windows.Forms.TextBox matkhaucu;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}