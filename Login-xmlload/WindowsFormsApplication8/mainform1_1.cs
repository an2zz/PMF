using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace WindowsFormsApplication8
{
    public partial class mainform1_1 : Form
    {
        public mainform1_1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Xml 파일(*.xml)|*.xml|모든파일(*.*)|*.*"; //원하는 확장자
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader re = new StreamReader(ofd.FileName);
                searchinput1.Text = string.Format("File Path - <{0}>", ofd.FileName);//파일 경로 출력
                listView1.Items.Add(re.ReadToEnd()); //파일 내용 출력

                DataSet ds = new DataSet();
                ds.ReadXml(re);
                string s = ds.GetXml();
                re.Close();

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
                {

                    /*
                    //dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    string[] sArr = Convert.ToString(ds.Tables[3].Rows[0]["pointno"]).Split();
                    DataTable newDT = new DataTable();
                    for (int iCol = 0; iCol < sArr.Length; iCol++)
                        newDT.Columns.Add("Col" + (iCol + 1).ToString(), typeof(string));
                    newDT.Rows.Add(sArr);

                    dataGridView1.DataSource = newDT.DefaultView;
                    */
            //  }
            //  }  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
