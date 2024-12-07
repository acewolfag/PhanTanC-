using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private string lite = @"Data Source=C:\Users\lengo\OneDrive\Máy tính\QLCCHS.db;Version=3;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataGridView[] alldata = new DataGridView[5];
            alldata[0] = dgv_cn;
            alldata[1] = dgv_dh;
            alldata[2] = dgv_kh;
            alldata[3] = dgv_nv;
            alldata[4] = dgv_sach;
            string[] table =
            {
                "ChiNhanh",
                "HoaDon",
                "KhachHang",
                "NhanVien",
                "Sach"
            };

            using (SQLiteConnection conlite = new SQLiteConnection(lite))
            {
                try
                {
                    conlite.Open();
                    for (int i = 0; i < 5; i++)
                    {
                        string query = "SELECT " + table[i] + ".* FROM " + table[i];
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conlite))
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add('"' + table[i] + '"');
                            dataTable.Load(reader);
                            alldata[i].DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed: " + ex);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
