namespace DoAnHQTCSDL.UserControls.HocSinh
{
    partial class XemDiemHK2
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
            this.dgvHK2 = new System.Windows.Forms.DataGridView();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTTXuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKTGiuaKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDiemHK2 = new System.Windows.Forms.Label();
            this.txtHanhKiem = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXepHang = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDanhHieu = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtDiemTongKet = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHK2
            // 
            this.dgvHK2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHK2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHK2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonHoc,
            this.DiemKTTXuyen,
            this.DiemKTGiuaKy,
            this.DiemCuoiKy,
            this.TBM});
            this.dgvHK2.Location = new System.Drawing.Point(33, 86);
            this.dgvHK2.Name = "dgvHK2";
            this.dgvHK2.RowHeadersWidth = 62;
            this.dgvHK2.RowTemplate.Height = 28;
            this.dgvHK2.Size = new System.Drawing.Size(933, 415);
            this.dgvHK2.TabIndex = 7;
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
            // labelDiemHK2
            // 
            this.labelDiemHK2.AutoSize = true;
            this.labelDiemHK2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiemHK2.Location = new System.Drawing.Point(237, 20);
            this.labelDiemHK2.Name = "labelDiemHK2";
            this.labelDiemHK2.Size = new System.Drawing.Size(511, 45);
            this.labelDiemHK2.TabIndex = 6;
            this.labelDiemHK2.Text = "Bảng điểm các môn học học kỳ 2";
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
            this.txtHanhKiem.Location = new System.Drawing.Point(682, 528);
            this.txtHanhKiem.Name = "txtHanhKiem";
            this.txtHanhKiem.PasswordChar = '\0';
            this.txtHanhKiem.PlaceholderText = "";
            this.txtHanhKiem.SelectedText = "";
            this.txtHanhKiem.Size = new System.Drawing.Size(177, 54);
            this.txtHanhKiem.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(496, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 125;
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
            this.txtXepHang.Location = new System.Drawing.Point(682, 594);
            this.txtXepHang.Name = "txtXepHang";
            this.txtXepHang.PasswordChar = '\0';
            this.txtXepHang.PlaceholderText = "";
            this.txtXepHang.SelectedText = "";
            this.txtXepHang.Size = new System.Drawing.Size(177, 54);
            this.txtXepHang.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(48, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 123;
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
            this.txtDanhHieu.Location = new System.Drawing.Point(244, 594);
            this.txtDanhHieu.Name = "txtDanhHieu";
            this.txtDanhHieu.PasswordChar = '\0';
            this.txtDanhHieu.PlaceholderText = "";
            this.txtDanhHieu.SelectedText = "";
            this.txtDanhHieu.Size = new System.Drawing.Size(177, 51);
            this.txtDanhHieu.TabIndex = 122;
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
            this.txtDiemTongKet.Location = new System.Drawing.Point(244, 528);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.PasswordChar = '\0';
            this.txtDiemTongKet.PlaceholderText = "";
            this.txtDiemTongKet.SelectedText = "";
            this.txtDiemTongKet.Size = new System.Drawing.Size(177, 54);
            this.txtDiemTongKet.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.CadetBlue;
            this.label7.Location = new System.Drawing.Point(496, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 32);
            this.label7.TabIndex = 120;
            this.label7.Text = "Xếp Hạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.CadetBlue;
            this.label9.Location = new System.Drawing.Point(48, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 32);
            this.label9.TabIndex = 119;
            this.label9.Text = "Điểm Tổng Kết:";
            // 
            // XemDiemHK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtHanhKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXepHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDanhHieu);
            this.Controls.Add(this.txtDiemTongKet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvHK2);
            this.Controls.Add(this.labelDiemHK2);
            this.Name = "XemDiemHK2";
            this.Size = new System.Drawing.Size(994, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHK2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTTXuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemKTGiuaKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBM;
        private System.Windows.Forms.Label labelDiemHK2;
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
