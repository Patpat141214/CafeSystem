namespace CafeSystem.Admin
{
    partial class ProfileSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileSettings));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtUser = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtPass = new Guna.UI.WinForms.GunaTextBox();
            this.btnClearAll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnVisible = new System.Windows.Forms.PictureBox();
            this.btnCloseForm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.btnCloseForm);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(417, 38);
            this.gunaPanel1.TabIndex = 13;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(153, 19);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Edit Information";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 70);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(63, 14);
            this.gunaLabel1.TabIndex = 25;
            this.gunaLabel1.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.BaseColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtUser.BorderSize = 1;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUser.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(33, 87);
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.Size = new System.Drawing.Size(345, 27);
            this.txtUser.TabIndex = 24;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(30, 132);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(35, 14);
            this.gunaLabel2.TabIndex = 27;
            this.gunaLabel2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtName.BorderSize = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(33, 149);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(345, 27);
            this.txtName.TabIndex = 26;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(30, 194);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(63, 14);
            this.gunaLabel3.TabIndex = 29;
            this.gunaLabel3.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BaseColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPass.BorderSize = 1;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPass.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(33, 211);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '•';
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(345, 27);
            this.txtPass.TabIndex = 28;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AnimationHoverSpeed = 0.07F;
            this.btnClearAll.AnimationSpeed = 0.03F;
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnClearAll.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnClearAll.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnClearAll.CheckedForeColor = System.Drawing.Color.White;
            this.btnClearAll.CheckedImage = null;
            this.btnClearAll.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearAll.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Image = null;
            this.btnClearAll.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClearAll.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnClearAll.Location = new System.Drawing.Point(211, 262);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.Radius = 8;
            this.btnClearAll.Size = new System.Drawing.Size(130, 30);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "Return All";
            this.btnClearAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = null;
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnAdd.Location = new System.Drawing.Point(74, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 8;
            this.btnAdd.Size = new System.Drawing.Size(130, 30);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Update Profile";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVisible
            // 
            this.btnVisible.BackColor = System.Drawing.Color.White;
            this.btnVisible.Image = ((System.Drawing.Image)(resources.GetObject("btnVisible.Image")));
            this.btnVisible.Location = new System.Drawing.Point(355, 214);
            this.btnVisible.Name = "btnVisible";
            this.btnVisible.Size = new System.Drawing.Size(20, 20);
            this.btnVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisible.TabIndex = 32;
            this.btnVisible.TabStop = false;
            this.btnVisible.Click += new System.EventHandler(this.btnVisible_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.AnimationHoverSpeed = 0.07F;
            this.btnCloseForm.AnimationSpeed = 0.03F;
            this.btnCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BaseColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.BorderColor = System.Drawing.Color.Black;
            this.btnCloseForm.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnCloseForm.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCloseForm.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCloseForm.CheckedForeColor = System.Drawing.Color.White;
            this.btnCloseForm.CheckedImage = null;
            this.btnCloseForm.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCloseForm.FocusedColor = System.Drawing.Color.Empty;
            this.btnCloseForm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCloseForm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnCloseForm.Location = new System.Drawing.Point(375, 3);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCloseForm.OnHoverImage = null;
            this.btnCloseForm.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnCloseForm.OnPressedColor = System.Drawing.Color.Black;
            this.btnCloseForm.Radius = 8;
            this.btnCloseForm.Size = new System.Drawing.Size(39, 32);
            this.btnCloseForm.TabIndex = 13;
            this.btnCloseForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // ProfileSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnVisible);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.ProfileSettings_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfileSettings_KeyDown);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCloseForm;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaAdvenceButton btnClearAll;
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        public Guna.UI.WinForms.GunaTextBox txtUser;
        public Guna.UI.WinForms.GunaTextBox txtName;
        public Guna.UI.WinForms.GunaTextBox txtPass;
        private System.Windows.Forms.PictureBox btnVisible;
    }
}