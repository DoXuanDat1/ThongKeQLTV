using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLThuVien 
{
    public partial class frmThongKe : Form
    {
        private string connectionString = @"Data Source=(local);Initial Catalog=QLTV;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            LoadTongQuanStats();
            PopulateComboBox();
        }

        private void LoadTongQuanStats()
        {
            try
            {
                lblTongSoSach.Text = $"Tổng số sách: {GetScalarValue("SELECT COUNT(*) FROM Sach")}";
                lblDangMuon.Text = $"Đang mượn: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE ChoMuon = 1")}";
                lblCoSan.Text = $"Có sẵn: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE ChoMuon = 0 AND MaTinhTrang = 1")}";
                lblBiHong.Text = $"Hỏng/Mất: {GetScalarValue("SELECT COUNT(*) FROM Sach WHERE MaTinhTrang IN (2, 3, 4)")}";
                lblSoDocGia.Text = $"Số đọc giả: {GetScalarValue("SELECT COUNT(*) FROM SinhVien")}";
                lblSoTacGia.Text = $"Số tác giả: {GetScalarValue("SELECT COUNT(*) FROM TacGia")}";
                lblSoNXB.Text = $"Số NXB: {GetScalarValue("SELECT COUNT(*) FROM NhaXuatBan")}";
                lblMuonTrongNgay.Text = $"Mượn hôm nay: {GetScalarValue("SELECT COUNT(*) FROM PhieuMuon WHERE CONVERT(date, NgayMuon) = CONVERT(date, GETDATE())")}";
                lblTraTrongNgay.Text = $"Trả hôm nay: {GetScalarValue("SELECT COUNT(*) FROM PhieuTra WHERE CONVERT(date, NgayTra) = CONVERT(date, GETDATE())")}";

                string queryMuonTuan = "SELECT COUNT(*) FROM PhieuMuon WHERE DATEPART(week, NgayMuon) = DATEPART(week, GETDATE()) AND YEAR(NgayMuon) = YEAR(GETDATE())";
                lblMuonTrongTuan.Text = $"Mượn tuần này: {GetScalarValue(queryMuonTuan)}";

                string queryTraTuan = "SELECT COUNT(*) FROM PhieuTra WHERE DATEPART(week, NgayTra) = DATEPART(week, GETDATE()) AND YEAR(NgayTra) = YEAR(GETDATE())";
                lblTraTrongTuan.Text = $"Trả tuần này: {GetScalarValue(queryTraTuan)}";

                string queryQuaHan = @"
                    SELECT COUNT(*) 
                    FROM PhieuMuon
                    WHERE 
                        HanTra < GETDATE() 
                        AND MaPhieuMuon NOT IN (SELECT MaPhieuMuon FROM PhieuTra WHERE MaPhieuMuon IS NOT NULL)";
                lblSachQuaHan.Text = $"Phiếu quá hạn: {GetScalarValue(queryQuaHan)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê tổng quan: " + ex.Message);
            }
        }

        private void PopulateComboBox()
        {
            cboLoaiBaoCao.Items.Add("Thống kê sách theo Thể loại");
            cboLoaiBaoCao.Items.Add("Thống kê sách theo Tình trạng");
            cboLoaiBaoCao.Items.Add("Thống kê sách theo Nhà Xuất Bản");
            cboLoaiBaoCao.Items.Add("Top 10 sách được mượn nhiều nhất");
            cboLoaiBaoCao.Items.Add("Danh sách sách đang mượn");
            cboLoaiBaoCao.SelectedIndex = 0;
        }

        private int GetScalarValue(string query)
        {
            int value = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            value = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lỗi GetScalarValue: " + ex.Message);
                    }
                }
            }
            return value;
        }

        private void LoadDataToGrid(string query)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvBaoCao.DataSource = dataTable;
                        dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu báo cáo: " + ex.Message);
            }
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string selectedReport = cboLoaiBaoCao.SelectedItem.ToString();
            string query = "";

            switch (selectedReport)
            {
                case "Thống kê sách theo Thể loại":
                    query = @"
                        SELECT 
                            T.TenTheLoai AS N'Tên Thể Loại', 
                            S.TenSach AS N'Tên Sách'
                        FROM Sach S
                        JOIN TheLoai T ON S.MaTheLoai = T.MaTheLoai
                        ORDER BY T.TenTheLoai, S.TenSach;";
                    break;

                case "Thống kê sách theo Tình trạng":
                    query = @"
                        SELECT 
                            TT.TenTinhTrang AS N'Tên Tình Trạng', 
                            S.TenSach AS N'Tên Sách'
                        FROM Sach S
                        JOIN TinhTrang TT ON S.MaTinhTrang = TT.MaTinhTrang
                        ORDER BY TT.TenTinhTrang, S.TenSach;";
                    break;

                case "Thống kê sách theo Nhà Xuất Bản":
                    query = @"
                        SELECT 
                            NXB.TenNhaXB AS N'Tên Nhà Xuất Bản', 
                            S.TenSach AS N'Tên Sách'
                        FROM Sach S
                        JOIN NhaXuatBan NXB ON S.MaNhaXB = NXB.MaNhaXB
                        ORDER BY NXB.TenNhaXB, S.TenSach;";
                    break;

                case "Top 10 sách được mượn nhiều nhất":
                    query = @"
                        SELECT TOP 10
                            S.TenSach AS N'Tên Sách', 
                            COUNT(CTPM.MaSach) AS N'Số Lần Mượn'
                        FROM ChiTietPhieuMuon CTPM
                        JOIN Sach S ON CTPM.MaSach = S.MaSach
                        GROUP BY S.TenSach
                        ORDER BY N'Số Lần Mượn' DESC;";
                    break;

                case "Danh sách sách đang mượn":
                    query = @"
                        SELECT
                            PM.MaSV AS N'Mã Độc Giả',
                            S.TenSach AS N'Tên Sách',
                            PM.NgayMuon AS N'Ngày Mượn',
                            PM.HanTra AS N'Hạn Trả'
                        FROM PhieuMuon AS PM
                        JOIN ChiTietPhieuMuon AS CTPM ON PM.MaPhieuMuon = CTPM.MaPhieuMuon
                        JOIN Sach AS S ON CTPM.MaSach = S.MaSach
                        WHERE
                            PM.MaPhieuMuon NOT IN (SELECT MaPhieuMuon FROM PhieuTra WHERE MaPhieuMuon IS NOT NULL)
                        ORDER BY
                            PM.HanTra ASC;";
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                LoadDataToGrid(query);
            }
        }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}