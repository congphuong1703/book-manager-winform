namespace BTLHSK
{
    partial class KhoaTaiKhoan
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
            this.quaylaibtn = new System.Windows.Forms.Button();
            this.luubtn = new System.Windows.Forms.Button();
            this.taikhoankhoa = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quaylaibtn
            // 
            this.quaylaibtn.Location = new System.Drawing.Point(316, 201);
            this.quaylaibtn.Name = "quaylaibtn";
            this.quaylaibtn.Size = new System.Drawing.Size(95, 33);
            this.quaylaibtn.TabIndex = 13;
            this.quaylaibtn.Text = "Quay lại";
            this.quaylaibtn.UseVisualStyleBackColor = true;
            // 
            // luubtn
            // 
            this.luubtn.Location = new System.Drawing.Point(199, 201);
            this.luubtn.Name = "luubtn";
            this.luubtn.Size = new System.Drawing.Size(95, 33);
            this.luubtn.TabIndex = 12;
            this.luubtn.Text = "Lưu";
            this.luubtn.UseVisualStyleBackColor = true;
            // 
            // taikhoankhoa
            // 
            this.taikhoankhoa.FormattingEnabled = true;
            this.taikhoankhoa.Location = new System.Drawing.Point(251, 124);
            this.taikhoankhoa.Name = "taikhoankhoa";
            this.taikhoankhoa.Size = new System.Drawing.Size(204, 24);
            this.taikhoankhoa.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(61, 127);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(165, 17);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Chọn tài khoản cần khóa";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(194, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 25);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Khóa tài khoản";
            // 
            // KhoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 287);
            this.Controls.Add(this.quaylaibtn);
            this.Controls.Add(this.luubtn);
            this.Controls.Add(this.taikhoankhoa);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "KhoaTaiKhoan";
            this.Text = "KhoaTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button quaylaibtn;
        internal System.Windows.Forms.Button luubtn;
        internal System.Windows.Forms.ComboBox taikhoankhoa;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}