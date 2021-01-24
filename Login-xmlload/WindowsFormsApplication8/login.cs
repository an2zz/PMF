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
    public partial class login : Form
    {
        MySqlConnection connection =
        new MySqlConnection("Server=192.168.0.135;Database=pmftest;Uid=root;Pwd=Jmctrls4867)(12;allow user variables=true;");
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = "  ";
            string pwd = "  ";
            string connStr = "PW=" + pwd + ";ID=" + id + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            connection.Open();
            bool login1 = false;
            bool login0 = false;
            string login_id = ID_box1.Text;
            string login_password = PW_box1.Text;

            string selectQuery = "SELECT * FROM ahn WHERE ID=\'" + login_id + "\'";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            MySqlDataReader mdr = cmd.ExecuteReader();
            while (mdr.Read())
            {
                if (login_id == (string)mdr["ID"] && login_password == (string)mdr["PW"] && (string)mdr["role"] == "1")
                    login1 = true;
                else if (login_id == (string)mdr["ID"] && login_password == (string)mdr["PW"] && (string)mdr["role"] == "0")
                    login0 = true;


            }
            if (login1)
            {
                this.LoginID = this.ID_box1.Text;
                this.DialogResult = DialogResult.OK;

                mainform_1 mainform1 = new mainform_1();
                mainform1.Show();

                
            }
            else if (login0)
            {
                this.LoginID = this.ID_box1.Text;
                this.DialogResult = DialogResult.OK;

                mainform_0 mainform0 = new mainform_0();
                mainform0.Show();
            }
            else
            {
                MessageBox.Show("아이디/암호를 확인해 주세요, ");
            }
            connection.Close();

            /*string selectidsql = "SELECT * FROM ahn WHERE ID='" + this.ID_box1.Text + "' and PW='" + this.PW_box1.Text + "'";
            // string selectpwsql = "SELECT * FROM ahn WHERE PW='" + this.PW_box1.Text + "'";
            connection.Open();
            MySqlCommand commandid = new MySqlCommand(selectidsql, connection);
            //MySqlCommand commandpw = new MySqlCommand(selectpwsql, connection);
            commandid.Connection = connection;
            //commandpw.Connection = connection;

            DataSet ds = new DataSet();

            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ahn WHERE ID= '" + this.ID_box1.Text + "'and PW='" + this.PW_box1.Text + "'", connection);
            
            //MySqlDataAdapter da_pw = new MySqlDataAdapter("SELECT * FROM ahn WHERE PW= '" + this.PW_box1.Text + "'", connection);
            
            da.Fill(ds);


            foreach (DataRow row in ds.Tables[0].Rows)
            {


                if (ds == role)
                {
                    this.Hide();

                    mainform_1 mainform1 = new mainform_1();
                    mainform1.Show();

                }
                else
                {
                    MessageBox.Show("ID와PW를 확인해주세요.");
                }
            }*/
        }
        public string LoginID
        {
            get;
            private set;
        }

    }

      

    }

