namespace CafeSystem.Admin
{
    partial class ReportsModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowSoldReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(2, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 998);
            this.panel1.TabIndex = 0;
            // 
            // btnShowSoldReport
            // 
            this.btnShowSoldReport.AnimationHoverSpeed = 0.07F;
            this.btnShowSoldReport.AnimationSpeed = 0.03F;
            this.btnShowSoldReport.BackColor = System.Drawing.Color.Transparent;
            this.btnShowSoldReport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnShowSoldReport.BorderColor = System.Drawing.Color.Black;
            this.btnShowSoldReport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnShowSoldReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnShowSoldReport.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowSoldReport.CheckedImage = null;
            this.btnShowSoldReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnShowSoldReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSoldReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowSoldReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnShowSoldReport.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSoldReport.ForeColor = System.Drawing.Color.White;
            this.btnShowSoldReport.Image = null;
            this.btnShowSoldReport.ImageOffsetX = 1;
            this.btnShowSoldReport.ImageSize = new System.Drawing.Size(24, 24);
            this.btnShowSoldReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnShowSoldReport.Location = new System.Drawing.Point(2, 29);
            this.btnShowSoldReport.Name = "btnShowSoldReport";
            this.btnShowSoldReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(183)))), ((int)(((byte)(165)))));
            this.btnShowSoldReport.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnShowSoldReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShowSoldReport.OnHoverImage = null;
            this.btnShowSoldReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.btnShowSoldReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnShowSoldReport.Size = new System.Drawing.Size(185, 50);
            this.btnShowSoldReport.TabIndex = 20;
            this.btnShowSoldReport.Text = "Sales Report";
            this.btnShowSoldReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnShowSoldReport.Click += new System.EventHandler(this.btnShowSoldReport_Click);
            // 
            // ReportsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 1061);
            this.Controls.Add(this.btnShowSoldReport);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportsModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReportsModule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnShowSoldReport;
    }
}