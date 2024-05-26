namespace CafeSystem.CashierLevel
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtCash = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTotal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtDiscountAmount = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtPercent = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtChange = new Guna.UI.WinForms.GunaTextBox();
            this.btnClearAll = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnProceed = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnCloseForm = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtSubTotal = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(24, 524);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(126, 19);
            this.gunaLabel5.TabIndex = 49;
            this.gunaLabel5.Text = "Customer Cash";
            // 
            // txtCash
            // 
            this.txtCash.BaseColor = System.Drawing.Color.White;
            this.txtCash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtCash.BorderSize = 1;
            this.txtCash.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCash.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCash.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtCash.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCash.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(27, 546);
            this.txtCash.Name = "txtCash";
            this.txtCash.PasswordChar = '\0';
            this.txtCash.SelectedText = "";
            this.txtCash.Size = new System.Drawing.Size(431, 67);
            this.txtCash.TabIndex = 48;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(24, 366);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(117, 19);
            this.gunaLabel3.TabIndex = 47;
            this.gunaLabel3.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.BaseColor = System.Drawing.Color.White;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtTotal.BorderSize = 1;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotal.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(27, 388);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(431, 67);
            this.txtTotal.TabIndex = 46;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(24, 156);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(144, 19);
            this.gunaLabel2.TabIndex = 45;
            this.gunaLabel2.Text = "Discount Amount";
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.BaseColor = System.Drawing.Color.White;
            this.txtDiscountAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtDiscountAmount.BorderSize = 1;
            this.txtDiscountAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDiscountAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtDiscountAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiscountAmount.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmount.Location = new System.Drawing.Point(27, 178);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.PasswordChar = '\0';
            this.txtDiscountAmount.SelectedText = "";
            this.txtDiscountAmount.Size = new System.Drawing.Size(431, 67);
            this.txtDiscountAmount.TabIndex = 44;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(23, 53);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(153, 19);
            this.gunaLabel1.TabIndex = 43;
            this.gunaLabel1.Text = "Discount Percent";
            // 
            // txtPercent
            // 
            this.txtPercent.BaseColor = System.Drawing.Color.White;
            this.txtPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPercent.BorderSize = 1;
            this.txtPercent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPercent.Enabled = false;
            this.txtPercent.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPercent.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtPercent.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPercent.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercent.Location = new System.Drawing.Point(27, 75);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.PasswordChar = '\0';
            this.txtPercent.SelectedText = "";
            this.txtPercent.Size = new System.Drawing.Size(431, 67);
            this.txtPercent.TabIndex = 42;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(24, 629);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(144, 19);
            this.gunaLabel4.TabIndex = 51;
            this.gunaLabel4.Text = "Customer Change";
            // 
            // txtChange
            // 
            this.txtChange.BaseColor = System.Drawing.Color.White;
            this.txtChange.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtChange.BorderSize = 1;
            this.txtChange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChange.Enabled = false;
            this.txtChange.FocusedBaseColor = System.Drawing.Color.White;
            this.txtChange.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtChange.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChange.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(27, 651);
            this.txtChange.Name = "txtChange";
            this.txtChange.PasswordChar = '\0';
            this.txtChange.SelectedText = "";
            this.txtChange.Size = new System.Drawing.Size(431, 67);
            this.txtChange.TabIndex = 50;
            // 
            // btnClearAll
            // 
            this.btnClearAll.AnimationHoverSpeed = 0.07F;
            this.btnClearAll.AnimationSpeed = 0.03F;
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
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
            this.btnClearAll.Location = new System.Drawing.Point(247, 734);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.Radius = 8;
            this.btnClearAll.Size = new System.Drawing.Size(160, 39);
            this.btnClearAll.TabIndex = 53;
            this.btnClearAll.Text = "Clear";
            this.btnClearAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.AnimationHoverSpeed = 0.07F;
            this.btnProceed.AnimationSpeed = 0.03F;
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnProceed.BorderColor = System.Drawing.Color.Black;
            this.btnProceed.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnProceed.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProceed.CheckedForeColor = System.Drawing.Color.White;
            this.btnProceed.CheckedImage = null;
            this.btnProceed.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProceed.FocusedColor = System.Drawing.Color.Empty;
            this.btnProceed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Image = null;
            this.btnProceed.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProceed.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnProceed.Location = new System.Drawing.Point(81, 734);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnProceed.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnProceed.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProceed.OnHoverImage = null;
            this.btnProceed.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnProceed.OnPressedColor = System.Drawing.Color.Black;
            this.btnProceed.Radius = 8;
            this.btnProceed.Size = new System.Drawing.Size(160, 39);
            this.btnProceed.TabIndex = 52;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(68)))), ((int)(((byte)(75)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.btnCloseForm);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(476, 38);
            this.gunaPanel1.TabIndex = 54;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(3, 9);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(72, 19);
            this.gunaLabel6.TabIndex = 14;
            this.gunaLabel6.Text = "Payment";
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
            this.btnCloseForm.Location = new System.Drawing.Point(434, 3);
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
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Black;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 492);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(476, 10);
            this.gunaLinePanel1.TabIndex = 55;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.Location = new System.Drawing.Point(24, 261);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(90, 19);
            this.gunaLabel7.TabIndex = 57;
            this.gunaLabel7.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BaseColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtSubTotal.BorderSize = 1;
            this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSubTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.txtSubTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSubTotal.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(27, 283);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.PasswordChar = '\0';
            this.txtSubTotal.SelectedText = "";
            this.txtSubTotal.Size = new System.Drawing.Size(431, 67);
            this.txtSubTotal.TabIndex = 56;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 785);
            this.ControlBox = false;
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.gunaLinePanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Payment_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payment_KeyDown);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaTextBox txtCash;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        public Guna.UI.WinForms.GunaTextBox txtTotal;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaTextBox txtDiscountAmount;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaTextBox txtPercent;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        public Guna.UI.WinForms.GunaTextBox txtChange;
        private Guna.UI.WinForms.GunaAdvenceButton btnClearAll;
        private Guna.UI.WinForms.GunaAdvenceButton btnProceed;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaAdvenceButton btnCloseForm;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaTextBox txtSubTotal;
    }
}