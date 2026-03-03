namespace QL_CuaHang.GUI
{
    partial class Form_DiemDanh
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
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btdiemdanh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsongaydiemdanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.Location = new System.Drawing.Point(192, 115);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.ReadOnly = true;
            this.txttennhanvien.Size = new System.Drawing.Size(330, 34);
            this.txttennhanvien.TabIndex = 0;
            this.txttennhanvien.TabStop = false;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchucvu.Location = new System.Drawing.Point(192, 173);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.ReadOnly = true;
            this.txtchucvu.Size = new System.Drawing.Size(330, 34);
            this.txtchucvu.TabIndex = 1;
            this.txtchucvu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ:";
            // 
            // btdiemdanh
            // 
            this.btdiemdanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiemdanh.ForeColor = System.Drawing.Color.MediumBlue;
            this.btdiemdanh.Location = new System.Drawing.Point(552, 115);
            this.btdiemdanh.Name = "btdiemdanh";
            this.btdiemdanh.Size = new System.Drawing.Size(167, 74);
            this.btdiemdanh.TabIndex = 4;
            this.btdiemdanh.Text = "ĐIỂM DANH";
            this.btdiemdanh.UseVisualStyleBackColor = true;
            this.btdiemdanh.Click += new System.EventHandler(this.btdiemdanh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số ngày đã điểm danh:";
            // 
            // txtsongaydiemdanh
            // 
            this.txtsongaydiemdanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsongaydiemdanh.DefaultText = "";
            this.txtsongaydiemdanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsongaydiemdanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsongaydiemdanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsongaydiemdanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsongaydiemdanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsongaydiemdanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsongaydiemdanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsongaydiemdanh.Location = new System.Drawing.Point(260, 232);
            this.txtsongaydiemdanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsongaydiemdanh.Name = "txtsongaydiemdanh";
            this.txtsongaydiemdanh.PasswordChar = '\0';
            this.txtsongaydiemdanh.PlaceholderText = "";
            this.txtsongaydiemdanh.ReadOnly = true;
            this.txtsongaydiemdanh.SelectedText = "";
            this.txtsongaydiemdanh.Size = new System.Drawing.Size(262, 48);
            this.txtsongaydiemdanh.TabIndex = 9;
            this.txtsongaydiemdanh.TabStop = false;
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btthoat.Location = new System.Drawing.Point(552, 210);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(167, 77);
            this.btthoat.TabIndex = 10;
            this.btthoat.Text = "THOÁT";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "BẢNG ĐIỂM DANH";
            // 
            // Form_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(758, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtsongaydiemdanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btdiemdanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txttennhanvien);
            this.Name = "Form_DiemDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐIỂM DANH";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_DiemDanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btdiemdanh;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtsongaydiemdanh;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Label label5;
    }
}