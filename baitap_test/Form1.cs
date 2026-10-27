using baitap_test.Model;
using baitap_test.Model.EF;
using baitap_test.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using FastReport;

using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;




namespace baitap_test
{
    public partial class Form1 : Form
    {


        // Khóa chính MaHang là int
        private int? maDangChon = null;

        // Biến kiểm tra đang xử lý
        private bool dangXuLy = false;

        // 1. TRẠNG THÁI BAN ĐẦU
        private void TrangThaiBanDau()
        {
            maDangChon = null;


            textBox1.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

            dateTimePicker1.Value = DateTime.Today;
            checkBox1.Checked = false;

            textBox3.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;

            dataGridView1.ClearSelection();
        }

        // 2. TRẠNG THÁI ĐÃ CHỌN
        private void TrangThaiDaChon()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            textBox3.Enabled = false;
        }

        // 3. KHÓA NÚT KHI ĐANG XỬ LÝ
        private void KhoaNut()
        {
            dangXuLy = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        private void MoKhoaNut()
        {
            dangXuLy = false;
            dataGridView1.Enabled = true;
            if (maDangChon == null)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                TrangThaiDaChon();
            }
        }
        private bool KiemTraDuLieu()
        {
            // 🔴 THAY ô mã, tên và các thông báo theo đề.

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Không được để trống tên hang!");
                textBox1.Focus();
                return false;
            }

            // 🟡 TÙY ĐỀ: tuổi/số lượng kiểu int.
            if (!decimal.TryParse(numericUpDown1.Text, out decimal GiaBan) || GiaBan <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!");
                numericUpDown1.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn đơn vị!");
                comboBox2.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn loại hàng");
                comboBox1.Focus();
                return false;
            }


            // 🟡 TÙY ĐỀ: Nếu đề có số lượng int, thêm đoạn:
            if (!int.TryParse(numericUpDown2.Text, out int SoLuong) || SoLuong < 0)
            {
                MessageBox.Show("Số lượng phải >= 0!");
                numericUpDown2.Focus();
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.Columns.Clear();

            this.Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            await LoadDuLieuAsync();
        }

