namespace Apartment_manager_app
{
    partial class FrmManagerService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvql = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvql)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvql
            // 
            this.dgvql.AllowUserToAddRows = false;
            this.dgvql.AllowUserToDeleteRows = false;
            this.dgvql.AllowUserToResizeColumns = false;
            this.dgvql.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvql.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvql.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvql.BackgroundColor = System.Drawing.Color.White;
            this.dgvql.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvql.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvql.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvql.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvql.ColumnHeadersHeight = 32;
            this.dgvql.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvql.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvql.EnableHeadersVisualStyles = false;
            this.dgvql.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvql.Location = new System.Drawing.Point(12, 124);
            this.dgvql.Name = "dgvql";
            this.dgvql.RowHeadersVisible = false;
            this.dgvql.RowHeadersWidth = 62;
            this.dgvql.RowTemplate.Height = 28;
            this.dgvql.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvql.Size = new System.Drawing.Size(1095, 363);
            this.dgvql.TabIndex = 0;
            this.dgvql.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvql.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvql.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvql.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvql.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvql.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvql.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvql.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvql.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvql.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvql.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvql.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvql.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvql.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvql.ThemeStyle.ReadOnly = false;
            this.dgvql.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvql.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvql.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvql.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvql.ThemeStyle.RowsStyle.Height = 28;
            this.dgvql.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvql.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "macanho";
            this.Column1.HeaderText = "Mã căn hộ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tendichvu";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(20, 65);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(300, 37);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(316, 65);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 37);
            this.guna2GradientButton1.TabIndex = 2;
            this.guna2GradientButton1.Text = "Tìm kiếm";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = global::Apartment_manager_app.Properties.Resources.icons8_left_96px;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2GradientButton2.Location = new System.Drawing.Point(1, -1);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(110, 45);
            this.guna2GradientButton2.TabIndex = 3;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Location = new System.Drawing.Point(973, 507);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(134, 45);
            this.guna2GradientButton3.TabIndex = 4;
            this.guna2GradientButton3.Text = "Excel";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(816, 507);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(134, 45);
            this.guna2GradientButton4.TabIndex = 5;
            this.guna2GradientButton4.Text = "Báo cáo";
            // 
            // FrmManagerService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(219)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1119, 583);
            this.Controls.Add(this.guna2GradientButton4);
            this.Controls.Add(this.guna2GradientButton3);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.dgvql);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManagerService";
            this.Text = "FrmManagerService";
            this.Load += new System.EventHandler(this.FrmManagerService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvql;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
    }
}