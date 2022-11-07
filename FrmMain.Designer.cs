namespace Apartment_manager_app
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 586);
            this.panel1.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Apartment_manager_app.Properties.Resources._311026941_781878482875279_3783944146323230924_n;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 21);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(60, 54);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.btnLogoClick);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.HoverState.Image")));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2Button4.Location = new System.Drawing.Point(7, 471);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(59, 45);
            this.guna2Button4.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.White;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.Image = global::Apartment_manager_app.Properties.Resources.icons8_settings_96px_2;
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSetting.Location = new System.Drawing.Point(7, 260);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(59, 45);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Click += new System.EventHandler(this.btnSettingClick);
            // 
            // BtnMenu
            // 
            this.BtnMenu.CheckedState.Parent = this.BtnMenu;
            this.BtnMenu.CustomImages.Parent = this.BtnMenu;
            this.BtnMenu.FillColor = System.Drawing.Color.White;
            this.BtnMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnMenu.HoverState.Image = global::Apartment_manager_app.Properties.Resources.icons8_squared_menu_96px;
            this.BtnMenu.HoverState.Parent = this.BtnMenu;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnMenu.Location = new System.Drawing.Point(7, 184);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.ShadowDecoration.Parent = this.BtnMenu;
            this.BtnMenu.Size = new System.Drawing.Size(59, 45);
            this.BtnMenu.TabIndex = 3;
            this.BtnMenu.Click += new System.EventHandler(this.btnApp_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.CheckedState.Parent = this.BtnHome;
            this.BtnHome.CustomImages.Parent = this.BtnHome;
            this.BtnHome.FillColor = System.Drawing.Color.White;
            this.BtnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnHome.HoverState.Image = global::Apartment_manager_app.Properties.Resources.icons8_home_96px_31;
            this.BtnHome.HoverState.Parent = this.BtnHome;
            this.BtnHome.Image = global::Apartment_manager_app.Properties.Resources.icons8_home_24px;
            this.BtnHome.ImageSize = new System.Drawing.Size(24, 24);
            this.BtnHome.Location = new System.Drawing.Point(7, 106);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.ShadowDecoration.Parent = this.BtnHome;
            this.BtnHome.Size = new System.Drawing.Size(59, 45);
            this.BtnHome.TabIndex = 4;
            this.BtnHome.Click += new System.EventHandler(this.btnHome_click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1152, 586);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.FrmMain_MdiChildActivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventKey);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private Guna.UI2.WinForms.Guna2Button BtnMenu;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}