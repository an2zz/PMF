using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication8
{
    public partial class mainform_1 : Form
    {
        public mainform_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signup signup1 = new signup();
            signup1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("pcsmap.xml");
            XmlNodeList xnList = doc.SelectNodes("/oci_pcsmap/pcs_o/map");

            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;

                using (XmlReader reader = XmlReader.Create("pcsmap.xml", settings))
                    while (reader.Read())
                    {
                        if (reader.IsStartElement("map"))
                        {
                            int attr_cnt = reader.AttributeCount;
                            for (int i = 0; i < attr_cnt; i++)
                            {
                                if (reader[0] == searchinput.Text)
                                {
                                    Debug.WriteLine(reader[i]);
                                    searchresult.Items.Add(reader[i]);
                                }
                            }
                        }
                        
               
                    }
            }catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*
            try
            {
                XmlDocument xml = new XmlDocument ();
               
                xml.Load("pcsmap.xml");

                XmlNodeList xnList = xml.SelectNodes( "/oci_pcsmap/pcs_o/map" ); //접근할 노드

               
                foreach (XmlNode xn in xnList)
                {

                    string part1 = xn["pointno"].InnerText; 
                    string part2 = xn["name"].InnerText; 
                    string part3 = xn["funccode"].InnerText; 
                    string part4 = xn["dmapid"].InnerText; 
                    string part5 = xn["addressno"].InnerText; 
                    string part6 = xn["eventactive"].InnerText;
                    string part7 = xn["dataswap"].InnerText;
                    string part8 = xn["valuetype"].InnerText;
                    string part9 = xn["length"].InnerText;
                    string part10 = xn["unit"].InnerText;
                    string part11= xn["scale"].InnerText;
                    string part12 = xn["min"].InnerText;
                    string part13 = xn["max"].InnerText;
                    string part14 = xn["description"].InnerText;
                    string part15 = xn["val"].InnerText;
                    string part16 = xn["timestamp"].InnerText;



                    if (part1 == searchinput.Text)
                    {
                        //foreach(XmlNode child in xn.ChildNodes)
                        //{
                        searchresult.Items.Add("xn");

                        // }
                    }

                    //searchresult.Items.Add(part1 + " | " + part2 + " | " + part3 + " | " + part4 + " | " + part5+ " | " + part6+ " | " + part7 + " | "+ part8 + " | "+ part9 + " | "+ part10+ " | "+ part11+ " | " + part12 + " | "+ part13+ " | "+ part14+ " | "+ part15+ " | "+ part16);

                }

            }

            catch (ArgumentException ex)
            {

               MessageBox.Show("XML 문제 발생\r\n" + ex);

            }
            */


            /*
            if (searchinput.Text != null && searchinput.Text.Length >= 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("pcsmap.xml");
                XmlNodeList xnList = doc.SelectNodes("/oci_pcsmap/pcs_o/map");

                foreach(XmlNode xn in xnList)
                {
                    string pointno = xn.Attributes[0].InnerText;
                    if(pointno == searchinput.Text)
                    {
                        //foreach(XmlNode child in xn.ChildNodes)
                        //{
                            searchresult.Items.Add(xn.InnerText);
                       // }
                    }
                }

            }else
            {
                MessageBox.Show("Invalid Input");
                searchinput.Text = string.Empty;
                searchinput.Focus();
            }
            */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchresult.Items.Add("기모띠ㅎ");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainform1_1 mainform1_1_1 = new mainform1_1();
            mainform1_1_1.Show();
        }
    }
}
