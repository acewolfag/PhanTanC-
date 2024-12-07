using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sqlConnectionString = "Server=115.77.210.104,1433;Database=QLCCHS;User Id=sa;Password=system;";
        private string conlite = @"Data Source=C:\Users\lengo\OneDrive\Máy tính\QLCCHS.db;Version=3;";
        private string lite = @"C:\Users\lengo\OneDrive\Máy tính\QLCCHS.db";

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string CN = "select machinhanh, tenchinhanh from Chinhanh";
                    using (SqlCommand cmd = new SqlCommand(CN, con))
                    {
                        SqlDataReader rdCN = cmd.ExecuteReader();
                        cbx_cn.Items.Add(new ComnboBoxItem { Text = "None", Values = "None" });
                        while (rdCN.Read())
                        {
                            string MCN = rdCN["MaChiNhanh"].ToString();
                            string TCN = rdCN["TenChiNhanh"].ToString();
                            cbx_cn.Items.Add(new ComnboBoxItem { Text = MCN + "-" + TCN, Values = MCN });
                        }
                        rdCN.Close();
                        cbx_cn.SelectedIndex = 0;
                    }
                    string NV = "select MaNhanvien, tennhanvien from nhanvien";
                    using (SqlCommand cmd = new SqlCommand(NV, con))
                    {
                        SqlDataReader rdNV = cmd.ExecuteReader();
                        cbx_nv.Items.Add(new ComnboBoxItem { Text = "None", Values = "None" });
                        while (rdNV.Read())
                        {
                            string MNV = rdNV["MaNhanvien"].ToString();
                            string TNV = rdNV["tennhanvien"].ToString();
                            cbx_nv.Items.Add(new ComnboBoxItem { Text = MNV + "-" + TNV, Values = MNV });
                        }
                        rdNV.Close();
                        cbx_nv.SelectedIndex = 0;
                    }
                    string HD = "select mahoadon from hoadon";
                    using (SqlCommand cmd = new SqlCommand(HD, con))
                    {
                        SqlDataReader rdHD = cmd.ExecuteReader();
                        cbx_hd.Items.Add(new ComnboBoxItem { Text = "None", Values = "None" });
                        while (rdHD.Read())
                        {
                            string MHD = rdHD["mahoadon"].ToString();
                            cbx_hd.Items.Add(new ComnboBoxItem { Text = MHD, Values = MHD });
                        }
                        rdHD.Close();
                        cbx_hd.SelectedIndex = 0;
                    }
                    string KH = "select MAKHACHHANG, TENKHACHHANG from khachhang";
                    using (SqlCommand cmd = new SqlCommand(KH, con))
                    {
                        SqlDataReader rdKH = cmd.ExecuteReader();
                        cbx_kh.Items.Add(new ComnboBoxItem { Text = "None", Values = "None" });
                        while (rdKH.Read())
                        {
                            string MCKH = rdKH["MAKHACHHANG"].ToString();
                            string TCKH = rdKH["TENKHACHHANG"].ToString();
                            cbx_kh.Items.Add(new ComnboBoxItem { Text = MCKH + "-" + TCKH, Values = MCKH });
                        }
                        rdKH.Close();
                        cbx_kh.SelectedIndex = 0;
                    }
                    string Sach = "select MASACH, TENSACH from sach";
                    using (SqlCommand cmd = new SqlCommand(Sach, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        cbx_sach.Items.Add(new ComnboBoxItem { Text = "None", Values = "None" });
                        while (reader.Read())
                        {
                            string MSach = reader["MASACH"].ToString();
                            string TSach = reader["TENSACH"].ToString();
                            cbx_sach.Items.Add(new ComnboBoxItem { Text = MSach + "-" + TSach, Values = MSach });
                        }
                        reader.Close();
                        cbx_sach.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class ComnboBoxItem
        {
            public string Text { get; set; }
            public string Values { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string cn = ((ComnboBoxItem)cbx_cn.SelectedItem).Values;
            string nv = ((ComnboBoxItem)cbx_nv.SelectedItem).Values;
            string hd = ((ComnboBoxItem)cbx_hd.SelectedItem).Values;
            string kh = ((ComnboBoxItem)cbx_kh.SelectedItem).Values;
            string sach = ((ComnboBoxItem)cbx_sach.SelectedItem).Values;


            string[] atable = new string[10];
            atable[0] = "KhuyenMai";
            atable[1] = "Sach";
            atable[2] = "DanhGiaSach";
            atable[3] = "ChiTietHoaDon";
            atable[4] = "PhieuChuyenKho";
            atable[5] = "HangTonKho";
            atable[6] = "ChiNhanh";
            atable[7] = "HoaDon";
            atable[8] = "KhachHang";
            atable[9] = "NhanVien";

            string awhere ="select bangreplace.* from sach,"+
                            "HangTonKho,"+
                            "PhieuChuyenKho,"+
                            "KhuyenMai,"+
                            "ChiNhanh,"+
                            "ChiTietHoaDon,"+
                            "NhanVien,HoaDon,"+
                            "KhachHang,"+
                            "DanhGiaSach " +
                            "where " +
                            " Sach.MaSach = HangTonKho.MaSach and " +
                            " Sach.MaSach = PhieuChuyenKho.MaSach and " +
                            " Sach.MaSach = KhuyenMai.MaSach and " +
                            " HangTonKho.MaChiNhanh = ChiNhanh.MaChiNhanh and " +
                            " Sach.MaSach = ChiTietHoaDon.MaSach and " +
                            " ChiNhanh.MaChiNhanh = HoaDon.MaChiNhanh and " +
                            " ChiNhanh.MaChiNhanh = NhanVien.MaChiNhanh and " +
                            " ChiNhanh.MaChiNhanh = HoaDon.MaChiNhanh and " +
                            " HoaDon.MaKhachHang = KhachHang.MaKhachHang and " +
                            " Sach.MaSach = DanhGiaSach.MaSach ";
            if (cn != "None") awhere += "AND ChiNhanh.Machinhanh = '" + cn.Replace("'", "''") + "' ";
            if (nv != "None") awhere += "AND NhanVien.MaNhanVien = '" + nv.Replace("'", "''") + "' ";
            if (hd != "None") awhere += "AND HoaDon.MaHoaDon = '" + hd.Replace("'", "''") + "' ";
            if (kh != "None") awhere += "AND KhachHang.MaKhachHang = '" + kh.Replace("'", "''") + "' ";
            if (sach != "None") awhere += "AND Sach.Masach = '" + sach.Replace("'", "''") + "' ";

            if (awhere.EndsWith("AND "))
            {
                awhere = awhere.Substring(0, awhere.Length - 4);
            }


            using (SqlConnection con = new SqlConnection(sqlConnectionString))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Kết nối thành công SQLServer!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (SQLiteConnection sqliteCon = new SQLiteConnection(conlite))
                    {
                        if (File.Exists(lite))
                            File.Delete(lite);

                        sqliteCon.Open();

                        for (int a = 0; a < atable.Length; a++)
                        {
                            try
                            {
                                string newwhere = awhere.Replace("bangreplace", atable[a]);
                                using (SqlCommand cmd = new SqlCommand(newwhere, con))
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    DataTable dataTable = new DataTable();
                                    dataTable.Load(reader);
                                    string create = GenerateCreateTableQuery(atable[a], dataTable,con);
                                    Console.WriteLine(create);
                                    using (SQLiteCommand createCmd = new SQLiteCommand(create, sqliteCon))
                                    {
                                        createCmd.ExecuteNonQuery();
                                    }
                                    foreach (DataRow row in dataTable.Rows)
                                    {
                                        string insert = GenerateInsertQuery(atable[a], dataTable, row);
                                        Console.WriteLine(insert);
                                        using (SQLiteCommand ins = new SQLiteCommand(insert, sqliteCon))
                                        {
                                            ins.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Da xay ra loi:" + ex);
                            }
                        }


                        MessageBox.Show("Dữ liệu đã được chuyển sang SQLite thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (cn != "None" || nv != "None" || hd != "None" || kh != "None" || sach != "None")
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("không có gì để phân tán");
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connect Failed: " + ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        static string GenerateCreateTableQuery(string tableName, DataTable dataTable, SqlConnection sqlCon)
        {
            string query = $"CREATE TABLE \"{tableName}\" (";

            // Thêm các cột từ DataTable vào câu lệnh CREATE TABLE
            foreach (DataColumn column in dataTable.Columns)
            {
                query += $"\"{column.ColumnName}\" {GetSQLiteDataType(column.DataType)},";
            }

            // Lấy các khóa ngoại từ SQL Server
            string foreignKeyQuery = $@"
    SELECT 
        fk.name AS FK_name,
        tp.name AS Table_name,
        ref_tab.name AS Reference_table,
        c1.name AS Column_name,
        ref_c.name AS Reference_column
    FROM 
        sys.foreign_keys AS fk
    INNER JOIN 
        sys.tables AS tp ON fk.parent_object_id = tp.object_id
    INNER JOIN 
        sys.tables AS ref_tab ON fk.referenced_object_id = ref_tab.object_id
    INNER JOIN 
        sys.foreign_key_columns AS fkc ON fk.object_id = fkc.constraint_object_id
    INNER JOIN 
        sys.columns AS c1 ON fkc.parent_column_id = c1.column_id AND c1.object_id = tp.object_id
    INNER JOIN 
        sys.columns AS ref_c ON fkc.referenced_column_id = ref_c.column_id AND ref_c.object_id = ref_tab.object_id
    WHERE tp.name = '{tableName}';";

            List<string> foreignKeys = new List<string>();
            using (SqlCommand fkCmd = new SqlCommand(foreignKeyQuery, sqlCon))
            using (SqlDataReader fkReader = fkCmd.ExecuteReader())
            {
                while (fkReader.Read())
                {
                    string fkClause = $"FOREIGN KEY (\"{fkReader["Column_name"]}\") REFERENCES \"{fkReader["Reference_table"]}\"(\"{fkReader["Reference_column"]}\")";
                    foreignKeys.Add(fkClause);
                }
            }

            // Thêm các khóa ngoại vào câu lệnh CREATE TABLE
            if (foreignKeys.Any())
            {
                query += string.Join(",", foreignKeys) + ",";
            }

            query = query.TrimEnd(',') + ");";
            return query;
        }


        static string GenerateInsertQuery(string tableName, DataTable dataTable, DataRow row)
        {
            string columns = string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => $"\"{c.ColumnName}\""));
            string values = string.Join(",", dataTable.Columns.Cast<DataColumn>().Select(c => $"'{row[c.ColumnName].ToString().Replace("'", "''")}'"));
            return $"INSERT INTO \"{tableName}\" ({columns}) VALUES ({values});";
        }

        static string GetSQLiteDataType(Type type)
        {
            if (type == typeof(int)) return "INTEGER";
            if (type == typeof(long)) return "INTEGER";
            if (type == typeof(double)) return "REAL";
            if (type == typeof(bool)) return "INTEGER";
            if (type == typeof(string)) return "TEXT";
            if (type == typeof(DateTime)) return "TEXT";
            return "TEXT";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
