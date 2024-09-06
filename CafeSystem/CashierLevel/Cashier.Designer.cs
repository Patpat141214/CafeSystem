namespace CafeSystem
{
    partial class Cashier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtUser = new Guna.UI.WinForms.GunaLabel();
            this.txtLevel = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaLabel();
            this.btnLogout = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridCart = new Guna.UI.WinForms.GunaDataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewImageColumn();
            this.Minus = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveDiscount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnApplyDiscount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPayment = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDiscountedTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQtyValue = new System.Windows.Forms.Label();
            this.lblTransu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount1 = new System.Windows.Forms.Label();
            this.btnPendingOrders = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnClearCart = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderType = new Guna.UI.WinForms.GunaComboBox();
            this.btnRefresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnNotAvailProducts = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.lblCafeName = new Guna.UI.WinForms.GunaLabel();
            this.lblNameAndRole = new Guna.UI.WinForms.GunaLabel();
            this.btnTransaction = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMovePending = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1238, 700);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblDate.Location = new System.Drawing.Point(723, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(518, 27);
            this.lblDate.TabIndex = 9;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Consolas", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblTime.Location = new System.Drawing.Point(723, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(518, 53);
            this.lblTime.TabIndex = 8;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txtUser.Location = new System.Drawing.Point(1280, 30);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(0, 14);
            this.txtUser.TabIndex = 4;
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtUser.Visible = false;
            // 
            // txtLevel
            // 
            this.txtLevel.AutoSize = true;
            this.txtLevel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.txtLevel.Location = new System.Drawing.Point(1280, 28);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(0, 14);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtLevel.Visible = false;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtName.Location = new System.Drawing.Point(1280, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(0, 19);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtName.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnLogout.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnLogout.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogout.CheckedImage = null;
            this.btnLogout.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(24, 24);
            this.btnLogout.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnLogout.Location = new System.Drawing.Point(1718, 1018);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(197, 57);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "End of Day [Esc]";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLogout.TextOffsetX = 21;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(20, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(54, 50);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 858);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1238, 154);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // dataGridCart
            // 
            this.dataGridCart.AllowUserToAddRows = false;
            this.dataGridCart.AllowUserToDeleteRows = false;
            this.dataGridCart.AllowUserToResizeColumns = false;
            this.dataGridCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dataGridCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridCart.ColumnHeadersHeight = 25;
            this.dataGridCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Add,
            this.Minus,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridCart.EnableHeadersVisualStyles = false;
            this.dataGridCart.GridColor = System.Drawing.Color.White;
            this.dataGridCart.Location = new System.Drawing.Point(1244, 111);
            this.dataGridCart.MultiSelect = false;
            this.dataGridCart.Name = "dataGridCart";
            this.dataGridCart.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridCart.RowHeadersVisible = false;
            this.dataGridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCart.Size = new System.Drawing.Size(674, 551);
            this.dataGridCart.TabIndex = 48;
            this.dataGridCart.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataGridCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridCart.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCart.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dataGridCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.dataGridCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCart.ThemeStyle.HeaderStyle.Height = 25;
            this.dataGridCart.ThemeStyle.ReadOnly = true;
            this.dataGridCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridCart.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCart_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "#";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Visible = false;
            this.Column7.Width = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 49;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column2.HeaderText = "Item";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 59;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column3.HeaderText = "Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 66;
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Add.HeaderText = "";
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.Width = 5;
            // 
            // Minus
            // 
            this.Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Minus.HeaderText = "";
            this.Minus.Image = ((System.Drawing.Image)(resources.GetObject("Minus.Image")));
            this.Minus.Name = "Minus";
            this.Minus.ReadOnly = true;
            this.Minus.Width = 5;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.txtSearch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.txtSearch.Location = new System.Drawing.Point(1, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(367, 35);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRemoveDiscount);
            this.panel1.Controls.Add(this.btnApplyDiscount);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.lblDiscountPercent);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDiscountAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDiscountedTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblQtyValue);
            this.panel1.Controls.Add(this.lblTransu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1244, 717);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 295);
            this.panel1.TabIndex = 22;
            // 
            // btnRemoveDiscount
            // 
            this.btnRemoveDiscount.AnimationHoverSpeed = 0.07F;
            this.btnRemoveDiscount.AnimationSpeed = 0.03F;
            this.btnRemoveDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveDiscount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(150)))));
            this.btnRemoveDiscount.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveDiscount.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnRemoveDiscount.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveDiscount.CheckedForeColor = System.Drawing.Color.White;
            this.btnRemoveDiscount.CheckedImage = null;
            this.btnRemoveDiscount.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnRemoveDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDiscount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveDiscount.Enabled = false;
            this.btnRemoveDiscount.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoveDiscount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveDiscount.Image = null;
            this.btnRemoveDiscount.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRemoveDiscount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnRemoveDiscount.Location = new System.Drawing.Point(165, 249);
            this.btnRemoveDiscount.Name = "btnRemoveDiscount";
            this.btnRemoveDiscount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnRemoveDiscount.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRemoveDiscount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveDiscount.OnHoverImage = null;
            this.btnRemoveDiscount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnRemoveDiscount.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoveDiscount.Size = new System.Drawing.Size(170, 45);
            this.btnRemoveDiscount.TabIndex = 39;
            this.btnRemoveDiscount.Text = "Remove Discount [F11]";
            this.btnRemoveDiscount.TextOffsetX = 7;
            this.btnRemoveDiscount.Click += new System.EventHandler(this.btnRemoveDiscount_Click);
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.AnimationHoverSpeed = 0.07F;
            this.btnApplyDiscount.AnimationSpeed = 0.03F;
            this.btnApplyDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnApplyDiscount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.btnApplyDiscount.BorderColor = System.Drawing.Color.Black;
            this.btnApplyDiscount.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnApplyDiscount.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnApplyDiscount.CheckedForeColor = System.Drawing.Color.White;
            this.btnApplyDiscount.CheckedImage = null;
            this.btnApplyDiscount.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnApplyDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyDiscount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApplyDiscount.Enabled = false;
            this.btnApplyDiscount.FocusedColor = System.Drawing.Color.Empty;
            this.btnApplyDiscount.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnApplyDiscount.Image = null;
            this.btnApplyDiscount.ImageSize = new System.Drawing.Size(24, 24);
            this.btnApplyDiscount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnApplyDiscount.Location = new System.Drawing.Point(-1, 249);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnApplyDiscount.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnApplyDiscount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnApplyDiscount.OnHoverImage = null;
            this.btnApplyDiscount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnApplyDiscount.OnPressedColor = System.Drawing.Color.Black;
            this.btnApplyDiscount.Size = new System.Drawing.Size(159, 45);
            this.btnApplyDiscount.TabIndex = 38;
            this.btnApplyDiscount.Text = "Apply Discount [F10]";
            this.btnApplyDiscount.TextOffsetX = 7;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.AnimationHoverSpeed = 0.07F;
            this.btnPayment.AnimationSpeed = 0.03F;
            this.btnPayment.BackColor = System.Drawing.Color.Transparent;
            this.btnPayment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.btnPayment.BorderColor = System.Drawing.Color.Black;
            this.btnPayment.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnPayment.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnPayment.CheckedForeColor = System.Drawing.Color.White;
            this.btnPayment.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPayment.CheckedImage")));
            this.btnPayment.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayment.Enabled = false;
            this.btnPayment.FocusedColor = System.Drawing.Color.Empty;
            this.btnPayment.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPayment.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPayment.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnPayment.Location = new System.Drawing.Point(383, 225);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnPayment.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPayment.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPayment.OnHoverImage = null;
            this.btnPayment.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnPayment.OnPressedColor = System.Drawing.Color.Black;
            this.btnPayment.Size = new System.Drawing.Size(290, 69);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "Proceed Payment [F9]";
            this.btnPayment.TextOffsetX = 32;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblDiscountPercent.Location = new System.Drawing.Point(318, 78);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(197, 21);
            this.lblDiscountPercent.TabIndex = 10;
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountPercent.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Discount Percent";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblDiscountAmount.Location = new System.Drawing.Point(318, 109);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(197, 21);
            this.lblDiscountAmount.TabIndex = 8;
            this.lblDiscountAmount.Text = "₱0.00";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountAmount.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Discount Amount";
            // 
            // lblDiscountedTotal
            // 
            this.lblDiscountedTotal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountedTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblDiscountedTotal.Location = new System.Drawing.Point(318, 174);
            this.lblDiscountedTotal.Name = "lblDiscountedTotal";
            this.lblDiscountedTotal.Size = new System.Drawing.Size(197, 21);
            this.lblDiscountedTotal.TabIndex = 6;
            this.lblDiscountedTotal.Text = "₱0.00";
            this.lblDiscountedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiscountedTotal.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Discounted Total";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(318, 141);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(197, 21);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "₱0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Amount";
            // 
            // lblQtyValue
            // 
            this.lblQtyValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyValue.ForeColor = System.Drawing.Color.White;
            this.lblQtyValue.Location = new System.Drawing.Point(3, 2);
            this.lblQtyValue.Name = "lblQtyValue";
            this.lblQtyValue.Size = new System.Drawing.Size(10, 12);
            this.lblQtyValue.TabIndex = 2;
            this.lblQtyValue.Text = "1";
            this.lblQtyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQtyValue.Visible = false;
            // 
            // lblTransu
            // 
            this.lblTransu.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblTransu.Location = new System.Drawing.Point(248, 37);
            this.lblTransu.Name = "lblTransu";
            this.lblTransu.Size = new System.Drawing.Size(167, 21);
            this.lblTransu.TabIndex = 1;
            this.lblTransu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Number";
            // 
            // lblTotalAmount1
            // 
            this.lblTotalAmount1.Font = new System.Drawing.Font("Consolas", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount1.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount1.Location = new System.Drawing.Point(1421, 2);
            this.lblTotalAmount1.Name = "lblTotalAmount1";
            this.lblTotalAmount1.Size = new System.Drawing.Size(496, 101);
            this.lblTotalAmount1.TabIndex = 11;
            this.lblTotalAmount1.Text = "₱0.00";
            this.lblTotalAmount1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPendingOrders
            // 
            this.btnPendingOrders.AnimationHoverSpeed = 0.07F;
            this.btnPendingOrders.AnimationSpeed = 0.03F;
            this.btnPendingOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnPendingOrders.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.btnPendingOrders.BorderColor = System.Drawing.Color.Black;
            this.btnPendingOrders.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnPendingOrders.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnPendingOrders.CheckedForeColor = System.Drawing.Color.White;
            this.btnPendingOrders.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnPendingOrders.CheckedImage")));
            this.btnPendingOrders.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnPendingOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPendingOrders.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPendingOrders.FocusedColor = System.Drawing.Color.Empty;
            this.btnPendingOrders.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendingOrders.ForeColor = System.Drawing.Color.Black;
            this.btnPendingOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnPendingOrders.Image")));
            this.btnPendingOrders.ImageSize = new System.Drawing.Size(24, 24);
            this.btnPendingOrders.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnPendingOrders.Location = new System.Drawing.Point(214, 1018);
            this.btnPendingOrders.Name = "btnPendingOrders";
            this.btnPendingOrders.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnPendingOrders.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPendingOrders.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPendingOrders.OnHoverImage = null;
            this.btnPendingOrders.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnPendingOrders.OnPressedColor = System.Drawing.Color.Black;
            this.btnPendingOrders.Size = new System.Drawing.Size(193, 57);
            this.btnPendingOrders.TabIndex = 10;
            this.btnPendingOrders.Text = "Pending Orders [F6]";
            this.btnPendingOrders.TextOffsetX = 7;
            this.btnPendingOrders.Click += new System.EventHandler(this.btnPendingOrders_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.AnimationHoverSpeed = 0.07F;
            this.btnClearCart.AnimationSpeed = 0.03F;
            this.btnClearCart.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(125)))), ((int)(((byte)(172)))));
            this.btnClearCart.BorderColor = System.Drawing.Color.Black;
            this.btnClearCart.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClearCart.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClearCart.CheckedForeColor = System.Drawing.Color.White;
            this.btnClearCart.CheckedImage = null;
            this.btnClearCart.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClearCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearCart.Enabled = false;
            this.btnClearCart.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearCart.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Image = null;
            this.btnClearCart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClearCart.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnClearCart.Location = new System.Drawing.Point(1263, 671);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnClearCart.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearCart.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearCart.OnHoverImage = null;
            this.btnClearCart.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnClearCart.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearCart.Size = new System.Drawing.Size(306, 38);
            this.btnClearCart.TabIndex = 29;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BaseColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCustomerName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCustomerName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtCustomerName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomerName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(670, 113);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(244, 33);
            this.txtCustomerName.TabIndex = 31;
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(920, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "Order Type";
            // 
            // txtOrderType
            // 
            this.txtOrderType.BackColor = System.Drawing.Color.Transparent;
            this.txtOrderType.BaseColor = System.Drawing.Color.White;
            this.txtOrderType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtOrderType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOrderType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtOrderType.FocusedColor = System.Drawing.Color.Empty;
            this.txtOrderType.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderType.ForeColor = System.Drawing.Color.Black;
            this.txtOrderType.FormattingEnabled = true;
            this.txtOrderType.Items.AddRange(new object[] {
            "Take Out",
            "Dine In"});
            this.txtOrderType.Location = new System.Drawing.Point(1049, 113);
            this.txtOrderType.Name = "txtOrderType";
            this.txtOrderType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtOrderType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtOrderType.Size = new System.Drawing.Size(192, 33);
            this.txtOrderType.TabIndex = 33;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnRefresh.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.CheckedForeColor = System.Drawing.Color.White;
            this.btnRefresh.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.CheckedImage")));
            this.btnRefresh.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageSize = new System.Drawing.Size(24, 24);
            this.btnRefresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnRefresh.Location = new System.Drawing.Point(5, 1018);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(193, 57);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "Refresh Items [F5]";
            this.btnRefresh.TextOffsetX = 9;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNotAvailProducts
            // 
            this.btnNotAvailProducts.AnimationHoverSpeed = 0.07F;
            this.btnNotAvailProducts.AnimationSpeed = 0.03F;
            this.btnNotAvailProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnNotAvailProducts.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnNotAvailProducts.BorderColor = System.Drawing.Color.Black;
            this.btnNotAvailProducts.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnNotAvailProducts.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnNotAvailProducts.CheckedForeColor = System.Drawing.Color.White;
            this.btnNotAvailProducts.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnNotAvailProducts.CheckedImage")));
            this.btnNotAvailProducts.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnNotAvailProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotAvailProducts.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNotAvailProducts.FocusedColor = System.Drawing.Color.Empty;
            this.btnNotAvailProducts.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotAvailProducts.ForeColor = System.Drawing.Color.Black;
            this.btnNotAvailProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnNotAvailProducts.Image")));
            this.btnNotAvailProducts.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNotAvailProducts.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnNotAvailProducts.Location = new System.Drawing.Point(423, 1018);
            this.btnNotAvailProducts.Name = "btnNotAvailProducts";
            this.btnNotAvailProducts.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnNotAvailProducts.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnNotAvailProducts.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNotAvailProducts.OnHoverImage = null;
            this.btnNotAvailProducts.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnNotAvailProducts.OnPressedColor = System.Drawing.Color.Black;
            this.btnNotAvailProducts.Size = new System.Drawing.Size(213, 57);
            this.btnNotAvailProducts.TabIndex = 35;
            this.btnNotAvailProducts.Text = "Unavailable Items [F7]";
            this.btnNotAvailProducts.TextOffsetX = 7;
            this.btnNotAvailProducts.Click += new System.EventHandler(this.btnNotAvailProducts_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.gunaPanel2.Controls.Add(this.lblTime);
            this.gunaPanel2.Controls.Add(this.lblCafeName);
            this.gunaPanel2.Controls.Add(this.lblDate);
            this.gunaPanel2.Controls.Add(this.lblNameAndRole);
            this.gunaPanel2.Controls.Add(this.txtUser);
            this.gunaPanel2.Controls.Add(this.lblTotalAmount1);
            this.gunaPanel2.Controls.Add(this.txtLevel);
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Controls.Add(this.txtName);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1920, 105);
            this.gunaPanel2.TabIndex = 36;
            // 
            // lblCafeName
            // 
            this.lblCafeName.AutoSize = true;
            this.lblCafeName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblCafeName.Location = new System.Drawing.Point(96, 22);
            this.lblCafeName.Name = "lblCafeName";
            this.lblCafeName.Size = new System.Drawing.Size(0, 28);
            this.lblCafeName.TabIndex = 13;
            this.lblCafeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNameAndRole
            // 
            this.lblNameAndRole.AutoSize = true;
            this.lblNameAndRole.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.lblNameAndRole.Location = new System.Drawing.Point(96, 59);
            this.lblNameAndRole.Name = "lblNameAndRole";
            this.lblNameAndRole.Size = new System.Drawing.Size(0, 24);
            this.lblNameAndRole.TabIndex = 12;
            this.lblNameAndRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTransaction
            // 
            this.btnTransaction.AnimationHoverSpeed = 0.07F;
            this.btnTransaction.AnimationSpeed = 0.03F;
            this.btnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnTransaction.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(183)))));
            this.btnTransaction.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(121)))), ((int)(((byte)(96)))));
            this.btnTransaction.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnTransaction.CheckedForeColor = System.Drawing.Color.White;
            this.btnTransaction.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTransaction.CheckedImage")));
            this.btnTransaction.CheckedLineColor = System.Drawing.Color.Transparent;
            this.btnTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaction.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTransaction.FocusedColor = System.Drawing.Color.Empty;
            this.btnTransaction.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageSize = new System.Drawing.Size(24, 24);
            this.btnTransaction.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnTransaction.Location = new System.Drawing.Point(654, 1018);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnTransaction.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnTransaction.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTransaction.OnHoverImage = null;
            this.btnTransaction.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnTransaction.OnPressedColor = System.Drawing.Color.Black;
            this.btnTransaction.Size = new System.Drawing.Size(213, 57);
            this.btnTransaction.TabIndex = 37;
            this.btnTransaction.Text = "View Transaction [F8]";
            this.btnTransaction.TextOffsetX = 7;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnMovePending
            // 
            this.btnMovePending.AnimationHoverSpeed = 0.07F;
            this.btnMovePending.AnimationSpeed = 0.03F;
            this.btnMovePending.BackColor = System.Drawing.Color.Transparent;
            this.btnMovePending.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.btnMovePending.BorderColor = System.Drawing.Color.Black;
            this.btnMovePending.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnMovePending.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnMovePending.CheckedForeColor = System.Drawing.Color.White;
            this.btnMovePending.CheckedImage = null;
            this.btnMovePending.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnMovePending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovePending.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMovePending.Enabled = false;
            this.btnMovePending.FocusedColor = System.Drawing.Color.Empty;
            this.btnMovePending.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovePending.ForeColor = System.Drawing.Color.White;
            this.btnMovePending.Image = null;
            this.btnMovePending.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMovePending.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnMovePending.Location = new System.Drawing.Point(1593, 671);
            this.btnMovePending.Name = "btnMovePending";
            this.btnMovePending.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnMovePending.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMovePending.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMovePending.OnHoverImage = null;
            this.btnMovePending.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnMovePending.OnPressedColor = System.Drawing.Color.Black;
            this.btnMovePending.Size = new System.Drawing.Size(306, 38);
            this.btnMovePending.TabIndex = 49;
            this.btnMovePending.Text = "Move to pending order";
            this.btnMovePending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMovePending.Click += new System.EventHandler(this.btnMovePending_Click);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.btnMovePending);
            this.Controls.Add(this.dataGridCart);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnNotAvailProducts);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtOrderType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.btnPendingOrders);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProductPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Cashier_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cashier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnLogout;
        public Guna.UI.WinForms.GunaLabel txtUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI.WinForms.GunaLabel txtLevel;
        public Guna.UI.WinForms.GunaLabel txtName;
        public Guna.UI.WinForms.GunaDataGridView dataGridCart;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTransu;
        public System.Windows.Forms.Label lblQtyValue;
        public System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblDiscountedTotal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblTotalAmount1;
        private Guna.UI.WinForms.GunaAdvenceButton btnPendingOrders;
        private System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaTextBox txtCustomerName;
        private System.Windows.Forms.Label label8;
        public Guna.UI.WinForms.GunaComboBox txtOrderType;
        public Guna.UI.WinForms.GunaAdvenceButton btnClearCart;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btnRefresh;
        private Guna.UI.WinForms.GunaAdvenceButton btnNotAvailProducts;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        public Guna.UI.WinForms.GunaLabel lblNameAndRole;
        public Guna.UI.WinForms.GunaLabel lblCafeName;
        private Guna.UI.WinForms.GunaAdvenceButton btnTransaction;
        public Guna.UI.WinForms.GunaAdvenceButton btnPayment;
        public Guna.UI.WinForms.GunaAdvenceButton btnApplyDiscount;
        public Guna.UI.WinForms.GunaAdvenceButton btnRemoveDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Add;
        private System.Windows.Forms.DataGridViewImageColumn Minus;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        public Guna.UI.WinForms.GunaAdvenceButton btnMovePending;
    }
}