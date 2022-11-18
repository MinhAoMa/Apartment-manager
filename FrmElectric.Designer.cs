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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnback = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtvalue = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnfind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvElectric = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnexcel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContainerData = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.toogleStatus = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnadd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnedit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnremove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbbcanho = new Guna.UI2.WinForms.Guna2ComboBox();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmacanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltsodien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clthang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbmonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElectric)).BeginInit();
            this.ContainerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.CheckedState.Parent = this.btnback;
            this.btnback.CustomImages.Parent = this.btnback;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.HoverState.Parent = this.btnback;
            this.btnback.Image = global::Apartment_manager_app.Properties.Resources.icons8_left_96px;
            this.btnback.ImageSize = new System.Drawing.Size(25, 25);
            this.btnback.Location = new System.Drawing.Point(-1, 0);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(106, 45);
            this.btnback.TabIndex = 0;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
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
            this.txtvalue.Location = new System.Drawing.Point(39, 91);
            this.txtvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.PasswordChar = '\0';
            this.txtvalue.PlaceholderText = "";
            this.txtvalue.SelectedText = "";
            this.txtvalue.ShadowDecoration.Parent = this.txtvalue;
            this.txtvalue.Size = new System.Drawing.Size(276, 38);
            this.txtvalue.TabIndex = 2;
            // 
            // btnfind
            // 
            this.btnfind.CheckedState.Parent = this.btnfind;
            this.btnfind.CustomImages.Parent = this.btnfind;
            this.btnfind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.HoverState.Parent = this.btnfind;
            this.btnfind.Location = new System.Drawing.Point(313, 91);
            this.btnfind.Name = "btnfind";
            this.btnfind.ShadowDecoration.Parent = this.btnfind;
            this.btnfind.Size = new System.Drawing.Size(164, 38);
            this.btnfind.TabIndex = 3;
            this.btnfind.Text = "Tìm kiếm";
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(691, 91);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(164, 38);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, 148);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1118, 377);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.dgvElectric);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1118, 377);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông tin tiền điện";
            // 
            // dgvElectric
            // 
            this.dgvElectric.AllowUserToAddRows = false;
            this.dgvElectric.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvElectric.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvElectric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElectric.BackgroundColor = System.Drawing.Color.White;
            this.dgvElectric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvElectric.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElectric.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvElectric.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvElectric.ColumnHeadersHeight = 50;
            this.dgvElectric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clmacanho,
            this.cltsodien,
            this.clthang,
            this.cltrangthai,
            this.cltien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvElectric.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvElectric.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvElectric.EnableHeadersVisualStyles = false;
            this.dgvElectric.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElectric.Location = new System.Drawing.Point(0, 39);
            this.dgvElectric.Name = "dgvElectric";
            this.dgvElectric.RowHeadersVisible = false;
            this.dgvElectric.RowHeadersWidth = 62;
            this.dgvElectric.RowTemplate.Height = 28;
            this.dgvElectric.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElectric.Size = new System.Drawing.Size(1118, 338);
            this.dgvElectric.TabIndex = 0;
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
            this.dgvElectric.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvElectric.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvElectric.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvElectric.ThemeStyle.ReadOnly = false;
            this.dgvElectric.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvElectric.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvElectric.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvElectric.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Gray;
            this.dgvElectric.ThemeStyle.RowsStyle.Height = 28;
            this.dgvElectric.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvElectric.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvElectric.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElectric_CellClick);
            this.dgvElectric.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElectric_CellContentClick);
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(902, 533);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(164, 38);
            this.guna2GradientButton4.TabIndex = 7;
            this.guna2GradientButton4.Text = "Refesh";
            this.guna2GradientButton4.Click += new System.EventHandler(this.guna2GradientButton4_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.CheckedState.Parent = this.btnexcel;
            this.btnexcel.CustomImages.Parent = this.btnexcel;
            this.btnexcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexcel.ForeColor = System.Drawing.Color.White;
            this.btnexcel.HoverState.Parent = this.btnexcel;
            this.btnexcel.Location = new System.Drawing.Point(721, 533);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.ShadowDecoration.Parent = this.btnexcel;
            this.btnexcel.Size = new System.Drawing.Size(164, 38);
            this.btnexcel.TabIndex = 8;
            this.btnexcel.Text = "Excel";
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Location = new System.Drawing.Point(539, 533);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(164, 38);
            this.guna2GradientButton6.TabIndex = 9;
            this.guna2GradientButton6.Text = "Báo cáo";
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
            this.ContainerData.Location = new System.Drawing.Point(206, 148);
            this.ContainerData.Name = "ContainerData";
            this.ContainerData.ShadowDecoration.Parent = this.ContainerData;
            this.ContainerData.Size = new System.Drawing.Size(658, 377);
            this.ContainerData.TabIndex = 1;
            this.ContainerData.Visible = false;
            // 
            // toogleStatus
            // 
            this.toogleStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toogleStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toogleStatus.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toogleStatus.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toogleStatus.CheckedState.Parent = this.toogleStatus;
            this.toogleStatus.Location = new System.Drawing.Point(428, 133);
            this.toogleStatus.Name = "toogleStatus";
            this.toogleStatus.ShadowDecoration.Parent = this.toogleStatus;
            this.toogleStatus.Size = new System.Drawing.Size(53, 20);
            this.toogleStatus.TabIndex = 9;
            this.toogleStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toogleStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toogleStatus.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toogleStatus.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toogleStatus.UncheckedState.Parent = this.toogleStatus;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trạng thái";
            // 
            // txtdien
            // 
            this.txtdien.Location = new System.Drawing.Point(428, 200);
            this.txtdien.Name = "txtdien";
            this.txtdien.Size = new System.Drawing.Size(173, 26);
            this.txtdien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số điện";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(133, 202);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(170, 26);
            this.txtmonth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã căn hộ";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Apartment_manager_app.Properties.Resources.icons8_delete_sign_24px;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(552, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(106, 45);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnadd
            // 
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Location = new System.Drawing.Point(532, 329);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(117, 45);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "Thêm";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.CheckedState.Parent = this.btnedit;
            this.btnedit.CustomImages.Parent = this.btnedit;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.HoverState.Parent = this.btnedit;
            this.btnedit.Location = new System.Drawing.Point(395, 329);
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Parent = this.btnedit;
            this.btnedit.Size = new System.Drawing.Size(117, 45);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Location = new System.Drawing.Point(260, 329);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(117, 45);
            this.btnremove.TabIndex = 12;
            this.btnremove.Text = "Xóa";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // cbbcanho
            // 
            this.cbbcanho.BackColor = System.Drawing.Color.Transparent;
            this.cbbcanho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbcanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbcanho.FocusedColor = System.Drawing.Color.Empty;
            this.cbbcanho.FocusedState.Parent = this.cbbcanho;
            this.cbbcanho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbcanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbcanho.FormattingEnabled = true;
            this.cbbcanho.HoverState.Parent = this.cbbcanho;
            this.cbbcanho.ItemHeight = 30;
            this.cbbcanho.ItemsAppearance.Parent = this.cbbcanho;
            this.cbbcanho.Location = new System.Drawing.Point(133, 133);
            this.cbbcanho.Name = "cbbcanho";
            this.cbbcanho.ShadowDecoration.Parent = this.cbbcanho;
            this.cbbcanho.Size = new System.Drawing.Size(170, 36);
            this.cbbcanho.TabIndex = 15;
            // 
            // clid
            // 
            this.clid.DataPropertyName = "ID";
            this.clid.HeaderText = "ID";
            this.clid.MinimumWidth = 8;
            this.clid.Name = "clid";
            // 
            // clmacanho
            // 
            this.clmacanho.DataPropertyName = "Macanho";
            this.clmacanho.HeaderText = "Mã căn hộ";
            this.clmacanho.MinimumWidth = 8;
            this.clmacanho.Name = "clmacanho";
            // 
            // cltsodien
            // 
            this.cltsodien.DataPropertyName = "sodien";
            this.cltsodien.HeaderText = "Số điện";
            this.cltsodien.MinimumWidth = 8;
            this.cltsodien.Name = "cltsodien";
            // 
            // clthang
            // 
            this.clthang.DataPropertyName = "Thang";
            this.clthang.HeaderText = "Tháng";
            this.clthang.MinimumWidth = 8;
            this.clthang.Name = "clthang";
            // 
            // cltrangthai
            // 
            this.cltrangthai.DataPropertyName = "trangthai";
            this.cltrangthai.HeaderText = "Trạng thái";
            this.cltrangthai.MinimumWidth = 8;
            this.cltrangthai.Name = "cltrangthai";
            // 
            // cltien
            // 
            this.cltien.DataPropertyName = "tongtien";
            this.cltien.HeaderText = "Tổng tiền";
            this.cltien.MinimumWidth = 8;
            this.cltien.Name = "cltien";
            // 
            // cbbmonth
            // 
            this.cbbmonth.BackColor = System.Drawing.Color.Transparent;
            this.cbbmonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmonth.FocusedColor = System.Drawing.Color.Empty;
            this.cbbmonth.FocusedState.Parent = this.cbbmonth;
            this.cbbmonth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbmonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbmonth.FormattingEnabled = true;
            this.cbbmonth.HoverState.Parent = this.cbbmonth;
            this.cbbmonth.ItemHeight = 30;
            this.cbbmonth.Items.AddRange(new object[] {
            "Đã nộp",
            "Chưa nộp"});
            this.cbbmonth.ItemsAppearance.Parent = this.cbbmonth;
            this.cbbmonth.Location = new System.Drawing.Point(501, 91);
            this.cbbmonth.Name = "cbbmonth";
            this.cbbmonth.ShadowDecoration.Parent = this.cbbmonth;
            this.cbbmonth.Size = new System.Drawing.Size(156, 36);
            this.cbbmonth.TabIndex = 10;
            this.cbbmonth.SelectionChangeCommitted += new System.EventHandler(this.cbbmonth_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Active";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Location = new System.Drawing.Point(335, 551);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(0, 20);
            this.active.TabIndex = 13;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(105, 551);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 20);
            this.total.TabIndex = 14;
            // 
            // FrmElectric
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1119, 583);
            this.Controls.Add(this.total);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbmonth);
            this.Controls.Add(this.ContainerData);
            this.Controls.Add(this.guna2GradientButton6);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmElectric";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmElectric";
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

        private Guna.UI2.WinForms.Guna2GradientButton btnback;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmacanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltsodien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clthang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltien;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label active;
        private System.Windows.Forms.Label total;
    }
}