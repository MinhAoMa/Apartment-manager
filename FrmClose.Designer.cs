namespace Apartment_manager_app
{
    partial class FrmClose
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
            this.guna2GradientButton11 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GradientButton11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 33);
            this.panel1.TabIndex = 0;
            // 
            // guna2GradientButton11
            // 
            this.guna2GradientButton11.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton11.CheckedState.Parent = this.guna2GradientButton11;
            this.guna2GradientButton11.CustomImages.Parent = this.guna2GradientButton11;
            this.guna2GradientButton11.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientButton11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.guna2GradientButton11.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(127)))), ((int)(((byte)(246)))));
            this.guna2GradientButton11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton11.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton11.HoverState.Parent = this.guna2GradientButton11;
            this.guna2GradientButton11.Image = global::Apartment_manager_app.Properties.Resources.error__1_;
            this.guna2GradientButton11.Location = new System.Drawing.Point(643, 0);
            this.guna2GradientButton11.Name = "guna2GradientButton11";
            this.guna2GradientButton11.ShadowDecoration.Parent = this.guna2GradientButton11;
            this.guna2GradientButton11.Size = new System.Drawing.Size(54, 33);
            this.guna2GradientButton11.TabIndex = 35;
            this.guna2GradientButton11.Click += new System.EventHandler(this.btnformClose);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 57);
            this.label2.TabIndex = 36;
            this.label2.Text = "Bạn muốn đóng ứng dụng không ?\r\n\r\n\r\n";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(89, 192);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(178, 45);
            this.guna2Button1.TabIndex = 37;
            this.guna2Button1.Text = "Có";
            this.guna2Button1.Click += new System.EventHandler(this.btnYes);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(359, 192);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(178, 45);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Text = "Không";
            this.guna2Button2.Click += new System.EventHandler(this.btnNo);
            // 
            // FrmClose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(697, 283);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClose";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton11;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}