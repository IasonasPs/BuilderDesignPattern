using System.Net;
using System.Net.NetworkInformation;

namespace FunctionalBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1; i++)
            {
                string hostName = "www.google.com"; // Retrive the Name of HOST
                Console.WriteLine(hostName);
                // Get the IP
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                
                Console.WriteLine("My IP Address is :" + myIP); 
                Ping ping = new Ping();

                var y = ping.Send(hostName);
                Console.WriteLine(y);
            }

        }
    }
}