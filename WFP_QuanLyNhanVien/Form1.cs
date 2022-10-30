using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP_QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Nhân_Viên' table. You can move, or remove it, as needed.
            this.nhân_ViênTableAdapter.Fill(this.dBDataSet.Nhân_Viên);

        }


        string Thông_Báo { get; set; } // ví dụ: báo lỗi, báo lỗi kiểm duyệt dữ liệu
        string Hành_Động { get; set; } // Thêm, Sửa (cờ đánh dấu cho hàm lưu() )
        Nhân_Viên Dòng { get; set; } // Trỏ tới bản ghi hiện tại đang được bôi đen trên Bảng
        DBEntities DB = new DBEntities(); // Biến này chịu trách nhiệm thao tác, quản lý CSDL cục bộ DB.mdf



        //void enableFormRow(bool on = true)
        void bật_tắt_nút(bool bật = true)
        {
            bool tắt = !bật;

            // Ẩn hiện các nút chức năng
            this.uiNút_Lưu.Enabled = bật;
            this.uiNút_Thêm.Enabled = tắt;
            this.uiNút_Sửa.Enabled = tắt;
            this.uiNút_Xóa.Enabled = tắt;

            // Ẩn hiện các phần tử nhập liệu dòng bản ghi trên Form
            this.uiTên.Enabled = bật;
            this.uiNăm_Sinh.Enabled = bật;
            this.uiLương.Enabled = bật;
            this.uiNhóm_Máu.Enabled = bật;
            this.uiGiới_Tính.Enabled = bật;

        }

        //public void selectRow(int index)
        public void chọn_dòng(int chỉ_số)
        {
            // Bôi đen dòng theo chỉ số của nó
            this.uiBảng.ClearSelection();
            this.uiBảng.Rows[chỉ_số].Selected = true;
            this.uiBảng.CurrentCell = this.uiBảng.Rows[chỉ_số].Cells[0];

            this.uiNút_Sửa.Enabled = true;
            this.uiNút_Xóa.Enabled = true;

            // Lấy ra đối tượng dữ liệu tương ứng với dòng bản ghi trên bảng
            // theo chỉ số của dòng
            this.Dòng = this.DB.Nhân_Viên.ToList().ElementAt(chỉ_số);

            // Lần đầu tiên khi chưa có Ảnh trong DB thì 
            // trường thông tin này trên C# là null
            // @todo: cho cái ảnh rỗng vào
            if (this.Dòng.Ảnh != null)
            {
                //this.uiẢnh.Image = Image.FromFile("images\\"+this.Dòng.Ảnh);
                this.uiẢnh.ImageLocation = this.Dòng.Ảnh;
            }

            this.bật_tắt_nút(false);
        }

        // Ngay sau khi Form1 hiện lên thì làm gì ?
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Tùy chỉnh thuộc tính Form...
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Tùy Chỉnh Thuộc Tính của bảng dữ liệu (DataGridView)
            // Chế độ chọn: bôi đen toàn dòng
            this.uiBảng.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Ngăn ko cho sửa ô dữ liệu
            this.uiBảng.ReadOnly = true;
            // Ngăn ko cho thêm vào dòng trống ở cuối bảng
            this.uiBảng.AllowUserToAddRows = false;
            // Ràng buộc hàm xử lý sự kiện vào bảng dữ liệu 
            this.uiBảng.DoubleClick += Nhấp_Đúp_Chuột_Vào_Bảng;
            this.uiBảng.Click += Nhấp_Chuột_Vào_Bảng;
            this.uiBảng.MouseClick += Nhấp_Chuột_Phải_Vào_Bảng;

            // Ràng buộc hàm xử lý sự kiện vào các nút chức năng 
            this.uiNút_Thêm.Click += Nhấn_Nút_Thêm;
            this.uiNút_Sửa.Click += Nhấn_Nút_Sửa;
            this.uiNút_Xóa.Click += Nhấn_Nút_Xóa;
            this.uiNút_Lưu.Click += Nhấn_Nút_Lưu;
            this.uiNút_Hủy.Click += Nhấn_Nút_Hủy;

            // Ràng buộc hàm xử lý sự kiện duyệt ảnh
            this.uiNút_Duyệt_Ảnh.Click += Nhấn_Nút_Duyệt_Ảnh;
            this.uiẢnh.DoubleClick += Nhấp_Đúp_Ảnh;

            // Ràng buộc hàm xử lý sự kiện các nút điều hướng
            this.uiNút_Đầu_Tiên.Click += Nhấn_Nút_Đầu_Tiên;
            this.uiNút_Cuối_Cùng.Click += Nhấn_Nút_Cuối_Cùng;
            this.uiNút_Trước_Đó.Click += Nhấn_Nút_Trước_Đó;
            this.uiNút_Sau_Đó.Click += Nhấn_Nút_Sau_Đó;

            // @todo: Xuất file XML ???

            // Các ghi chú tiếng Việt cho giao diện sử dụng biểu tượng
            (new ToolTip()).SetToolTip(this.uiNút_Đầu_Tiên, "Đầu Tiên");
            (new ToolTip()).SetToolTip(this.uiNút_Trước_Đó, "Trước Đó");
            (new ToolTip()).SetToolTip(this.uiNút_Sau_Đó, "Sau Đó");
            (new ToolTip()).SetToolTip(this.uiNút_Cuối_Cùng, "Cuối Cùng");

            if (this.uiBảng.Rows.Count > 0)
                // Bôi đen dòng đầu tiên
                this.chọn_dòng(0);
        }

        private void Nhấp_Chuột_Phải_Vào_Bảng(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            // Nếu nhấp chuột phải
            if (e.Button == MouseButtons.Right)
            {
                // ...thì tạo menu ngữ cảnh 
                var cm = new ContextMenu();

                // Lấy chỉ số của dòng để kiểm tra xem cú nhấp chuột phải có rơi trúng dòng nào không
                int chỉ_số_dòng_bị_nhấp_chuột = this.uiBảng.HitTest(e.X, e.Y).RowIndex;

                // Nếu nhấp chuột phải vào đúng dòng
                if (chỉ_số_dòng_bị_nhấp_chuột >= 0)
                {
                    // thì bôi đen dòng đó
                    this.chọn_dòng(chỉ_số_dòng_bị_nhấp_chuột);

                    // Tạo các menu con(Sửa,Xóa) trên Menu ngữ cảnh
                    // Có vẻ như không có thuộc tính Image để thêm biểu tượng cho MenuItem
                    var menuItemEdit = new MenuItem("Sửa");
                    menuItemEdit.Click += Nhấn_Nút_Sửa;
                    cm.MenuItems.Add(menuItemEdit);

                    var menuItemDelete = new MenuItem("Xóa");
                    menuItemDelete.Click += Nhấn_Nút_Xóa;
                    cm.MenuItems.Add(menuItemDelete);
                }
                else // ngược lại, nhấp chuột phải ra ngoài các dòng
                {
                    // thì tạo menu con Thêm Mới
                    var menuItemAdd = new MenuItem("Thêm Mới");
                    menuItemAdd.Click += Nhấn_Nút_Thêm;
                    cm.MenuItems.Add(menuItemAdd);
                }

                // Hiển thị menu ngữ cảnh tại tọa độ nhấp chuột
                cm.Show(this.uiBảng, new Point(e.X, e.Y));

            }
        }

        private void Nhấn_Nút_Sau_Đó(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex + 1);
        }

        private void Nhấn_Nút_Trước_Đó(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex - 1);
        }

        private void Nhấn_Nút_Cuối_Cùng(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(this.uiBảng.Rows.Count - 1);
        }

        private void Nhấn_Nút_Đầu_Tiên(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(0);
        }

        private void Nhấp_Đúp_Ảnh(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.uiNút_Duyệt_Ảnh.PerformClick();
        }

        private void Nhấn_Nút_Duyệt_Ảnh(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // Tạo trình chọn file ảnh
            var ofd = new OpenFileDialog();
            // và cấu hình cho nó
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Title = "Hãy chọn Ảnh";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

            // Copy file ảnh mà người dùng chọn lên thư mục thực thi
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sourceFile = ofd.FileName;
                var newFileName = Guid.NewGuid().ToString();
                var targetFile = System.IO.Path.Combine(Application.StartupPath, "images\\" + newFileName);
                System.Console.Write(targetFile);
                System.IO.File.Copy(sourceFile, targetFile);

                // cập nhạt ảnh trên PictureBox
                //this.uiẢnh.Image = Image.FromFile(targetFile); // ko cần thiết dòng này

                // câu lệnh này thực sự hiện ảnh
                this.uiẢnh.ImageLocation = "images\\" + newFileName;
            }
        }

        private void Nhấn_Nút_Hủy(object sender, EventArgs e)
        {

            //throw new NotImplementedException();


            if (this.uiBảng.RowCount > 0)
            {
                // Đoạn này gây lỗi vì lúc bấm nút Add: 
                // Dòng mới có chỉ số -1 được thêm vào: Out of range
                //this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);

                if (this.Hành_Động == "Thêm")
                {
                    // Gỡ bỏ dòng tạm thời mới thêm vào cuối Bảng dữ liệu
                    // dòng này chưa ăn vào DB cơ sở dữ liệu
                    this.nhânViênBindingSource.RemoveCurrent();

                    // Bôi đen dòng đầu tiên
                    this.chọn_dòng(0);
                }
                else // Hủy việc sửa
                {
                    this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);
                }

                // return; 

            }

            //this.uiNút_Thêm.PerformClick();
        }

        bool kiểm_duyệt_dữ_liệu()
        {
            if (this.uiTên.Text == "")
            {
                this.Thông_Báo = "Tên nhân viên không được trống !";
                this.uiTên.Focus();
                return false;
            }

            //// Không để xảy ra SQLException: Binary truncated
            //if (String.IsNullOrEmpty(this.uiTextBox_RollNumber.Text) || this.uiTextBox_RollNumber.Text.Length > 10)
            //{
            //    this.Msg = "Mã sinh viên không được trống !";
            //    this.uiTextBox_RollNumber.Focus();
            //    return false;
            //}

            //// todo: xác thực email bằng biểu thức chính quy
            //string email_pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            //if (String.IsNullOrEmpty(this.uiTextBox_Email.Text) ||
            //                            !Regex.IsMatch(this.uiTextBox_Email.Text, email_pattern))
            //{
            //    this.Msg = "Email phải hợp lệ !";
            //    return false;
            //}

            // Ép người dùng phải chọn ảnh khác ảnh rỗng empty-profile.png
            if (!System.IO.File.Exists(this.uiẢnh.ImageLocation))
            {
                this.Thông_Báo = "Phải chọn ảnh !";
                return false;
            }

            return true;

        }// kết thúc hàm xác thực tính hợp lệ của dữ liệu Form

        private void Nhấn_Nút_Lưu(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            // Nếu form ko hợp lệ thì ...
            if (this.kiểm_duyệt_dữ_liệu() == false)
            {
                // ...báo lỗi
                MessageBox.Show(this.Thông_Báo, "Dữ Liệu Ko Hợp Lệ!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // và chấm dứt hàm
                return;
            }

            if (this.Hành_Động == "Thêm")
            {

                this.DB.Nhân_Viên.Add(new Nhân_Viên()
                {
                    Tên_Nhân_Viên = this.uiTên.Text,
                    Nhóm_Máu      = this.uiNhóm_Máu.Text,
                    Giới_Tính     = (this.uiGiới_Tính.Text == "Nam") ? true : false,
                    Lương         = Convert.ToDouble(this.uiLương.Text),
                    Năm_Sinh      = Convert.ToInt32(this.uiNăm_Sinh.Text),
                    Ảnh           = this.uiẢnh.ImageLocation
                });

                this.DB.SaveChanges();

                this.Form1_Load(this, null);
                this.chọn_dòng(this.uiBảng.RowCount - 1);

                MessageBox.Show("Đã hoàn tất việc thêm mới !", "Thành Công", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else     // this.Hành_Động == "Sửa"
            {
                this.Dòng.Tên_Nhân_Viên = this.uiTên.Text;
                this.Dòng.Nhóm_Máu = this.uiNhóm_Máu.Text;
                this.Dòng.Giới_Tính = (this.uiGiới_Tính.Text == "Nam") ? true : false;
                this.Dòng.Lương = Convert.ToDouble(this.uiLương.Text);
                this.Dòng.Năm_Sinh = Convert.ToInt32(this.uiNăm_Sinh.Text);
                this.Dòng.Ảnh = this.uiẢnh.ImageLocation;
                // ví dụ: "images\09066d65-862b-4dd9-a95e-e7460534c56d"

                this.DB.Entry(this.Dòng).State = System.Data.Entity.EntityState.Modified;
                this.DB.SaveChanges();

                this.Form1_Load(this, null);
                this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);

                MessageBox.Show("Đã hoàn tất việc sửa !", "Thành Công", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.bật_tắt_nút(false);
        }

        private void Nhấn_Nút_Xóa(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (this.uiBảng.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hãy chọn dòng bản ghi để xóa !", "Xóa Dữ Liệu", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yes_no = MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác Nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (yes_no == DialogResult.Yes)
            {
                this.DB.Entry(this.Dòng).State = System.Data.Entity.EntityState.Deleted;
                this.DB.SaveChanges();

                this.Form1_Load(this, null);

                MessageBox.Show("Đã Hoàn Tất Việc Xóa", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Nhấn_Nút_Sửa(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (this.uiBảng.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hãy chọn dòng bản ghi để sửa !", "Sửa Dữ Liệu", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);
            this.Hành_Động = "Sửa";
            this.bật_tắt_nút();// bật form lên để sửa
        }

        // Ràng buộc Text vào nguồn dữ liệu như sau:
        // Chọn phần tử, ví dụ uiTextBox
        // mở hộp Properties (F4)
        // vào mục (DataBindings), sau đó chọn thuộc tính muốn ràng buộc
        private void Nhấn_Nút_Thêm(object sender, EventArgs e)
        {
            this.nhânViênBindingSource.AddNew();

            this.Hành_Động = "Thêm";
            this.bật_tắt_nút();
        }

        private void Nhấp_Đúp_Chuột_Vào_Bảng(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.uiNút_Sửa.PerformClick();
        }

        private void Nhấp_Chuột_Vào_Bảng(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);
        }
    }// kết thúc Form1
}// kết thúc lớp
