using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.BACnet;

namespace BACnet_Test
{
    public partial class Form1 : Form
    {
        private BacnetService bacnet_service;
        public Form1()
        {
            InitializeComponent();
            bacnet_service = new BacnetService(new BacnetIpUdpProtocolTransport(0xBABB, false, false, 1472, "192.168.0.65"));
            bacnet_service.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bacnet_service.SendWhois();
            //Console.WriteLine(bacnet_service);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bacnet_service.SendWhois();
        }
    }
}
