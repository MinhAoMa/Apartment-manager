namespace Apartment_manager_app
{
    partial class FrmElectric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmElectric));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtvalue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnfind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvElectric = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmacanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltsodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnexcel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContainerData = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cbbcanho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnremove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnedit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnadd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.toogleStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbbmonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.btnBacktomenu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).BeginInit();
            this.ContainerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvalue
            // 
            this.txtvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvalue.DefaultText = "";
            this.txtvalue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtvalue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtvalue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalue.DisabledState.Parent = this.txtvalue;
            this.txtvalue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalue.FocusedState.Parent = this.txtvalue;
            this.txtvalue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalue.HoverState.Parent = this.txtvalue;
            resources.ApplyResources(this.txtvalue, "txtvalue");
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.PasswordChar = '\0';
            this.txtvalue.PlaceholderText = "";
            this.txtvalue.SelectedText = "";
            this.txtvalue.ShadowDecoration.Parent = this.txtvalue;
            // 
            // btnfind
            // 
            this.btnfind.BorderRadius = 10;
            this.btnfind.CheckedState.Parent = this.btnfind;
            this.btnfind.CustomImages.Parent = this.btnfind;
            this.btnfind.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnfind.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnfind, "btnfind");
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.HoverState.Parent = this.btnfind;
            this.btnfind.Name = "btnfind";
            this.btnfind.ShadowDecoration.Parent = this.btnfind;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreate.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2GroupBox1);
            resources.ApplyResources(this.guna2GradientPanel1, "guna2GradientPanel1");
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.dgvElectric);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.guna2GroupBox1, "guna2GroupBox1");
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            // 
            // dgvElectric
            // 
            this.dgvElectric.AllowUserToAddRows = false;
            this.dgvElectric.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvElectric.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvElectric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElectric.BackgroundColor = System.Drawing.Color.White;
            this.dgvElectric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElectric.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElectric.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Asap SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElectric.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dgvElectric, "dgvElectric");
            this.dgvElectric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clmacanho,
            this.cltsodien,
            this.clthang,
            this.cltrangthai,
            this.cltien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Asap SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElectric.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvElectric.EnableHeadersVisualStyles = false;
            this.dgvElectric.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElectric.Name = "dgvElectric";
            this.dgvElectric.RowHeadersVisible = false;
            this.dgvElectric.RowTemplate.Height = 28;
            this.dgvElectric.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElectric.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvElectric.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvElectric.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvElectric.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvElectric.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvElectric.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElectric.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvElectric.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvElectric.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Asap SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvElectric.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvElectric.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvElectric.ThemeStyle.ReadOnly = false;
            this.dgvElectric.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElectric.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Asap SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dgvElectric.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvElectric.ThemeStyle.RowsStyle.Height = 28;
            this.dgvElectric.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElectric.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvElectric.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElectric_CellClick);
            this.dgvElectric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElectric_CellContentClick);
            // 
            // clid
            // 
            this.clid.DataPropertyName = "ID";
            resources.ApplyResources(this.clid, "clid");
            this.clid.Name = "clid";
            // 
            // clmacanho
            // 
            this.clmacanho.DataPropertyName = "Macanho";
            resources.ApplyResources(this.clmacanho, "clmacanho");
            this.clmacanho.Name = "clmacanho";
            // 
            // cltsodien
            // 
            this.cltsodien.DataPropertyName = "sodien";
            resources.ApplyResources(this.cltsodien, "cltsodien");
            this.cltsodien.Name = "cltsodien";
            // 
            // clthang
            // 
            this.clthang.DataPropertyName = "Thang";
            resources.ApplyResources(this.clthang, "clthang");
            this.clthang.Name = "clthang";
            // 
            // cltrangthai
            // 
            this.cltrangthai.DataPropertyName = "trangthai";
            resources.ApplyResources(this.cltrangthai, "cltrangthai");
            this.cltrangthai.Name = "cltrangthai";
            // 
            // cltien
            // 
            this.cltien.DataPropertyName = "tongtien";
            resources.ApplyResources(this.cltien, "cltien");
            this.cltien.Name = "cltien";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 10;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.guna2GradientButton4, "guna2GradientButton4");
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.BorderRadius = 10;
            this.btnexcel.CheckedState.Parent = this.btnexcel;
            this.btnexcel.CustomImages.Parent = this.btnexcel;
            this.btnexcel.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnexcel.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnexcel, "btnexcel");
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.HoverState.Parent = this.btnexcel;
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.ShadowDecoration.Parent = this.btnexcel;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.BorderRadius = 10;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.guna2GradientButton6, "guna2GradientButton6");
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            // 
            // ContainerData
            // 
            this.ContainerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ContainerData.Controls.Add(this.cbbcanho);
            this.ContainerData.Controls.Add(this.btnremove);
            this.ContainerData.Controls.Add(this.btnedit);
            this.ContainerData.Controls.Add(this.btnadd);
            this.ContainerData.Controls.Add(this.toogleStatus);
            this.ContainerData.Controls.Add(this.label4);
            this.ContainerData.Controls.Add(this.txtdien);
            this.ContainerData.Controls.Add(this.label3);
            this.ContainerData.Controls.Add(this.txtmonth);
            this.ContainerData.Controls.Add(this.label2);
            this.ContainerData.Controls.Add(this.label1);
            this.ContainerData.Controls.Add(this.btnClose);
            resources.ApplyResources(this.ContainerData, "ContainerData");
            this.ContainerData.Name = "ContainerData";
            this.ContainerData.ShadowDecoration.Parent = this.ContainerData;
            // 
            // cbbcanho
            // 
            this.cbbcanho.BackColor = System.Drawing.Color.Transparent;
            this.cbbcanho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbcanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcanho.FocusedColor = System.Drawing.Color.Empty;
            this.cbbcanho.FocusedState.Parent = this.cbbcanho;
            resources.ApplyResources(this.cbbcanho, "cbbcanho");
            this.cbbcanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbcanho.FormattingEnabled = true;
            this.cbbcanho.HoverState.Parent = this.cbbcanho;
            this.cbbcanho.ItemsAppearance.Parent = this.cbbcanho;
            this.cbbcanho.Name = "cbbcanho";
            this.cbbcanho.ShadowDecoration.Parent = this.cbbcanho;
            // 
            // btnremove
            // 
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnremove.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnremove, "btnremove");
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnedit
            // 
            this.btnedit.CheckedState.Parent = this.btnedit;
            this.btnedit.CustomImages.Parent = this.btnedit;
            this.btnedit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnedit.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnedit, "btnedit");
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.HoverState.Parent = this.btnedit;
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Parent = this.btnedit;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnadd.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnadd, "btnadd");
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // toogleStatus
            // 
            this.toogleStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toogleStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toogleStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toogleStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toogleStatus.CheckedState.Parent = this.toogleStatus;
            resources.ApplyResources(this.toogleStatus, "toogleStatus");
            this.toogleStatus.Name = "toogleStatus";
            this.toogleStatus.ShadowDecoration.Parent = this.toogleStatus;
            this.toogleStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toogleStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toogleStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toogleStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toogleStatus.UncheckedState.Parent = this.toogleStatus;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtdien
            // 
            resources.ApplyResources(this.txtdien, "txtdien");
            this.txtdien.Name = "txtdien";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtmonth
            // 
            resources.ApplyResources(this.txtmonth, "txtmonth");
            this.txtmonth.Name = "txtmonth";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClose.FillColor2 = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Apartment_manager_app.Properties.Resources.error__1_;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbbmonth
            // 
            this.cbbmonth.BackColor = System.Drawing.Color.Transparent;
            this.cbbmonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmonth.FocusedColor = System.Drawing.Color.Empty;
            this.cbbmonth.FocusedState.Parent = this.cbbmonth;
            resources.ApplyResources(this.cbbmonth, "cbbmonth");
            this.cbbmonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbmonth.FormattingEnabled = true;
            this.cbbmonth.HoverState.Parent = this.cbbmonth;
            this.cbbmonth.Items.AddRange(new object[] {
            resources.GetString("cbbmonth.Items"),
            resources.GetString("cbbmonth.Items1")});
            this.cbbmonth.ItemsAppearance.Parent = this.cbbmonth;
            this.cbbmonth.Name = "cbbmonth";
            this.cbbmonth.ShadowDecoration.Parent = this.cbbmonth;
            this.cbbmonth.SelectionChangeCommitted += new System.EventHandler(this.cbbmonth_SelectionChangeCommitted);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // active
            // 
            resources.ApplyResources(this.active, "active");
            this.active.Name = "active";
            // 
            // total
            // 
            resources.ApplyResources(this.total, "total");
            this.total.Name = "total";
            // 
            // btnBacktomenu
            // 
            this.btnBacktomenu.BorderRadius = 9;
            this.btnBacktomenu.CheckedState.Parent = this.btnBacktomenu;
            this.btnBacktomenu.CustomImages.Parent = this.btnBacktomenu;
            this.btnBacktomenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))));
            this.btnBacktomenu.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(127)))), ((int)(((byte)(246)))));
            resources.ApplyResources(this.btnBacktomenu, "btnBacktomenu");
            this.btnBacktomenu.ForeColor = System.Drawing.Color.White;
            this.btnBacktomenu.HoverState.Parent = this.btnBacktomenu;
            this.btnBacktomenu.Image = ((System.Drawing.Image)(resources.GetObject("btnBacktomenu.Image")));
            this.btnBacktomenu.ImageOffset = new System.Drawing.Point(3, 3);
            this.btnBacktomenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBacktomenu.Name = "btnBacktomenu";
            this.btnBacktomenu.ShadowDecoration.Parent = this.btnBacktomenu;
            this.btnBacktomenu.Click += new System.EventHandler(this.btnBacktomenu_Click);
            // 
            // FrmElectric
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnBacktomenu);
            this.Controls.Add(this.ContainerData);
            this.Controls.Add(this.total);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbmonth);
            this.Controls.Add(this.guna2GradientButton6);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtvalue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmElectric";
            this.Load += new System.EventHandler(this.FrmElectric_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).EndInit();
            this.ContainerData.ResumeLayout(false);
            this.ContainerData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtvalue;
        private Guna.UI2.WinForms.Guna2GradientButton btnfind;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreate;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvElectric;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton btnexcel;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientPanel ContainerData;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toogleStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnremove;
        private Guna.UI2.WinForms.Guna2GradientButton btnedit;
        private Guna.UI2.WinForms.Guna2GradientButton btnadd;
        private Guna.UI2.WinForms.Guna2ComboBox cbbcanho;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label total;
        private Guna.UI2.WinForms.Guna2GradientButton btnBacktomenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmacanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltsodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltien;
    }
}