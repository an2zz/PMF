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

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\안호영\Documents\Data1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from USERINFO where USERNAME ='" + ID_txt.Text + "' and PASSWORD ='" + PW_txt.Text + "'", con);
            DataTable newtable = new DataTable();
            sda.Fill(newtable);
            if (newtable.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                MainForm mainform1 = new MainForm();
                mainform1.Show();

            }
            else
            {
                MessageBox.Show("ID와PW를 확인해주세요.");
            }
        }
    }
}
