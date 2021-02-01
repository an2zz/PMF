using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.BACnet;

namespace BACnet_Test
{
    class BacnetService : BacnetClient
    {
        public BacnetService(IBacnetTransport transport) : base(transport)
        {
        }

        public void SendWhois()
        {
            try
            {
                WhoIs(-1, -1, new BacnetAddress(BacnetAddressTypes.IP, "192.168.0.65"));
            }
            catch
            {
            }
        }
    }
}
