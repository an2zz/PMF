using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace WindowsFormsApplication8
{
    public partial class signup : Form
    {

        MySqlConnection connection =
        new MySqlConnection("Server=192.168.0.135;Database=pmftest;Uid=root;Pwd=Jmctrls4867)(12;allow user variables=true;");
        public signup()
        {
            InitializeComponent();
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/

       private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO ahn(ID,PW,username,email,role)"+ "VALUES(@ID,@PW,@username,@email,@role)";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@ID", ID_box.Text);
            command.Parameters.AddWithValue("@PW", PW_box.Text);
            command.Parameters.AddWithValue("@username", username_box.Text);
            command.Parameters.AddWithValue("@email", email_box.Text);
            command.Parameters.AddWithValue("@role", role_box.Text);
            /*'" + this.ID_box.Text + "','" + this.PW_box.Text + "','" + this.username_box.Text + "','" + this.email_box.Text + "'*/
            try//예외 처리
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("회원등록이 완료되었읍니다.");
                }
                else
                {
                    MessageBox.Show("다시 시도해주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
