using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Messi
{
    public class Xarxes
    {
        public String GetHostname()
        {
            String hostName = Dns.GetHostName();
            return hostName;
        }

        public String GetMac()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up && (!nic.Description.Contains("Virtual") && !nic.Description.Contains("Pseudo")))
                {
                    if (nic.GetPhysicalAddress().ToString() != "")
                    {
                        macAddresses = nic.GetPhysicalAddress().ToString();
                    }
                }
            }
            return macAddresses;
        }
    }
}