        private async Task LoadDuLieuAsync()
        {
            try
            {
                // Tạo cấu hình kết nối


                using var db = new AppDbContext();

                // Truy vấn dữ liệu
                var danhSach = await db.HangHoas
                    .AsNoTracking()
                    .ToListAsync();

                // Đưa dữ liệu lên DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = danhSach;

                // Tự giãn cột
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                MessageBox.Show(
                    $"Đã tải {danhSach.Count} dòng dữ liệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi: " + ex.Message);
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (dangXuLy) return;
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }
            var kq = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;
            KhoaNut();
            try
            {
                using var db = new AppDbContext(); // THAY nếu khác
                var sv = await db.HangHoas.FindAsync(maDangChon); //  THAY DbSet
                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!");
                    maDangChon = null;
                    await LoadDuLieuAsync();
                    return;
                }
                db.HangHoas.Remove(sv); //  THAY DbSet
                await db.SaveChangesAsync();
                MessageBox.Show("Xóa thành công!");
                await LoadDuLieuAsync();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                // 🟡 TÙY ĐỀ: có thể lỗi ràng buộc khóa ngoại khi xóa.
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
            finally
            {
                MoKhoaNut();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // ✅ GIỮ NGUYÊN: Không cho chọn khi đang xử lý
            if (dangXuLy) return;

            // ✅ GIỮ NGUYÊN: Bỏ qua dòng tiêu đề
            if (e.RowIndex < 0) return;

            // ✅ GIỮ NGUYÊN: Lấy dòng đang chọn
            DataGridViewRow row =
                dataGridView1.Rows[e.RowIndex];

            // ✅ GIỮ NGUYÊN: Bỏ qua dòng trống
            if (row.IsNewRow) return;



            maDangChon = Convert.ToInt32(
                row.Cells["MaHang"].Value
            );



            textBox3.Text =
                row.Cells["MaHang"].Value?.ToString() ?? "";

            textBox1.Text =
                row.Cells["TenHang"].Value?.ToString() ?? "";


            comboBox1.Text =
                row.Cells["LoaiHang"].Value?.ToString() ?? "";

            comboBox2.Text =
                row.Cells["DonVi"].Value?.ToString() ?? "";



            numericUpDown1.Value =
                Convert.ToDecimal(row.Cells["GiaBan"].Value);

            numericUpDown2.Value =
                Convert.ToDecimal(row.Cells["SoLuongTon"].Value);


            dateTimePicker1.Value =
                Convert.ToDateTime(row.Cells["NgayNhap"].Value);



            checkBox1.Checked =
                Convert.ToBoolean(row.Cells["ConKinhDoanh"].Value);

            TrangThaiDaChon();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dangXuLy) return;
            if (!KiemTraDuLieu()) return;
            KhoaNut();
            try
            {
                using var db = new AppDbContext(); // 🔴 THAY nếu DbContext khác



                // 🔴 THAY Entity và tất cả thuộc tính theo đề.
                var hh = new HangHoa
                {
                    TenHang = textBox1.Text.Trim(),

                    DonVi = comboBox2.Text.Trim(),


                    // ComboBox kiểu string
                    LoaiHang = comboBox1.Text,

                    // NumericUpDown kiểu int
                    SoLuongTon = (int)numericUpDown2
                    .Value,

                    // NumericUpDown kiểu decimal
                    GiaBan = (decimal)numericUpDown1
                    .Value,

                    // DateTimePicker
                    NgayNhap = dateTimePicker1.Value,

                    // CheckBox
                    ConKinhDoanh = checkBox1.Checked,

                };
                db.HangHoas.Add(hh); // 🔴 THAY DbSet
                await db.SaveChangesAsync();
                MessageBox.Show("Thêm thành công!");
                await LoadDuLieuAsync();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "LỖI THÊM HÀNG HÓA:\n\n" +
                    ex.ToString(),
                    "CHI TIẾT LỖI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                MoKhoaNut();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dangXuLy) return;
            if (maDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            if (!KiemTraDuLieu()) return;
            KhoaNut();
            try
            {
                using var db = new AppDbContext(); // 🔴 THAY nếu khác
                var sv = await db.HangHoas.FindAsync(maDangChon); // 🔴 THAY DbSet
                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu!");
                    maDangChon = null;
                    await LoadDuLieuAsync();
                    return;
                }
                // 🔴 THAY các thuộc tính được phép sửa; không sửa khóa chính.
                sv.TenHang = textBox1.Text.Trim();
                sv.DonVi = comboBox2.Text.Trim();
                sv.LoaiHang = comboBox1.Text;
                sv.SoLuongTon = (int)numericUpDown2.Value;
                sv.GiaBan = (decimal)numericUpDown1.Value;
                sv.NgayNhap = dateTimePicker1.Value;
                sv.ConKinhDoanh = checkBox1.Checked;
                await db.SaveChangesAsync();
                MessageBox.Show("Sửa thành công!");
                await LoadDuLieuAsync();
                TrangThaiBanDau();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally
            {
                MoKhoaNut();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ==================== H. LÀM MỚI ====================

            if (dangXuLy) return;
            TrangThaiBanDau();


        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = LayDuLieuBaoCao();

            ReportHelper.XuatPDF(dt, "baocaochitieu");
        }

        private DataTable LayDuLieuBaoCao()
        {
            DataTable dt = new DataTable("DuLieu");

            using var _ = dt.Columns.Add("NgayNhap", typeof(DateTime));
            dt.Columns.Add("TenHang", typeof(string));
            dt.Columns.Add("LoaiHang", typeof(string));
            dt.Columns.Add("GiaBan", typeof(decimal));
            dt.Columns.Add("DonVi", typeof(string));
            dt.Columns.Add("SoLuongTon",typeof(int));
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;


                object? giaTriNgay = row.Cells["NgayNhap"].Value;

                DateTime ngayNhap;

                if (giaTriNgay is DateOnly ngay)
                {
                    ngayNhap = ngay.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    ngayNhap = Convert.ToDateTime(giaTriNgay);
                }


                decimal soTien = Convert.ToDecimal(
                    row.Cells["GiaBan"].Value ?? 0
                );
                int soLuongTon = Convert.ToInt32(
                row.Cells["SoLuongTon"].Value ?? 0
                 );

                dt.Rows.Add(
                    ngayNhap,
                    row.Cells["TenHang"].Value?.ToString() ?? "",
                    row.Cells["LoaiHang"].Value?.ToString() ?? "",
                    soTien,
                    row.Cells["DonVi"].Value?.ToString() ?? "",
                     soLuongTon
                );
            }

            return dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt = LayDuLieuBaoCao();
            ReportHelper.ThietKe(dt, "baocaochitieu");
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
