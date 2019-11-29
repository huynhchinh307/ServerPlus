using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestUiDemo
{
    public partial class ThemThanhVien : Form
    {
        public ThemThanhVien()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Project-Chat\ServerChat\ServerChat\Client.mdf;Integrated Security=True;Connect Timeout=30");
            if (txtUsername.Text != "" && txtPasswd.Text != "")
            {
                conn.Open();
                string sql = "insert into Account values('"+txtUsername.Text+"', '"+txtPasswd.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Trùng ");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đủ trong tin");
            
        }
    }
}
