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
using System.Runtime.InteropServices;
using System.IO;



namespace WindowsFormsApplication8
{
    public partial class mainform_0 : Form

    {
       
     
        [DllImport("kernel32.dll")]
        //private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,int size, string filePath);
        private static extern int GetPrivateProfileString(string filePath);
        public string GetIniValue()
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString("DatabaseInfo.ini");
            return temp.ToString();
            
        }    

        
        MySqlConnection connection =
        new MySqlConnection("Server =192.168.0.135;Database=pmftest;Uid=root;Pwd=Jmctrls4867)(12;");
        public mainform_0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Query = "SELECT * FROM pmftest.ahn";
            MySqlConnection connection = new MySqlConnection("Server=192.168.0.135;Database=pmftest;Uid=root;Pwd=Jmctrls4867)(12;");
            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSouce = new BindingSource();

                bSouce.DataSource = dbdataset;
                dataGridView1.DataSource = bSouce;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            

        }
        


    }
}



