namespace Apartment_manager_app
{
    partial class FrmServices
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
            this.dgvSrevices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ContainerData = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmadv = new System.Windows.Forms.TextBox();
            this.txttendv = new System.Windows.Forms.TextBox();
            this.giadv = new System.Windows.Forms.TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnremove = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnedit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnadd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.clma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrevices)).BeginInit();
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
            this.btnback.Location = new System.Drawing.Point(-1, -1);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(112, 45);
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
            this.txtvalue.Location = new System.Drawing.Point(39, 87);
            this.txtvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.PasswordChar = '\0';
            this.txtvalue.PlaceholderText = "";
            this.txtvalue.SelectedText = "";
            this.txtvalue.ShadowDecoration.Parent = this.txtvalue;
            this.txtvalue.Size = new System.Drawing.Size(276, 38);
            this.txtvalue.TabIndex = 3;
            // 
            // btnfind
            // 
            this.btnfind.CheckedState.Parent = this.btnfind;
            this.btnfind.CustomImages.Parent = this.btnfind;
            this.btnfind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.HoverState.Parent = this.btnfind;
            this.btnfind.Location = new System.Drawing.Point(311, 87);
            this.btnfind.Name = "btnfind";
            this.btnfind.ShadowDecoration.Parent = this.btnfind;
            this.btnfind.Size = new System.Drawing.Size(164, 38);
            this.btnfind.TabIndex = 4;
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
            this.btnCreate.Location = new System.Drawing.Point(580, 87);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(164, 38);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Tạo mới";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.guna2GroupBox1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(12, 150);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1095, 390);
            this.guna2GradientPanel1.TabIndex = 13;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Controls.Add(this.ContainerData);
            this.guna2GroupBox1.Controls.Add(this.dgvSrevices);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1095, 390);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Bảng thông tin dịch vụ";
            // 
            // dgvSrevices
            // 
            this.dgvSrevices.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSrevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSrevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSrevices.BackgroundColor = System.Drawing.Color.White;
            this.dgvSrevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSrevices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSrevices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSrevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSrevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSrevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clma,
            this.clten,
            this.clgia});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSrevices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSrevices.EnableHeadersVisualStyles = false;
            this.dgvSrevices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSrevices.Location = new System.Drawing.Point(0, 40);
            this.dgvSrevices.Name = "dgvSrevices";
            this.dgvSrevices.RowHeadersVisible = false;
            this.dgvSrevices.RowHeadersWidth = 62;
            this.dgvSrevices.RowTemplate.Height = 28;
            this.dgvSrevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSrevices.Size = new System.Drawing.Size(1092, 350);
            this.dgvSrevices.TabIndex = 0;
            this.dgvSrevices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSrevices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSrevices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSrevices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSrevices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSrevices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSrevices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSrevices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSrevices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSrevices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSrevices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSrevices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSrevices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSrevices.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvSrevices.ThemeStyle.ReadOnly = false;
            this.dgvSrevices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSrevices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSrevices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvSrevices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dgvSrevices.ThemeStyle.RowsStyle.Height = 28;
            this.dgvSrevices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSrevices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSrevices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSrevices_CellClick);
            // 
            // ContainerData
            // 
            this.ContainerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ContainerData.Controls.Add(this.btnadd);
            this.ContainerData.Controls.Add(this.btnedit);
            this.ContainerData.Controls.Add(this.btnremove);
            this.ContainerData.Controls.Add(this.btnClose);
            this.ContainerData.Controls.Add(this.giadv);
            this.ContainerData.Controls.Add(this.txttendv);
            this.ContainerData.Controls.Add(this.txtmadv);
            this.ContainerData.Controls.Add(this.label3);
            this.ContainerData.Controls.Add(this.label2);
            this.ContainerData.Controls.Add(this.label1);
            this.ContainerData.Location = new System.Drawing.Point(196, 0);
            this.ContainerData.Name = "ContainerData";
            this.ContainerData.ShadowDecoration.Parent = this.ContainerData;
            this.ContainerData.Size = new System.Drawing.Size(844, 272);
            this.ContainerData.TabIndex = 1;
            this.ContainerData.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gía";
            // 
            // txtmadv
            // 
            this.txtmadv.Location = new System.Drawing.Point(176, 61);
            this.txtmadv.Name = "txtmadv";
            this.txtmadv.Size = new System.Drawing.Size(232, 31);
            this.txtmadv.TabIndex = 6;
            // 
            // txttendv
            // 
            this.txttendv.Location = new System.Drawing.Point(176, 138);
            this.txttendv.Name = "txttendv";
            this.txttendv.Size = new System.Drawing.Size(232, 31);
            this.txttendv.TabIndex = 7;
            // 
            // giadv
            // 
            this.giadv.Location = new System.Drawing.Point(507, 58);
            this.giadv.Name = "giadv";
            this.giadv.Size = new System.Drawing.Size(232, 31);
            this.giadv.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(738, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(106, 45);
            this.btnClose.TabIndex = 9;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnremove
            // 
            this.btnremove.CheckedState.Parent = this.btnremove;
            this.btnremove.CustomImages.Parent = this.btnremove;
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnremove.ForeColor = System.Drawing.Color.White;
            this.btnremove.HoverState.Parent = this.btnremove;
            this.btnremove.Location = new System.Drawing.Point(419, 213);
            this.btnremove.Name = "btnremove";
            this.btnremove.ShadowDecoration.Parent = this.btnremove;
            this.btnremove.Size = new System.Drawing.Size(117, 45);
            this.btnremove.TabIndex = 13;
            this.btnremove.Text = "Xóa";
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnedit
            // 
            this.btnedit.CheckedState.Parent = this.btnedit;
            this.btnedit.CustomImages.Parent = this.btnedit;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.HoverState.Parent = this.btnedit;
            this.btnedit.Location = new System.Drawing.Point(572, 213);
            this.btnedit.Name = "btnedit";
            this.btnedit.ShadowDecoration.Parent = this.btnedit;
            this.btnedit.Size = new System.Drawing.Size(117, 45);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Sửa";
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Location = new System.Drawing.Point(722, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(117, 45);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Thêm";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // clma
            // 
            this.clma.DataPropertyName = "Madichvu";
            this.clma.HeaderText = "Mã dịch vụ";
            this.clma.MinimumWidth = 8;
            this.clma.Name = "clma";
            // 
            // clten
            // 
            this.clten.DataPropertyName = "tendichvu";
            this.clten.HeaderText = "Tên dịch vụ";
            this.clten.MinimumWidth = 8;
            this.clten.Name = "clten";
            // 
            // clgia
            // 
            this.clgia.DataPropertyName = "giatien";
            this.clgia.HeaderText = "Gía";
            this.clgia.MinimumWidth = 8;
            this.clgia.Name = "clgia";
            // 
            // totalValue
            // 
            this.totalValue.AutoSize = true;
            this.totalValue.Location = new System.Drawing.Point(135, 554);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(44, 20);
            this.totalValue.TabIndex = 14;
            this.totalValue.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(186, 553);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(0, 20);
            this.total.TabIndex = 15;
            // 
            // FrmServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1119, 583);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmServices_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSrevices)).EndInit();
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
        private Guna.UI2.WinForms.Guna2GradientPanel ContainerData;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSrevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giadv;
        private System.Windows.Forms.TextBox txttendv;
        private System.Windows.Forms.TextBox txtmadv;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientButton btnremove;
        private Guna.UI2.WinForms.Guna2GradientButton btnedit;
        private Guna.UI2.WinForms.Guna2GradientButton btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clten;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgia;
        private System.Windows.Forms.Label totalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
    }
}