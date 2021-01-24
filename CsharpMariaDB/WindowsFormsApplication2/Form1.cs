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


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=192.168.0.135;Database=pmftest;Uid=root;Pwd=Jmctrls4867)(12;");
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO test(A,B) VALUES('" + this.A_box.Text + "','" + this.B_box.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("O");
                }
                else
                {
                    MessageBox.Show("X");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string updatesql = "UPDATE test set A='" +this. A_box.Text + "',B='" + this.B_box.Text + "' WHERE INX='"+this.inx_box.Text+"'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(updatesql, connection);

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("O");
                }
                else
                {
                    MessageBox.Show("X");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string selectsql = "SELECT * FROM test WHERE INX='" + this.inx_box.Text + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(selectsql, connection);
            command.Connection = connection;

            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM test WHERE INX='" + this.inx_box.Text + "'", connection);

            da.Fill(ds);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                
                Debug.WriteLine(string.Format("INDEX : {0} \n A : {1}  \n B : {2}", row["INX"], row["A"], row["B"]));
            }
            connection.Close();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string deletesql = "DELETE FROM test WHERE INX=('" + this.inx_box.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(deletesql, connection);
            

            try//예외 처리
            {
                // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("O");
                }
                else
                {
                    MessageBox.Show("X");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            connection.Close();
        }

        /*private void yoon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("정영윤 기모띠 ^^");
        }*/

        /* private void button1_Click_1(object sender, EventArgs e)
         {
             Console.WriteLine("2123123");
         }*/
    }
}
