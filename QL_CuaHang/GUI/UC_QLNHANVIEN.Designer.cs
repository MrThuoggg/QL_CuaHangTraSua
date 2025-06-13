namespace QL_CuaHang.GUI
{
    partial class UC_QLNHANVIEN
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbchucvu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtluongnhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttennhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDnhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgdanhsachnhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.txtNhapCanTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bttinhluong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.bttimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaxoa = new Guna.UI2.WinForms.Guna2Button();
            this.gunacapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.gunaghi = new Guna.UI2.WinForms.Guna2Button();
            this.gunathem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachnhanvien)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GroupBox1.BorderThickness = 10;
            this.guna2GroupBox1.Controls.Add(this.cbchucvu);
            this.guna2GroupBox1.Controls.Add(this.txtluongnhanvien);
            this.guna2GroupBox1.Controls.Add(this.txttennhanvien);
            this.guna2GroupBox1.Controls.Add(this.txtIDnhanvien);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Navy;
            this.guna2GroupBox1.Location = new System.Drawing.Point(16, 91);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(532, 319);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông tin chi tiết";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // cbchucvu
            // 
            this.cbchucvu.BackColor = System.Drawing.Color.Silver;
            this.cbchucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbchucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbchucvu.FillColor = System.Drawing.Color.Silver;
            this.cbchucvu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbchucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbchucvu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchucvu.ForeColor = System.Drawing.Color.Black;
            this.cbchucvu.ItemHeight = 30;
            this.cbchucvu.Location = new System.Drawing.Point(212, 188);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(290, 36);
            this.cbchucvu.TabIndex = 7;
            this.cbchucvu.SelectedIndexChanged += new System.EventHandler(this.cbchucvu_SelectedIndexChanged);
            // 
            // txtluongnhanvien
            // 
            this.txtluongnhanvien.BackColor = System.Drawing.Color.Silver;
            this.txtluongnhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtluongnhanvien.DefaultText = "";
            this.txtluongnhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtluongnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtluongnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtluongnhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtluongnhanvien.FillColor = System.Drawing.Color.Silver;
            this.txtluongnhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtluongnhanvien.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtluongnhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtluongnhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtluongnhanvien.Location = new System.Drawing.Point(212, 250);
            this.txtluongnhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtluongnhanvien.Name = "txtluongnhanvien";
            this.txtluongnhanvien.PasswordChar = '\0';
            this.txtluongnhanvien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtluongnhanvien.PlaceholderText = "";
            this.txtluongnhanvien.SelectedText = "";
            this.txtluongnhanvien.Size = new System.Drawing.Size(290, 44);
            this.txtluongnhanvien.TabIndex = 6;
            this.txtluongnhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluongnhanvien_KeyPress);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.BackColor = System.Drawing.Color.Silver;
            this.txttennhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhanvien.DefaultText = "";
            this.txttennhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttennhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttennhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttennhanvien.FillColor = System.Drawing.Color.Silver;
            this.txttennhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.ForeColor = System.Drawing.Color.Black;
            this.txttennhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttennhanvien.Location = new System.Drawing.Point(212, 119);
            this.txttennhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.PasswordChar = '\0';
            this.txttennhanvien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txttennhanvien.PlaceholderText = "";
            this.txttennhanvien.SelectedText = "";
            this.txttennhanvien.Size = new System.Drawing.Size(290, 44);
            this.txttennhanvien.TabIndex = 5;
            this.txttennhanvien.TextChanged += new System.EventHandler(this.txttennhanvien_TextChanged);
            this.txttennhanvien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttennhanvien_KeyPress);
            // 
            // txtIDnhanvien
            // 
            this.txtIDnhanvien.BackColor = System.Drawing.Color.Silver;
            this.txtIDnhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDnhanvien.DefaultText = "";
            this.txtIDnhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDnhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDnhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDnhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDnhanvien.Enabled = false;
            this.txtIDnhanvien.FillColor = System.Drawing.Color.Silver;
            this.txtIDnhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDnhanvien.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDnhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtIDnhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDnhanvien.Location = new System.Drawing.Point(212, 51);
            this.txtIDnhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDnhanvien.Name = "txtIDnhanvien";
            this.txtIDnhanvien.PasswordChar = '\0';
            this.txtIDnhanvien.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtIDnhanvien.PlaceholderText = "";
            this.txtIDnhanvien.SelectedText = "";
            this.txtIDnhanvien.Size = new System.Drawing.Size(290, 44);
            this.txtIDnhanvien.TabIndex = 4;
            this.txtIDnhanvien.TextChanged += new System.EventHandler(this.txtIDnhanvien_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương cơ bản";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhân Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.Red;
            this.guna2TextBox2.BorderRadius = 20;
            this.guna2TextBox2.BorderThickness = 5;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.guna2TextBox2.DefaultText = "Thông tin Nhân Viên";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.PeachPuff;
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.guna2TextBox2.ForeColor = System.Drawing.Color.Navy;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(16, 9);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.ReadOnly = true;
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(305, 51);
            this.guna2TextBox2.TabIndex = 11;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2TextBox2.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // dgdanhsachnhanvien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgdanhsachnhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdanhsachnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdanhsachnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdanhsachnhanvien.ColumnHeadersHeight = 4;
            this.dgdanhsachnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgdanhsachnhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgdanhsachnhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgdanhsachnhanvien.Location = new System.Drawing.Point(16, 425);
            this.dgdanhsachnhanvien.Name = "dgdanhsachnhanvien";
            this.dgdanhsachnhanvien.ReadOnly = true;
            this.dgdanhsachnhanvien.RowHeadersVisible = false;
            this.dgdanhsachnhanvien.RowHeadersWidth = 51;
            this.dgdanhsachnhanvien.RowTemplate.Height = 24;
            this.dgdanhsachnhanvien.Size = new System.Drawing.Size(1218, 335);
            this.dgdanhsachnhanvien.TabIndex = 8;
            this.dgdanhsachnhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgdanhsachnhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgdanhsachnhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgdanhsachnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgdanhsachnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgdanhsachnhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgdanhsachnhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgdanhsachnhanvien.ThemeStyle.HeaderStyle.Height = 4;
            this.dgdanhsachnhanvien.ThemeStyle.ReadOnly = true;
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgdanhsachnhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgdanhsachnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdanhsachnhanvien_CellClick);
            this.dgdanhsachnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdanhsachnhanvien_CellContentClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // txtNhapCanTim
            // 
            this.txtNhapCanTim.BackColor = System.Drawing.Color.Silver;
            this.txtNhapCanTim.BorderColor = System.Drawing.Color.Silver;
            this.txtNhapCanTim.BorderRadius = 10;
            this.txtNhapCanTim.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNhapCanTim.DefaultText = "";
            this.txtNhapCanTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapCanTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapCanTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapCanTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapCanTim.FillColor = System.Drawing.Color.Silver;
            this.txtNhapCanTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapCanTim.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.txtNhapCanTim.ForeColor = System.Drawing.Color.Black;
            this.txtNhapCanTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapCanTim.Location = new System.Drawing.Point(192, 240);
            this.txtNhapCanTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapCanTim.Name = "txtNhapCanTim";
            this.txtNhapCanTim.PasswordChar = '\0';
            this.txtNhapCanTim.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNhapCanTim.PlaceholderText = "Nhập mã cần tìm";
            this.txtNhapCanTim.SelectedText = "";
            this.txtNhapCanTim.Size = new System.Drawing.Size(175, 44);
            this.txtNhapCanTim.TabIndex = 20;
            this.txtNhapCanTim.Tag = "";
            this.txtNhapCanTim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhapCanTim_KeyPress);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GroupBox2.BorderThickness = 10;
            this.guna2GroupBox2.Controls.Add(this.bttinhluong);
            this.guna2GroupBox2.Controls.Add(this.guna2Button2);
            this.guna2GroupBox2.Controls.Add(this.txtNhapCanTim);
            this.guna2GroupBox2.Controls.Add(this.bttimkiem);
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.Controls.Add(this.gunaxoa);
            this.guna2GroupBox2.Controls.Add(this.gunacapnhat);
            this.guna2GroupBox2.Controls.Add(this.gunaghi);
            this.guna2GroupBox2.Controls.Add(this.gunathem);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Navy;
            this.guna2GroupBox2.Location = new System.Drawing.Point(554, 91);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(680, 319);
            this.guna2GroupBox2.TabIndex = 21;
            this.guna2GroupBox2.Text = "Chức năng";
            // 
            // bttinhluong
            // 
            this.bttinhluong.BackColor = System.Drawing.Color.Transparent;
            this.bttinhluong.BorderColor = System.Drawing.Color.Red;
            this.bttinhluong.BorderRadius = 15;
            this.bttinhluong.BorderThickness = 3;
            this.bttinhluong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttinhluong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttinhluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttinhluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttinhluong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttinhluong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.bttinhluong.ForeColor = System.Drawing.Color.MediumBlue;
            this.bttinhluong.Image = global::QL_CuaHang.Properties.Resources.calculator;
            this.bttinhluong.ImageOffset = new System.Drawing.Point(3, 1);
            this.bttinhluong.ImageSize = new System.Drawing.Size(30, 30);
            this.bttinhluong.Location = new System.Drawing.Point(503, 51);
            this.bttinhluong.Name = "bttinhluong";
            this.bttinhluong.Size = new System.Drawing.Size(160, 68);
            this.bttinhluong.TabIndex = 13;
            this.bttinhluong.Text = "Tính lương";
            this.bttinhluong.Click += new System.EventHandler(this.bttinhluong_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Red;
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.MediumBlue;
            this.guna2Button2.Location = new System.Drawing.Point(374, 240);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(67, 45);
            this.guna2Button2.TabIndex = 21;
            this.guna2Button2.Text = "Load";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // bttimkiem
            // 
            this.bttimkiem.BackColor = System.Drawing.Color.Transparent;
            this.bttimkiem.BorderColor = System.Drawing.Color.Red;
            this.bttimkiem.BorderRadius = 15;
            this.bttimkiem.BorderThickness = 3;
            this.bttimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttimkiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttimkiem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.bttimkiem.ForeColor = System.Drawing.Color.MediumBlue;
            this.bttimkiem.Image = global::QL_CuaHang.Properties.Resources.Remove_TimKiem;
            this.bttimkiem.ImageSize = new System.Drawing.Size(35, 35);
            this.bttimkiem.Location = new System.Drawing.Point(22, 228);
            this.bttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bttimkiem.Name = "bttimkiem";
            this.bttimkiem.Size = new System.Drawing.Size(163, 71);
            this.bttimkiem.TabIndex = 19;
            this.bttimkiem.Text = "Tìm kiếm";
            this.bttimkiem.Click += new System.EventHandler(this.bttimkiem_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Red;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.MediumBlue;
            this.guna2Button1.Image = global::QL_CuaHang.Properties.Resources.print_icon;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(475, 228);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(188, 66);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "In danh sách";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gunaxoa
            // 
            this.gunaxoa.BackColor = System.Drawing.Color.Transparent;
            this.gunaxoa.BorderColor = System.Drawing.Color.Red;
            this.gunaxoa.BorderRadius = 15;
            this.gunaxoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gunaxoa.BorderThickness = 3;
            this.gunaxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaxoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunaxoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaxoa.Image = global::QL_CuaHang.Properties.Resources.iconxoa;
            this.gunaxoa.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaxoa.Location = new System.Drawing.Point(266, 136);
            this.gunaxoa.Name = "gunaxoa";
            this.gunaxoa.Size = new System.Drawing.Size(226, 66);
            this.gunaxoa.TabIndex = 15;
            this.gunaxoa.Text = "Xóa Nhân Viên";
            this.gunaxoa.Click += new System.EventHandler(this.gunaxoa_Click);
            // 
            // gunacapnhat
            // 
            this.gunacapnhat.BackColor = System.Drawing.Color.Transparent;
            this.gunacapnhat.BorderColor = System.Drawing.Color.Red;
            this.gunacapnhat.BorderRadius = 15;
            this.gunacapnhat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gunacapnhat.BorderThickness = 3;
            this.gunacapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunacapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunacapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunacapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunacapnhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunacapnhat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunacapnhat.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunacapnhat.Image = global::QL_CuaHang.Properties.Resources.Apps_system_software_update_icon;
            this.gunacapnhat.ImageSize = new System.Drawing.Size(35, 35);
            this.gunacapnhat.Location = new System.Drawing.Point(22, 136);
            this.gunacapnhat.Name = "gunacapnhat";
            this.gunacapnhat.Size = new System.Drawing.Size(226, 66);
            this.gunacapnhat.TabIndex = 14;
            this.gunacapnhat.Text = "Cập Nhật";
            this.gunacapnhat.Click += new System.EventHandler(this.gunacapnhat_Click);
            // 
            // gunaghi
            // 
            this.gunaghi.BackColor = System.Drawing.Color.Transparent;
            this.gunaghi.BorderColor = System.Drawing.Color.Red;
            this.gunaghi.BorderRadius = 15;
            this.gunaghi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gunaghi.BorderThickness = 3;
            this.gunaghi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunaghi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunaghi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunaghi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunaghi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaghi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunaghi.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunaghi.Image = global::QL_CuaHang.Properties.Resources.Save_icon;
            this.gunaghi.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaghi.Location = new System.Drawing.Point(22, 53);
            this.gunaghi.Name = "gunaghi";
            this.gunaghi.Size = new System.Drawing.Size(226, 66);
            this.gunaghi.TabIndex = 12;
            this.gunaghi.Text = "Ghi mã";
            this.gunaghi.Click += new System.EventHandler(this.gunaghi_Click);
            // 
            // gunathem
            // 
            this.gunathem.BackColor = System.Drawing.Color.Transparent;
            this.gunathem.BorderColor = System.Drawing.Color.Red;
            this.gunathem.BorderRadius = 15;
            this.gunathem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.gunathem.BorderThickness = 3;
            this.gunathem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunathem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunathem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunathem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunathem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunathem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.gunathem.ForeColor = System.Drawing.Color.MediumBlue;
            this.gunathem.Image = global::QL_CuaHang.Properties.Resources.Add_icon;
            this.gunathem.ImageOffset = new System.Drawing.Point(4, 1);
            this.gunathem.ImageSize = new System.Drawing.Size(30, 30);
            this.gunathem.Location = new System.Drawing.Point(266, 53);
            this.gunathem.Name = "gunathem";
            this.gunathem.Size = new System.Drawing.Size(226, 66);
            this.gunathem.TabIndex = 13;
            this.gunathem.Text = "Thêm Nhân Viên";
            this.gunathem.Click += new System.EventHandler(this.gunathem_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 5;
            this.guna2PictureBox1.Image = global::QL_CuaHang.Properties.Resources.Remove_bg_ai_1729073579208;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1073, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(183, 103);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_QLNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgdanhsachnhanvien);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.6F);
            this.Name = "UC_QLNHANVIEN";
            this.Size = new System.Drawing.Size(1256, 775);
            this.Load += new System.EventHandler(this.UC_QLNHANVIEN_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachnhanvien)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtluongnhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txttennhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txtIDnhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbchucvu;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button gunaghi;
        private Guna.UI2.WinForms.Guna2Button gunathem;
        private Guna.UI2.WinForms.Guna2Button gunacapnhat;
        private Guna.UI2.WinForms.Guna2Button gunaxoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgdanhsachnhanvien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button bttimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapCanTim;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button bttinhluong;
    }
}
