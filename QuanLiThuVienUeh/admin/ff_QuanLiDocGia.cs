﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienUeh.admin
{
    public partial class ff_QuanLiDocGia : Form
    {
        //Variables
        #region Variables
        int pageNumber = 1; //Biến thể hiện trang hiện tại
        int numberRecord = 10; //Biến thể hiện số dòng hiển thị
        int totalRecord = 0; //Biến chứa tổng số dòng trong bảng
        int lastPageNumber = 0; //Biến thể hiện trang cuối cùng trong bảng
        List<Button> buttonChangePageList = new List<Button>(); //List chứa các button phân trang
        #endregion

        public ff_QuanLiDocGia()
        {
            InitializeComponent();
            LoadData();
        }

        //Functions
        #region Functions
        private void ResetLabelTextToNull(Label label) //Đặt text của lable về null
        {
            label.Text = null;
        }

        private void SetLabelText(Label label, string text) //Set text cho label
        {
            label.Text = text;
        }

        private void FocusTextBox(TextBox textBox) //Focus vào textBox
        {
            textBox.Focus();
        }

        private void SearchDocGiasByGeneral() //Hàm tìm kiếm nhân viên 1 cách tổng quát
        {
            using (QLTVEntities db = new QLTVEntities())
            {
                var result = db.NguoiDung.Where(c => c.IDNguoiDung.ToString().Contains(textBox_SearchName.Text)
                                                     || c.HoTen.Contains(textBox_SearchName.Text)
                                                     || c.Lop.Contains(textBox_SearchName.Text)
                                                     || c.ChuyenNganh.Contains(textBox_SearchName.Text)
                                                     || c.Email.Contains(textBox_SearchName.Text)
                                                     || c.SoDienThoai.Contains(textBox_SearchName.Text));
                if (result != null)
                {
                    totalRecord = result.Count();
                    lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord);
                    result = result.OrderBy(s => s.IDNguoiDung)
                                 .Skip((pageNumber - 1) * numberRecord)
                                 .Take(numberRecord);
                    dataGridView_ThongTinDocGia.DataSource = result.Select(s => new
                    {
                        s.IDNguoiDung,
                        s.HoTen,
                        s.GioiTinh,
                        s.NgaySinh,
                        s.Lop,
                        s.ChuyenNganh,
                        s.Email,
                        s.SoDienThoai,
                        s.LichSuMuon
                    }).ToList();
                    AdjustRowHeight();
                    AdjustColumnWidth();
                    ChangeHeader();
                }
            }
        }

        private void LoadData() //Hàm để hiển thị dữ liệu
        {
            using (QLTVEntities db = new QLTVEntities())
            {
                totalRecord = db.NhanVien.Count(); //Lấy ra tổng số dòng trong bảng
            }
            lastPageNumber = (int)Math.Ceiling((double)totalRecord / numberRecord); //Công thức tính trang cuối cùng trong bảng
            dataGridView_ThongTinDocGia.DataSource = LoadRecord(pageNumber, numberRecord); //Hiển thị lên dataGridView
            AdjustRowHeight(); //Customize lại height các dòng
            AdjustColumnWidth(); //Customize lại width các cột
            ChangeHeader(); //Thay đổi tiêu đề hiển thị trên dataGridView
            CustomizeColumnLichSuMuon(); //Customize lại cột Lịch sử mượn
        }

        List<object> LoadRecord(int page, int recordNum)
        {
            List<object> result = new List<object>();
            using (QLTVEntities db = new QLTVEntities())
            {
                result = db.NguoiDung.OrderBy(e => e.IDNguoiDung)
                    .Skip((page - 1) * recordNum)
                    .Take(recordNum)
                    .Select(e => new
                    {
                        e.IDNguoiDung,
                        e.HoTen,
                        e.GioiTinh,
                        e.NgaySinh,
                        e.Lop,
                        e.ChuyenNganh,
                        e.Email,
                        e.SoDienThoai,
                        e.LichSuMuon
                    }).ToList<object>();
            }
            return result;
        }

        private void CustomizeColumnLichSuMuon()
        {
            if (dataGridView_ThongTinDocGia.Columns.Count > 0)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.Font = new Font("Segoe UI", 14, FontStyle.Underline);
                style.ForeColor = Color.FromArgb(0, 95, 105);
                dataGridView_ThongTinDocGia.Columns["LichSuMuon"].DefaultCellStyle = style;
            }
        }

        public void AdjustRowHeight() //Hàm customize lại height các dòng
        {
            //Biến thể hiện height của các dòng sao cho bằng nhau
            int desiredHeight = dataGridView_ThongTinDocGia.Height / (dataGridView_ThongTinDocGia.Rows.Count + 1);
            if (dataGridView_ThongTinDocGia.Rows.Count > 0 && dataGridView_ThongTinDocGia.Rows.Count < 10)
            {
                foreach (DataGridViewRow row in dataGridView_ThongTinDocGia.Rows)
                {
                    row.Height = 50;
                }
            }
            else
            {
                // Thiết lập chiều cao cho mỗi dòng
                foreach (DataGridViewRow row in dataGridView_ThongTinDocGia.Rows)
                {
                    row.Height = desiredHeight;
                }
            }
        }

        private void AdjustColumnWidth() //Hàm customize lại width các dòng
        {
            if (dataGridView_ThongTinDocGia.Columns.Count > 0)
            {
                dataGridView_ThongTinDocGia.Columns[0].Width = dataGridView_ThongTinDocGia.Width * 11 / 100;
                dataGridView_ThongTinDocGia.Columns[1].Width = dataGridView_ThongTinDocGia.Width * 16 / 100;
                dataGridView_ThongTinDocGia.Columns[2].Width = dataGridView_ThongTinDocGia.Width * 5 / 100;
                dataGridView_ThongTinDocGia.Columns[3].Width = dataGridView_ThongTinDocGia.Width * 8 / 100;
                dataGridView_ThongTinDocGia.Columns[4].Width = dataGridView_ThongTinDocGia.Width * 8 / 100;
                dataGridView_ThongTinDocGia.Columns[5].Width = dataGridView_ThongTinDocGia.Width * 15 / 100;
                dataGridView_ThongTinDocGia.Columns[6].Width = dataGridView_ThongTinDocGia.Width * 15 / 100;
                dataGridView_ThongTinDocGia.Columns[7].Width = dataGridView_ThongTinDocGia.Width * 10 / 100;
                dataGridView_ThongTinDocGia.Columns[8].Width = dataGridView_ThongTinDocGia.Width * 12 / 100;
            }
        }

        private void ChangeHeader() //Hàm thay đổi tiêu đề hiển thị trên dataGridView
        {
            if (dataGridView_ThongTinDocGia.Columns.Count > 0)
            {
                dataGridView_ThongTinDocGia.Columns[0].HeaderText = "MSSV";
                dataGridView_ThongTinDocGia.Columns[1].HeaderText = "Tên";
                dataGridView_ThongTinDocGia.Columns[2].HeaderText = "GT";
                dataGridView_ThongTinDocGia.Columns[3].HeaderText = "Ngày sinh";
                dataGridView_ThongTinDocGia.Columns[4].HeaderText = "Lớp";
                dataGridView_ThongTinDocGia.Columns[5].HeaderText = "Chuyên ngành";
                dataGridView_ThongTinDocGia.Columns[6].HeaderText = "Email";
                dataGridView_ThongTinDocGia.Columns[7].HeaderText = "SĐT";
                dataGridView_ThongTinDocGia.Columns[8].HeaderText = "Lịch sử mượn";
            }
        }

        private void AddButtonChangePageList()
        {
            buttonChangePageList.Add(button_ChangePage1);
            buttonChangePageList.Add(button_ChangePage2);
            buttonChangePageList.Add(button_ChangePage3);
            buttonChangePageList.Add(button_ReturnFirstPage);
            buttonChangePageList.Add(button_ReturnLastPage);
        }

        //Hàm tạo thứ tự cho các button phân trang căn cứ vào trang hiện tại
        private void CreateOrderForButtonChangePageByPageNumber(int pageNumber)
        {
            button_ChangePage1.Text = (pageNumber - 1).ToString();
            button_ChangePage2.Text = pageNumber.ToString();
            button_ChangePage3.Text = (pageNumber + 1).ToString();
        }

        //Hàm đặt các button phân trang về mặc định: 1 2 3
        private void SetDefaultButtonChangePageText()
        {
            button_ChangePage1.Text = "1";
            button_ChangePage2.Text = "2";
            button_ChangePage3.Text = "3";
        }

        //Hàm tạo thứ tự cho các button phân trang căn cứ vào trang cuối cùng
        private void CreateOrderForButtonChangePageByLastPageNumber(int lastPageNumber)
        {
            button_ChangePage1.Text = (lastPageNumber - 2).ToString();
            button_ChangePage2.Text = (lastPageNumber - 1).ToString();
            button_ChangePage3.Text = lastPageNumber.ToString();
        }

        private void ResetColorButton() //Hàm đặt lại màu của các button phân trang
        {
            AddButtonChangePageList();
            foreach (Button button in buttonChangePageList)
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
            }
        }

        private void HighlightButtonCurrentPage(object obj) //Hàm hightlight button phân trang được truyền vào
        {
            Button sender = obj as Button;
            sender.BackColor = Color.FromArgb(0, 95, 105);
            sender.ForeColor = Color.White;
        }
        #endregion

        //Events
        #region Events
        private void FormThongTinNhanVien_Resize(object sender, EventArgs e)
        {
            AdjustRowHeight();
            AdjustColumnWidth();
        }

        private void dataGridView_ThongTinDocGia_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_ThongTinDocGia.Columns["LichSuMuon"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView_ThongTinDocGia.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Font = new Font("Segoe UI", 14, FontStyle.Bold | FontStyle.Underline);
                cell.Style.ForeColor = Color.FromArgb(0, 125, 135); // Đổi màu chữ tùy chọn
            }
        }

        private void dataGridView_ThongTinDocGia_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_ThongTinDocGia.Columns["LichSuMuon"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView_ThongTinDocGia.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Style.Font = new Font("Segoe UI", 14, FontStyle.Underline);
                cell.Style.ForeColor = Color.FromArgb(0, 95, 105); // Trở lại màu chữ mặc định
            }
        }

        private void textBox_SearchName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SearchName.Text.Length != 0)
            {
                ResetLabelTextToNull(label_SearchName);//Nếu text trong ô textBox được nhập thì xóa label Search
                pageNumber = 1;
                SetDefaultButtonChangePageText();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage1);
                SearchDocGiasByGeneral();
            }
            else
            {
                SetLabelText(label_SearchName, "Search by id, name, email..."); //Nếu text rỗng thì hiện lại label Search
                pageNumber = 1;
                SetDefaultButtonChangePageText();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage1);
                LoadData();
            }
        }

        private void textBox_SearchName_Click(object sender, EventArgs e)
        {
            if (textBox_SearchName.Text.Length == 0)
                ResetLabelTextToNull(label_SearchName); //TextBox được click thì xóa label Search
        }

        private void label_SearchName_Click(object sender, EventArgs e)
        {
            FocusTextBox(textBox_SearchName); //Nếu click vào label Search thì chuyển Focus vào textBox
            ResetLabelTextToNull(label_SearchName); //Xóa label Search
        }

        private void button_ChangePage1_Click(object sender, EventArgs e)
        {
            pageNumber = Convert.ToInt32(button_ChangePage1.Text);

            if (button_ChangePage1.Text != "1")
            {
                if (textBox_SearchName.Text != null)
                {
                    SearchDocGiasByGeneral();
                    CreateOrderForButtonChangePageByPageNumber(pageNumber);
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                }
                else
                {
                    LoadData();
                    CreateOrderForButtonChangePageByPageNumber(pageNumber);
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                }
            }
            else
            {
                if (textBox_SearchName.Text != null)
                {
                    SearchDocGiasByGeneral();
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage1);
                }
                else
                {
                    LoadData();
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage1);
                }
            }
        }

        private void button_ChangePage2_Click(object sender, EventArgs e)
        {
            if (lastPageNumber == 1) return;
            pageNumber = Convert.ToInt32(button_ChangePage2.Text);
            if (textBox_SearchName.Text != null)
            {
                SearchDocGiasByGeneral();
                ResetColorButton();
                HighlightButtonCurrentPage(sender);
            }
            else
            {
                LoadData();
                ResetColorButton();
                HighlightButtonCurrentPage(sender);
            }
        }

        private void button_ChangePage3_Click(object sender, EventArgs e)
        {
            if (lastPageNumber <= 2) return;
            pageNumber = Convert.ToInt32(button_ChangePage3.Text);

            if (lastPageNumber > pageNumber)
            {
                if (textBox_SearchName.Text != null)
                {
                    SearchDocGiasByGeneral();
                    CreateOrderForButtonChangePageByPageNumber(pageNumber);
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                }
                else
                {
                    LoadData();
                    CreateOrderForButtonChangePageByPageNumber(pageNumber);
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                }
            }
            else
            {
                if (textBox_SearchName.Text != null)
                {
                    SearchDocGiasByGeneral();
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage3);
                }
                else
                {
                    LoadData();
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage3);
                }
            }
        }

        private void button_ReturnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            if (textBox_SearchName.Text != null)
            {
                SearchDocGiasByGeneral();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage1);
                SetDefaultButtonChangePageText();
            }
            else
            {
                LoadData();
                ResetColorButton();
                HighlightButtonCurrentPage(button_ChangePage1);
                SetDefaultButtonChangePageText();
            }
        }

        private void button_ReturnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = lastPageNumber;
            if (textBox_SearchName.Text != null)
            {
                SearchDocGiasByGeneral();
                if (pageNumber == 1)
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage1);
                    return;
                }
                else if (pageNumber == 2)
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                    return;
                }
                else
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage3);
                    CreateOrderForButtonChangePageByLastPageNumber(lastPageNumber);
                }
            }
            else
            {
                LoadData();
                if (pageNumber == 1)
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage1);
                    return;
                }
                else if (pageNumber == 2)
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage2);
                    return;
                }
                else
                {
                    ResetColorButton();
                    HighlightButtonCurrentPage(button_ChangePage3);
                    CreateOrderForButtonChangePageByLastPageNumber(lastPageNumber);
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            ffc_ThemXoaDocGia form = new ffc_ThemXoaDocGia();
            form.Show();
        }

        private void dataGridView_ThongTinDocGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView_ThongTinDocGia.Rows[e.RowIndex].Cells["IDNguoiDung"].Value);
            ffc_XemThongTinDocGiaChiTiet formThongTinDocGiaChiTiet = new ffc_XemThongTinDocGiaChiTiet(selectedID, "Staff");
            formThongTinDocGiaChiTiet.Show();
        }

        private void dataGridView_ThongTinDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView_ThongTinDocGia.Columns["LichSuMuon"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị của ô được nhấn
                object value = dataGridView_ThongTinDocGia.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int idNguoiDung = (int)dataGridView_ThongTinDocGia.Rows[e.RowIndex].Cells["IDNguoiDung"].Value;

                // Kiểm tra giá trị không phải null và không phải DBNull
                if (value != null && value != DBNull.Value)
                {
                    using (QLTVEntities db = new QLTVEntities())
                    {
                        var result = db.MuonTraSach.Any(mt => mt.IDNguoiDung == idNguoiDung);

                        // Nếu idnguoidung tồn tại trong bảng muontrasach, thì mở form mới
                        if (result)
                        {
                            // Hiển thị form mới khi người dùng nhấn vào nội dung ô
                            ffc_XemLichSuMuonTraDocGia form = new ffc_XemLichSuMuonTraDocGia(idNguoiDung);
                            form.ShowDialog(); // Hoặc sử dụng form.Show() nếu bạn muốn form không block main form
                        }
                        else
                        {
                            // Hiển thị thông báo cho người dùng rằng không có lịch sử mượn
                            MessageBox.Show("Không có lịch sử mượn cho người dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        #endregion
    }
}