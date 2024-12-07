using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        private string lite = @"Data Source=C:\Users\lengo\OneDrive\Máy tính\QLCCHS.db;Version=3;";
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 from1 = new Form1();
            from1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 from2 = new Form2();
            from2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridView[] alldata = new DataGridView[5];
            alldata[0] = dgv_KM;
            alldata[1] = dgv_ct;
            alldata[2] = dgv_dgs;
            alldata[3] = dgv_PC;
            alldata[4] = dgv_ht;
            string[] table =
            {
                "KhuyenMai",
                "ChiTietHoaDon",
                "DanhGiaSach",
                "PhieuChuyenKho",
                "HangTonKho"
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
                catch(Exception ex){
                    MessageBox.Show("Failed: "+ex);
                }
                
            }
        }
    }
}
