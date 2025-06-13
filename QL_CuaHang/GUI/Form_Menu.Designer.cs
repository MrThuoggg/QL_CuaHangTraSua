namespace QL_CuaHang.GUI
{
    partial class Form_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgdanhsachtrasua = new System.Windows.Forms.DataGridView();
            this.dgdanhsachtopping = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txttongtien1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.btinHoaDon = new System.Windows.Forms.Button();
            this.đỒUỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHỐNGKÊDOANHTHUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÁOCÁOCHITIẾTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỆTHỐNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đĂNGXUẤTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÍToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachtrasua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachtopping)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đỒUỐNGToolStripMenuItem,
            this.tHỐNGKÊDOANHTHUToolStripMenuItem,
            this.hỆTHỐNGToolStripMenuItem,
            this.qUẢNLÍToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1882, 39);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dgdanhsachtrasua
            // 
            this.dgdanhsachtrasua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdanhsachtrasua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdanhsachtrasua.BackgroundColor = System.Drawing.Color.White;
            this.dgdanhsachtrasua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdanhsachtrasua.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgdanhsachtrasua.Location = new System.Drawing.Point(1237, 42);
            this.dgdanhsachtrasua.Name = "dgdanhsachtrasua";
            this.dgdanhsachtrasua.ReadOnly = true;
            this.dgdanhsachtrasua.RowHeadersWidth = 51;
            this.dgdanhsachtrasua.RowTemplate.Height = 24;
            this.dgdanhsachtrasua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdanhsachtrasua.Size = new System.Drawing.Size(650, 950);
            this.dgdanhsachtrasua.TabIndex = 1;
            this.dgdanhsachtrasua.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgdanhsachtrasua_DataBindingComplete);
            // 
            // dgdanhsachtopping
            // 
            this.dgdanhsachtopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdanhsachtopping.BackgroundColor = System.Drawing.Color.White;
            this.dgdanhsachtopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdanhsachtopping.Location = new System.Drawing.Point(24, 556);
            this.dgdanhsachtopping.Name = "dgdanhsachtopping";
            this.dgdanhsachtopping.ReadOnly = true;
            this.dgdanhsachtopping.RowHeadersWidth = 51;
            this.dgdanhsachtopping.RowTemplate.Height = 24;
            this.dgdanhsachtopping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdanhsachtopping.Size = new System.Drawing.Size(1198, 436);
            this.dgdanhsachtopping.TabIndex = 2;
            this.dgdanhsachtopping.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgdanhsachtopping_MouseClick);
            this.dgdanhsachtopping.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgdanhsachtopping_MouseDown);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 25;
            this.guna2GroupBox1.BorderThickness = 5;
            this.guna2GroupBox1.Controls.Add(this.txttongtien1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(26, 392);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(263, 158);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "THÀNH TIỀN";
            // 
            // txttongtien1
            // 
            this.txttongtien1.AutoSize = true;
            this.txttongtien1.BackColor = System.Drawing.Color.White;
            this.txttongtien1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.txttongtien1.Location = new System.Drawing.Point(21, 91);
            this.txttongtien1.Name = "txttongtien1";
            this.txttongtien1.Size = new System.Drawing.Size(42, 27);
            this.txttongtien1.TabIndex = 4;
            this.txttongtien1.Text = "......";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 25;
            this.guna2GroupBox2.BorderThickness = 5;
            this.guna2GroupBox2.Controls.Add(this.btxoa);
            this.guna2GroupBox2.Controls.Add(this.btthem);
            this.guna2GroupBox2.Controls.Add(this.btinHoaDon);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(602, 392);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(620, 158);
            this.guna2GroupBox2.TabIndex = 4;
            this.guna2GroupBox2.Text = "CHỨC NĂNG";
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.Color.Moccasin;
            this.btxoa.Location = new System.Drawing.Point(431, 58);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(172, 76);
            this.btxoa.TabIndex = 7;
            this.btxoa.Text = "XÓA";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.Moccasin;
            this.btthem.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.btthem.Location = new System.Drawing.Point(235, 58);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(172, 76);
            this.btthem.TabIndex = 6;
            this.btthem.Text = "THÊM";
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.Controls.Add(this.dgOrder);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(26, 42);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1196, 344);
            this.guna2GroupBox3.TabIndex = 5;
            this.guna2GroupBox3.Text = "BẢNG HÓA ĐƠN";
            // 
            // dgOrder
            // 
            this.dgOrder.BackgroundColor = System.Drawing.Color.White;
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Location = new System.Drawing.Point(0, 36);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.ReadOnly = true;
            this.dgOrder.RowHeadersWidth = 51;
            this.dgOrder.RowTemplate.Height = 24;
            this.dgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrder.Size = new System.Drawing.Size(1196, 308);
            this.dgOrder.TabIndex = 3;
            // 
            // btinHoaDon
            // 
            this.btinHoaDon.BackColor = System.Drawing.Color.Moccasin;
            this.btinHoaDon.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold);
            this.btinHoaDon.Location = new System.Drawing.Point(44, 58);
            this.btinHoaDon.Name = "btinHoaDon";
            this.btinHoaDon.Size = new System.Drawing.Size(172, 76);
            this.btinHoaDon.TabIndex = 5;
            this.btinHoaDon.Text = "IN HÓA ĐƠN";
            this.btinHoaDon.UseVisualStyleBackColor = false;
            this.btinHoaDon.Click += new System.EventHandler(this.btinHoaDon_Click);
            // 
            // đỒUỐNGToolStripMenuItem
            // 
            this.đỒUỐNGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.đỒUỐNGToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đỒUỐNGToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.ImgDanhmuc;
            this.đỒUỐNGToolStripMenuItem.Name = "đỒUỐNGToolStripMenuItem";
            this.đỒUỐNGToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.đỒUỐNGToolStripMenuItem.Size = new System.Drawing.Size(117, 37);
            this.đỒUỐNGToolStripMenuItem.Text = "MENU";
            // 
            // tHỐNGKÊDOANHTHUToolStripMenuItem
            // 
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bÁOCÁOCHITIẾTToolStripMenuItem});
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.ImgDoanhso;
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.Name = "tHỐNGKÊDOANHTHUToolStripMenuItem";
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.Size = new System.Drawing.Size(190, 37);
            this.tHỐNGKÊDOANHTHUToolStripMenuItem.Text = "THỐNG KÊ ";
            // 
            // bÁOCÁOCHITIẾTToolStripMenuItem
            // 
            this.bÁOCÁOCHITIẾTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bÁOCÁOCHITIẾTToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgBaocao;
            this.bÁOCÁOCHITIẾTToolStripMenuItem.Name = "bÁOCÁOCHITIẾTToolStripMenuItem";
            this.bÁOCÁOCHITIẾTToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.bÁOCÁOCHITIẾTToolStripMenuItem.Text = "BÁO CÁO CHI TIẾT";
            // 
            // hỆTHỐNGToolStripMenuItem
            // 
            this.hỆTHỐNGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.hỆTHỐNGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đĂNGXUẤTToolStripMenuItem,
            this.đĂNGXUẤTToolStripMenuItem1});
            this.hỆTHỐNGToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hỆTHỐNGToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgHethong;
            this.hỆTHỐNGToolStripMenuItem.Name = "hỆTHỐNGToolStripMenuItem";
            this.hỆTHỐNGToolStripMenuItem.Size = new System.Drawing.Size(191, 37);
            this.hỆTHỐNGToolStripMenuItem.Text = "HỆ THỐNG ";
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            this.đĂNGXUẤTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.đĂNGXUẤTToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgLogin;
            this.đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            this.đĂNGXUẤTToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG NHẬP";
            this.đĂNGXUẤTToolStripMenuItem.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem_Click);
            // 
            // đĂNGXUẤTToolStripMenuItem1
            // 
            this.đĂNGXUẤTToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.đĂNGXUẤTToolStripMenuItem1.Image = global::QL_CuaHang.Properties.Resources.imgDangXuat;
            this.đĂNGXUẤTToolStripMenuItem1.Name = "đĂNGXUẤTToolStripMenuItem1";
            this.đĂNGXUẤTToolStripMenuItem1.Size = new System.Drawing.Size(264, 38);
            this.đĂNGXUẤTToolStripMenuItem1.Text = "ĐĂNG XUẤT";
            this.đĂNGXUẤTToolStripMenuItem1.Click += new System.EventHandler(this.đĂNGXUẤTToolStripMenuItem1_Click);
            // 
            // qUẢNLÍToolStripMenuItem
            // 
            this.qUẢNLÍToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.qUẢNLÍToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem,
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem,
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem});
            this.qUẢNLÍToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qUẢNLÍToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgquanly;
            this.qUẢNLÍToolStripMenuItem.Name = "qUẢNLÍToolStripMenuItem";
            this.qUẢNLÍToolStripMenuItem.Size = new System.Drawing.Size(158, 37);
            this.qUẢNLÍToolStripMenuItem.Text = "QUẢN LÝ";
            this.qUẢNLÍToolStripMenuItem.Click += new System.EventHandler(this.qUẢNLÍToolStripMenuItem_Click);
            // 
            // qUẢNLÝĐƠNHÀNGToolStripMenuItem
            // 
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgdonhang;
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem.Name = "qUẢNLÝĐƠNHÀNGToolStripMenuItem";
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.qUẢNLÝĐƠNHÀNGToolStripMenuItem.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // qUẢNLÝKHÁCHHÀNGToolStripMenuItem
            // 
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgKHang;
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Name = "qUẢNLÝKHÁCHHÀNGToolStripMenuItem";
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.qUẢNLÝKHÁCHHÀNGToolStripMenuItem.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // qUẢNLÝNHÂNVIÊNToolStripMenuItem
            // 
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Image = global::QL_CuaHang.Properties.Resources.imgnhanvien;
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Name = "qUẢNLÝNHÂNVIÊNToolStripMenuItem";
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Size = new System.Drawing.Size(398, 38);
            this.qUẢNLÝNHÂNVIÊNToolStripMenuItem.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1892, 1001);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgdanhsachtopping);
            this.Controls.Add(this.dgdanhsachtrasua);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Menu";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachtrasua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdanhsachtopping)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tHỐNGKÊDOANHTHUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÁOCÁOCHITIẾTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỆTHỐNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đĂNGXUẤTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÍToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝĐƠNHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝKHÁCHHÀNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝNHÂNVIÊNToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgdanhsachtrasua;
        private System.Windows.Forms.DataGridView dgdanhsachtopping;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label txttongtien1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Button btinHoaDon;
        private System.Windows.Forms.Button btthem;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.ToolStripMenuItem đỒUỐNGToolStripMenuItem;
    }
}