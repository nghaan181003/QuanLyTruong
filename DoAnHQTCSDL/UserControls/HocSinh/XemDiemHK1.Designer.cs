namespace DoAnHQTCSDL.UserControls
{
    partial class XemDiemHK1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHK1 = new System.Windows.Forms.DataGridView();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTTXuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDiemHK1 = new System.Windows.Forms.Label();
            this.txtHanhKiem = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXepHang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDanhHieu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtDiemTongKet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHK1
            // 
            this.dgvHK1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHK1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHK1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonHoc,
            this.DiemKTTXuyen,
            this.DiemKTGiuaKy,
            this.DiemCuoiKy,
            this.TBM});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHK1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHK1.Location = new System.Drawing.Point(22, 56);
            this.dgvHK1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHK1.Name = "dgvHK1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHK1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHK1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHK1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHK1.RowTemplate.Height = 28;
            this.dgvHK1.Size = new System.Drawing.Size(622, 270);
            this.dgvHK1.TabIndex = 9;
            // 
            // MonHoc
            // 
            this.MonHoc.HeaderText = "Môn học";
            this.MonHoc.MinimumWidth = 8;
            this.MonHoc.Name = "MonHoc";
            // 
            // DiemKTTXuyen
            // 
            this.DiemKTTXuyen.HeaderText = "Điểm KT Thường Xuyên";
            this.DiemKTTXuyen.MinimumWidth = 8;
            this.DiemKTTXuyen.Name = "DiemKTTXuyen";
            // 
            // DiemKTGiuaKy
            // 
            this.DiemKTGiuaKy.HeaderText = "Điểm KT Giữa Kỳ";
            this.DiemKTGiuaKy.MinimumWidth = 8;
            this.DiemKTGiuaKy.Name = "DiemKTGiuaKy";
            // 
            // DiemCuoiKy
            // 
            this.DiemCuoiKy.HeaderText = "Điểm Cuối Kỳ";
            this.DiemCuoiKy.MinimumWidth = 8;
            this.DiemCuoiKy.Name = "DiemCuoiKy";
            // 
            // TBM
            // 
            this.TBM.HeaderText = "TBM";
            this.TBM.MinimumWidth = 8;
            this.TBM.Name = "TBM";
            // 
            // labelDiemHK1
            // 
            this.labelDiemHK1.AutoSize = true;
            this.labelDiemHK1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelDiemHK1.Location = new System.Drawing.Point(158, 13);
            this.labelDiemHK1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiemHK1.Name = "labelDiemHK1";
            this.labelDiemHK1.Size = new System.Drawing.Size(337, 30);
            this.labelDiemHK1.TabIndex = 8;
            this.labelDiemHK1.Text = "Bảng điểm các môn học học kỳ 1";
            // 
            // txtHanhKiem
            // 
            this.txtHanhKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHanhKiem.DefaultText = "";
            this.txtHanhKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHanhKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHanhKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHanhKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHanhKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHanhKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHanhKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHanhKiem.Location = new System.Drawing.Point(455, 343);
            this.txtHanhKiem.Name = "txtHanhKiem";
            this.txtHanhKiem.PasswordChar = '\0';
            this.txtHanhKiem.PlaceholderText = "";
            this.txtHanhKiem.SelectedText = "";
            this.txtHanhKiem.Size = new System.Drawing.Size(118, 35);
            this.txtHanhKiem.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(331, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 133;
            this.label1.Text = "Hạnh Kiểm:";
            // 
            // txtXepHang
            // 
            this.txtXepHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXepHang.DefaultText = "";
            this.txtXepHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXepHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXepHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXepHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXepHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXepHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXepHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXepHang.Location = new System.Drawing.Point(455, 386);
            this.txtXepHang.Name = "txtXepHang";
            this.txtXepHang.PasswordChar = '\0';
            this.txtXepHang.PlaceholderText = "";
            this.txtXepHang.SelectedText = "";
            this.txtXepHang.Size = new System.Drawing.Size(118, 35);
            this.txtXepHang.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(32, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 131;
            this.label2.Text = "Danh Hiệu:";
            // 
            // txtDanhHieu
            // 
            this.txtDanhHieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanhHieu.DefaultText = "";
            this.txtDanhHieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDanhHieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDanhHieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanhHieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanhHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanhHieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhHieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanhHieu.Location = new System.Drawing.Point(163, 386);
            this.txtDanhHieu.Name = "txtDanhHieu";
            this.txtDanhHieu.PasswordChar = '\0';
            this.txtDanhHieu.PlaceholderText = "";
            this.txtDanhHieu.SelectedText = "";
            this.txtDanhHieu.Size = new System.Drawing.Size(118, 33);
            this.txtDanhHieu.TabIndex = 130;
            // 
            // txtDiemTongKet
            // 
            this.txtDiemTongKet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiemTongKet.DefaultText = "";
            this.txtDiemTongKet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiemTongKet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiemTongKet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemTongKet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiemTongKet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemTongKet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTongKet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiemTongKet.Location = new System.Drawing.Point(163, 343);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.PasswordChar = '\0';
            this.txtDiemTongKet.PlaceholderText = "";
            this.txtDiemTongKet.SelectedText = "";
            this.txtDiemTongKet.Size = new System.Drawing.Size(118, 35);
            this.txtDiemTongKet.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(331, 393);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 128;
            this.label7.Text = "Xếp Hạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(32, 349);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 127;
            this.label9.Text = "Điểm Tổng Kết:";
            // 
            // XemDiemHK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHanhKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXepHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDanhHieu);
            this.Controls.Add(this.txtDiemTongKet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvHK1);
            this.Controls.Add(this.labelDiemHK1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemDiemHK1";
            this.Size = new System.Drawing.Size(663, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTTXuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBM;
        private System.Windows.Forms.Label labelDiemHK1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtHanhKiem;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtXepHang;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDanhHieu;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtDiemTongKet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}
