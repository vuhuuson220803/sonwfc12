namespace WFP_QuanLyNhanVien
{
    partial class Form1
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
            this.uiNhóm_Máu = new System.Windows.Forms.ComboBox();
            this.uiNăm_Sinh = new System.Windows.Forms.TextBox();
            this.uiNút_Hủy = new System.Windows.Forms.Button();
            this.uiNút_Lưu = new System.Windows.Forms.Button();
            this.uiNút_Duyệt_Ảnh = new System.Windows.Forms.Button();
            this.uiGiới_Tính = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiLương = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTên = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiẢnh = new System.Windows.Forms.PictureBox();
            this.uiNút_Đầu_Tiên = new System.Windows.Forms.Button();
            this.uiNút_Trước_Đó = new System.Windows.Forms.Button();
            this.uiNút_Sau_Đó = new System.Windows.Forms.Button();
            this.uiNút_Cuối_Cùng = new System.Windows.Forms.Button();
            this.uiNút_Xóa = new System.Windows.Forms.Button();
            this.uiNút_Sửa = new System.Windows.Forms.Button();
            this.uiNút_Thêm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBảng = new System.Windows.Forms.DataGridView();
            this.nhânViênBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new WFP_QuanLyNhanVien.DBDataSet();
            this.nhân_ViênTableAdapter = new WFP_QuanLyNhanVien.DBDataSetTableAdapters.Nhân_ViênTableAdapter();
            this.mãNhânViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênNhânViênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nămSinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lươngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhómMáuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giớiTínhDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Giới_Tính_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ảnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBảng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uiNhóm_Máu
            // 
            this.uiNhóm_Máu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhânViênBindingSource, "Nhóm_Máu", true));
            this.uiNhóm_Máu.FormattingEnabled = true;
            this.uiNhóm_Máu.Items.AddRange(new object[] {
            "A",
            "B",
            "O"});
            this.uiNhóm_Máu.Location = new System.Drawing.Point(346, 473);
            this.uiNhóm_Máu.Name = "uiNhóm_Máu";
            this.uiNhóm_Máu.Size = new System.Drawing.Size(139, 21);
            this.uiNhóm_Máu.TabIndex = 103;
            // 
            // uiNăm_Sinh
            // 
            this.uiNăm_Sinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhânViênBindingSource, "Năm_Sinh", true));
            this.uiNăm_Sinh.Location = new System.Drawing.Point(346, 383);
            this.uiNăm_Sinh.Name = "uiNăm_Sinh";
            this.uiNăm_Sinh.Size = new System.Drawing.Size(248, 20);
            this.uiNăm_Sinh.TabIndex = 102;
            // 
            // uiNút_Hủy
            // 
            this.uiNút_Hủy.Location = new System.Drawing.Point(507, 571);
            this.uiNút_Hủy.Name = "uiNút_Hủy";
            this.uiNút_Hủy.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Hủy.TabIndex = 101;
            this.uiNút_Hủy.Text = "Hủy";
            this.uiNút_Hủy.UseVisualStyleBackColor = true;
            // 
            // uiNút_Lưu
            // 
            this.uiNút_Lưu.Location = new System.Drawing.Point(392, 571);
            this.uiNút_Lưu.Name = "uiNút_Lưu";
            this.uiNút_Lưu.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Lưu.TabIndex = 100;
            this.uiNút_Lưu.Text = "Lưu";
            this.uiNút_Lưu.UseVisualStyleBackColor = true;
            // 
            // uiNút_Duyệt_Ảnh
            // 
            this.uiNút_Duyệt_Ảnh.Location = new System.Drawing.Point(83, 558);
            this.uiNút_Duyệt_Ảnh.Name = "uiNút_Duyệt_Ảnh";
            this.uiNút_Duyệt_Ảnh.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Duyệt_Ảnh.TabIndex = 99;
            this.uiNút_Duyệt_Ảnh.Text = "Duyệt Ảnh";
            this.uiNút_Duyệt_Ảnh.UseVisualStyleBackColor = true;
            // 
            // uiGiới_Tính
            // 
            this.uiGiới_Tính.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhânViênBindingSource, "Giới_Tính_text", true));
            this.uiGiới_Tính.FormattingEnabled = true;
            this.uiGiới_Tính.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.uiGiới_Tính.Location = new System.Drawing.Point(346, 515);
            this.uiGiới_Tính.Name = "uiGiới_Tính";
            this.uiGiới_Tính.Size = new System.Drawing.Size(139, 21);
            this.uiGiới_Tính.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Nhóm Máu";
            // 
            // uiLương
            // 
            this.uiLương.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhânViênBindingSource, "Lương", true));
            this.uiLương.Location = new System.Drawing.Point(346, 430);
            this.uiLương.Name = "uiLương";
            this.uiLương.Size = new System.Drawing.Size(248, 20);
            this.uiLương.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(216, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Năm Sinh";
            // 
            // uiTên
            // 
            this.uiTên.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhânViênBindingSource, "Tên_Nhân_Viên", true));
            this.uiTên.Location = new System.Drawing.Point(346, 345);
            this.uiTên.Name = "uiTên";
            this.uiTên.Size = new System.Drawing.Size(248, 20);
            this.uiTên.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Tên Nhân Viên";
            // 
            // uiẢnh
            // 
            this.uiẢnh.InitialImage = null;
            this.uiẢnh.Location = new System.Drawing.Point(27, 328);
            this.uiẢnh.Name = "uiẢnh";
            this.uiẢnh.Size = new System.Drawing.Size(156, 208);
            this.uiẢnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiẢnh.TabIndex = 90;
            this.uiẢnh.TabStop = false;
            // 
            // uiNút_Đầu_Tiên
            // 
            this.uiNút_Đầu_Tiên.Location = new System.Drawing.Point(457, 276);
            this.uiNút_Đầu_Tiên.Name = "uiNút_Đầu_Tiên";
            this.uiNút_Đầu_Tiên.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Đầu_Tiên.TabIndex = 89;
            this.uiNút_Đầu_Tiên.Text = "<<";
            this.uiNút_Đầu_Tiên.UseVisualStyleBackColor = true;
            // 
            // uiNút_Trước_Đó
            // 
            this.uiNút_Trước_Đó.Location = new System.Drawing.Point(509, 276);
            this.uiNút_Trước_Đó.Name = "uiNút_Trước_Đó";
            this.uiNút_Trước_Đó.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Trước_Đó.TabIndex = 88;
            this.uiNút_Trước_Đó.Text = "<";
            this.uiNút_Trước_Đó.UseVisualStyleBackColor = true;
            // 
            // uiNút_Sau_Đó
            // 
            this.uiNút_Sau_Đó.Location = new System.Drawing.Point(561, 276);
            this.uiNút_Sau_Đó.Name = "uiNút_Sau_Đó";
            this.uiNút_Sau_Đó.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Sau_Đó.TabIndex = 87;
            this.uiNút_Sau_Đó.Text = ">";
            this.uiNút_Sau_Đó.UseVisualStyleBackColor = true;
            // 
            // uiNút_Cuối_Cùng
            // 
            this.uiNút_Cuối_Cùng.Location = new System.Drawing.Point(613, 276);
            this.uiNút_Cuối_Cùng.Name = "uiNút_Cuối_Cùng";
            this.uiNút_Cuối_Cùng.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Cuối_Cùng.TabIndex = 86;
            this.uiNút_Cuối_Cùng.Text = ">>";
            this.uiNút_Cuối_Cùng.UseVisualStyleBackColor = true;
            // 
            // uiNút_Xóa
            // 
            this.uiNút_Xóa.Location = new System.Drawing.Point(189, 286);
            this.uiNút_Xóa.Name = "uiNút_Xóa";
            this.uiNút_Xóa.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Xóa.TabIndex = 85;
            this.uiNút_Xóa.Text = "Xóa";
            this.uiNút_Xóa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Sửa
            // 
            this.uiNút_Sửa.Location = new System.Drawing.Point(108, 286);
            this.uiNút_Sửa.Name = "uiNút_Sửa";
            this.uiNút_Sửa.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Sửa.TabIndex = 84;
            this.uiNút_Sửa.Text = "Sửa";
            this.uiNút_Sửa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Thêm
            // 
            this.uiNút_Thêm.Location = new System.Drawing.Point(27, 286);
            this.uiNút_Thêm.Name = "uiNút_Thêm";
            this.uiNút_Thêm.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Thêm.TabIndex = 83;
            this.uiNút_Thêm.Text = "Thêm Mới";
            this.uiNút_Thêm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Phần Mềm Quản Lý Nhân Viên";
            // 
            // uiBảng
            // 
            this.uiBảng.AutoGenerateColumns = false;
            this.uiBảng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiBảng.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãNhânViênDataGridViewTextBoxColumn,
            this.tênNhânViênDataGridViewTextBoxColumn,
            this.nămSinhDataGridViewTextBoxColumn,
            this.lươngDataGridViewTextBoxColumn,
            this.nhómMáuDataGridViewTextBoxColumn,
            this.giớiTínhDataGridViewCheckBoxColumn,
            this.Giới_Tính_text,
            this.ảnhDataGridViewTextBoxColumn});
            this.uiBảng.DataSource = this.nhânViênBindingSource;
            this.uiBảng.Location = new System.Drawing.Point(27, 49);
            this.uiBảng.Name = "uiBảng";
            this.uiBảng.Size = new System.Drawing.Size(700, 221);
            this.uiBảng.TabIndex = 81;
            // 
            // nhânViênBindingSource
            // 
            this.nhânViênBindingSource.DataMember = "Nhân_Viên";
            this.nhânViênBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhân_ViênTableAdapter
            // 
            this.nhân_ViênTableAdapter.ClearBeforeFill = true;
            // 
            // mãNhânViênDataGridViewTextBoxColumn
            // 
            this.mãNhânViênDataGridViewTextBoxColumn.DataPropertyName = "Mã_Nhân_Viên";
            this.mãNhânViênDataGridViewTextBoxColumn.HeaderText = "Mã_Nhân_Viên";
            this.mãNhânViênDataGridViewTextBoxColumn.Name = "mãNhânViênDataGridViewTextBoxColumn";
            this.mãNhânViênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênNhânViênDataGridViewTextBoxColumn
            // 
            this.tênNhânViênDataGridViewTextBoxColumn.DataPropertyName = "Tên_Nhân_Viên";
            this.tênNhânViênDataGridViewTextBoxColumn.HeaderText = "Tên_Nhân_Viên";
            this.tênNhânViênDataGridViewTextBoxColumn.Name = "tênNhânViênDataGridViewTextBoxColumn";
            // 
            // nămSinhDataGridViewTextBoxColumn
            // 
            this.nămSinhDataGridViewTextBoxColumn.DataPropertyName = "Năm_Sinh";
            this.nămSinhDataGridViewTextBoxColumn.HeaderText = "Năm_Sinh";
            this.nămSinhDataGridViewTextBoxColumn.Name = "nămSinhDataGridViewTextBoxColumn";
            // 
            // lươngDataGridViewTextBoxColumn
            // 
            this.lươngDataGridViewTextBoxColumn.DataPropertyName = "Lương";
            this.lươngDataGridViewTextBoxColumn.HeaderText = "Lương ($)";
            this.lươngDataGridViewTextBoxColumn.Name = "lươngDataGridViewTextBoxColumn";
            // 
            // nhómMáuDataGridViewTextBoxColumn
            // 
            this.nhómMáuDataGridViewTextBoxColumn.DataPropertyName = "Nhóm_Máu";
            this.nhómMáuDataGridViewTextBoxColumn.HeaderText = "Nhóm_Máu";
            this.nhómMáuDataGridViewTextBoxColumn.Name = "nhómMáuDataGridViewTextBoxColumn";
            // 
            // giớiTínhDataGridViewCheckBoxColumn
            // 
            this.giớiTínhDataGridViewCheckBoxColumn.DataPropertyName = "Giới_Tính";
            this.giớiTínhDataGridViewCheckBoxColumn.HeaderText = "Giới_Tính";
            this.giớiTínhDataGridViewCheckBoxColumn.Name = "giớiTínhDataGridViewCheckBoxColumn";
            this.giớiTínhDataGridViewCheckBoxColumn.Visible = false;
            // 
            // Giới_Tính_text
            // 
            this.Giới_Tính_text.DataPropertyName = "Giới_Tính_text";
            this.Giới_Tính_text.HeaderText = "Giới Tính";
            this.Giới_Tính_text.Name = "Giới_Tính_text";
            this.Giới_Tính_text.ReadOnly = true;
            // 
            // ảnhDataGridViewTextBoxColumn
            // 
            this.ảnhDataGridViewTextBoxColumn.DataPropertyName = "Ảnh";
            this.ảnhDataGridViewTextBoxColumn.HeaderText = "Ảnh";
            this.ảnhDataGridViewTextBoxColumn.Name = "ảnhDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 611);
            this.Controls.Add(this.uiNhóm_Máu);
            this.Controls.Add(this.uiNăm_Sinh);
            this.Controls.Add(this.uiNút_Hủy);
            this.Controls.Add(this.uiNút_Lưu);
            this.Controls.Add(this.uiNút_Duyệt_Ảnh);
            this.Controls.Add(this.uiGiới_Tính);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiLương);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiTên);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiẢnh);
            this.Controls.Add(this.uiNút_Đầu_Tiên);
            this.Controls.Add(this.uiNút_Trước_Đó);
            this.Controls.Add(this.uiNút_Sau_Đó);
            this.Controls.Add(this.uiNút_Cuối_Cùng);
            this.Controls.Add(this.uiNút_Xóa);
            this.Controls.Add(this.uiNút_Sửa);
            this.Controls.Add(this.uiNút_Thêm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiBảng);
            this.Name = "Form1";
            this.Text = "(C) 2022 Lê Minh Họa. CDBK K13 LTMT1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBảng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhânViênBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiNhóm_Máu;
        private System.Windows.Forms.TextBox uiNăm_Sinh;
        private System.Windows.Forms.Button uiNút_Hủy;
        private System.Windows.Forms.Button uiNút_Lưu;
        private System.Windows.Forms.Button uiNút_Duyệt_Ảnh;
        private System.Windows.Forms.ComboBox uiGiới_Tính;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiLương;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTên;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox uiẢnh;
        private System.Windows.Forms.Button uiNút_Đầu_Tiên;
        private System.Windows.Forms.Button uiNút_Trước_Đó;
        private System.Windows.Forms.Button uiNút_Sau_Đó;
        private System.Windows.Forms.Button uiNút_Cuối_Cùng;
        private System.Windows.Forms.Button uiNút_Xóa;
        private System.Windows.Forms.Button uiNút_Sửa;
        private System.Windows.Forms.Button uiNút_Thêm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiBảng;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource nhânViênBindingSource;
        private DBDataSetTableAdapters.Nhân_ViênTableAdapter nhân_ViênTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãNhânViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênNhânViênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nămSinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lươngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhómMáuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn giớiTínhDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giới_Tính_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn ảnhDataGridViewTextBoxColumn;
    }
}

