using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace IPAddressFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var Host = Dns.GetHostEntry(Dns.GetHostName());

            var name = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            var SystemName = name.Split('\\');

            foreach (IPAddress ip in Host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("User Name  : "+ SystemName[1]);
                    Console.WriteLine("Host Name  : " + Dns.GetHostEntry(ip).HostName);
                    Console.WriteLine("IP Address : " + ip);
                }
            }

            Console.ReadKey();
        }
    }
}
