using NativeWifi;
using SocketServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncSocketServer
{
    public partial class Server : Form
    {
        SynchronizationContext context;
        SocketServerAsync objServer;
        bool IsUDPActive;
        int tcpPort = 9999;
        string mac = "CFD035FE";
        string devicename = "Cielo Wigle";
        public Server()
        {
            InitializeComponent();
            context = SynchronizationContext.Current;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UdpClient udpServer = new UdpClient(11000);
            IsUDPActive = true;

            Thread thrd_UDPServer = new Thread(delegate()
            {

                while (IsUDPActive)
                {
                    var remoteEP = new IPEndPoint(IPAddress.Any, 11000);
                    var data = udpServer.Receive(ref remoteEP); // listen on port 11000
                    LogMessage("receive data from " + remoteEP.ToString() + ":" + Encoding.ASCII.GetString(data));
                    string payload = devicename + "," + mac + "," + GetLocalIPAddress() + "," + tcpPort;
                    string rcvddata = Encoding.ASCII.GetString(data);
                    if (rcvddata.ToLower().Contains("ping cielo"))
                    {
                        udpServer.Send(Encoding.ASCII.GetBytes(payload), payload.Length, remoteEP); // reply back
                        // IsUDPActive = false;
                        objServer = new SocketServerAsync(tcpPort);
                        objServer.OnSocketConnected += objServer_OnSocketConnected;
                        objServer.OnMessageReceived += objServer_OnMessageReceived;
                    }
                }
            });
            thrd_UDPServer.IsBackground = false;
            thrd_UDPServer.Start();


        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                //if (ip.AddressFamily == AddressFamily.InterNetwork)
                if (ip.AddressFamily == AddressFamily.InterNetwork && ip.ToString().Contains("192.168.1."))
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
        void objServer_OnMessageReceived(string Message, Socket RxSocket)
        {
            try
            {
                LogMessage(Message + "[Port:" + RxSocket.RemoteEndPoint.ToString().Split(':')[1] + "]");
                if (Message.Contains("getmac"))
                {
                    RxSocket.Send(Encoding.ASCII.GetBytes(mac));

                }
                else if (Message.Contains("wifisettings"))
                {
                    RxSocket.Send(Encoding.ASCII.GetBytes("ACK"));
                }
                else if (Message.Contains("getwifilist"))
                {
                    RxSocket.Send(Encoding.ASCII.GetBytes(GetWifiList()));
                }
            }
            catch (Exception ex)
            {

                LogMessage(ex.Message);
            }
        }

        void objServer_OnSocketConnected(string Message, Socket RxSocket)
        {
            try
            {
                LogMessage(Message + "[Port:" + RxSocket.RemoteEndPoint.ToString().Split(':')[1] + "]");
            }
            catch (Exception ex)
            {

                LogMessage(ex.Message);
            }
        }
        private void LogMessage(string ErrorMessage)
        {

            txtResponse.Invoke(new Action(() =>
            {

                txtResponse.Text += ErrorMessage;
                txtResponse.Text += Environment.NewLine;

            }));


        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {
            txtResponse.SelectionStart = txtResponse.Text.Length;
            txtResponse.ScrollToCaret();
        }

        private void btnResetLogs_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "";
        }
        int bi1 = int.Parse("EDCBFE", NumberStyles.HexNumber);
        int bi2 = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bi2 += 1;
            int sum = bi1 + bi2;

            LogMessage(" Sum is : " + sum.ToString("x").ToUpper());
        }

        private void btnGetAvailableWifi_Click(object sender, EventArgs e)
        {
            string bac = GetWifiList();

            MessageBox.Show(bac);
        }

        private string GetWifiList()
        {
            string bac = "";
            List<MyWifiInfo> lstMyWifiInfo = new List<MyWifiInfo>();
            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                // Lists all available networks
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    //byte[] macAddr = network.dot11Ssid;

                    //string tMac = "";

                    //for (int i = 0; i < macAddr.Length; i++)
                    //{

                    //    tMac += macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();

                    //}

                    bac += "Found network with SSID {0}." + GetStringForSSID(network.dot11Ssid) + "[Signal Quality :" + network.wlanSignalQuality + "]" + Environment.NewLine;
                    lstMyWifiInfo.Add(new MyWifiInfo(GetStringForSSID(network.dot11Ssid), (int)network.wlanSignalQuality, Enum.GetName(typeof(NativeWifi.Wlan.Dot11BssType), network.dot11BssType), network.profileName));

                    //  network.dot11DefaultAuthAlgorithm
                }
            }
            bac = "";
            var DistinctItems = lstMyWifiInfo.GroupBy(x => x.Name).Select(y => y.First());

            DistinctItems.OrderByDescending(c => c.SignalStrength).ToList().ForEach(f => { bac += f.SignalStrength + "," + f.Name + ",0,0" + Environment.NewLine; });
            return bac;
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }

    }

    public class MyWifiInfo
    {
        public string Name { get; set; }
        public int SignalStrength { get; set; }
        public string BSSType { get; set; }
        public string MAC { get; set; }
        public MyWifiInfo(string name, int strength, string bsstype, string mac)
        {
            Name = name;
            SignalStrength = strength;
            BSSType = bsstype;
            MAC = mac;
        }
    }
}
