namespace CafeSystem.Admin
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnCloseForm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReturn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDesc = new Guna.UI.WinForms.GunaTextBox();
            this.btnBrowseImage = new Guna.UI.WinForms.GunaAdvenceButton();
            this.editImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtId = new Guna.UI.WinForms.GunaLabel();
            this.checkboxAv = new Guna.UI.WinForms.GunaCheckBox();
            this.txtCat = new System.Windows.Forms.ComboBox();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editImage)).BeginInit();
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
            this.gunaPanel1.Size = new System.Drawing.Size(504, 38);
            this.gunaPanel1.TabIndex = 13;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(117, 19);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Edit Product";
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
            this.btnCloseForm.Location = new System.Drawing.Point(462, 3);
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
            // btnReturn
            // 
            this.btnReturn.AnimationHoverSpeed = 0.07F;
            this.btnReturn.AnimationSpeed = 0.03F;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnReturn.BorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReturn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReturn.CheckedForeColor = System.Drawing.Color.White;
            this.btnReturn.CheckedImage = null;
            this.btnReturn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReturn.FocusedColor = System.Drawing.Color.Empty;
            this.btnReturn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = null;
            this.btnReturn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReturn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnReturn.Location = new System.Drawing.Point(349, 268);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnReturn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnReturn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReturn.OnHoverImage = null;
            this.btnReturn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnReturn.OnPressedColor = System.Drawing.Color.Black;
            this.btnReturn.Radius = 8;
            this.btnReturn.Size = new System.Drawing.Size(130, 30);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return All";
            this.btnReturn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.CheckedForeColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedImage = null;
            this.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnUpdate.Location = new System.Drawing.Point(212, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 8;
            this.btnUpdate.Size = new System.Drawing.Size(130, 30);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(221, 180);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(42, 14);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(224, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(234, 27);
            this.txtPrice.TabIndex = 20;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(221, 121);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(63, 14);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Category";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(221, 61);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 14);
            this.gunaLabel1.TabIndex = 18;
            this.gunaLabel1.Text = "Product Name";
            // 
            // txtDesc
            // 
            this.txtDesc.BaseColor = System.Drawing.Color.White;
            this.txtDesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtDesc.BorderSize = 1;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDesc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtDesc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDesc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(224, 78);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.SelectedText = "";
            this.txtDesc.Size = new System.Drawing.Size(234, 27);
            this.txtDesc.TabIndex = 17;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.AnimationHoverSpeed = 0.07F;
            this.btnBrowseImage.AnimationSpeed = 0.03F;
            this.btnBrowseImage.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseImage.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnBrowseImage.BorderColor = System.Drawing.Color.Black;
            this.btnBrowseImage.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBrowseImage.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBrowseImage.CheckedForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.CheckedImage = null;
            this.btnBrowseImage.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBrowseImage.FocusedColor = System.Drawing.Color.Empty;
            this.btnBrowseImage.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImage.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.Image = null;
            this.btnBrowseImage.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBrowseImage.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(27, 220);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnBrowseImage.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBrowseImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBrowseImage.OnHoverImage = null;
            this.btnBrowseImage.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnBrowseImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnBrowseImage.Radius = 8;
            this.btnBrowseImage.Size = new System.Drawing.Size(130, 30);
            this.btnBrowseImage.TabIndex = 16;
            this.btnBrowseImage.Text = "New Image";
            this.btnBrowseImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // editImage
            // 
            this.editImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editImage.Location = new System.Drawing.Point(12, 61);
            this.editImage.Name = "editImage";
            this.editImage.Size = new System.Drawing.Size(160, 153);
            this.editImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editImage.TabIndex = 15;
            this.editImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(9, 270);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(0, 14);
            this.txtId.TabIndex = 25;
            this.txtId.Visible = false;
            // 
            // checkboxAv
            // 
            this.checkboxAv.BaseColor = System.Drawing.Color.White;
            this.checkboxAv.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkboxAv.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkboxAv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxAv.FillColor = System.Drawing.Color.White;
            this.checkboxAv.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxAv.Location = new System.Drawing.Point(224, 236);
            this.checkboxAv.Name = "checkboxAv";
            this.checkboxAv.Size = new System.Drawing.Size(97, 20);
            this.checkboxAv.TabIndex = 26;
            this.checkboxAv.Text = "Available";
            // 
            // txtCat
            // 
            this.txtCat.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCat.FormattingEnabled = true;
            this.txtCat.Location = new System.Drawing.Point(224, 138);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(234, 23);
            this.txtCat.TabIndex = 24;
            this.txtCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCat_KeyPress);
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 310);
            this.ControlBox = false;
            this.Controls.Add(this.checkboxAv);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtCat);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.editImage);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.EditProduct_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditProduct_KeyDown);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnCloseForm;
        private Guna.UI.WinForms.GunaAdvenceButton btnReturn;
        private Guna.UI.WinForms.GunaAdvenceButton btnUpdate;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnBrowseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Guna.UI.WinForms.GunaTextBox txtPrice;
        public Guna.UI.WinForms.GunaTextBox txtDesc;
        public System.Windows.Forms.PictureBox editImage;
        public Guna.UI.WinForms.GunaLabel txtId;
        public Guna.UI.WinForms.GunaCheckBox checkboxAv;
        public System.Windows.Forms.ComboBox txtCat;
    }
}