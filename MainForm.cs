using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_keypad_server {
    public partial class MainForm : Form {
        public Color crimson = Color.FromArgb(220, 20, 59);
        public Color greenish = Color.FromArgb(236, 189, 22);
        
        public MainForm() {
            #region GETTING_IPS
            string hostName = Dns.GetHostName();
            List<IPAddress> addresses = new List<IPAddress>();
            
            try {
                IPAddress[] ipArr = Dns.GetHostAddresses(hostName);
                foreach (var address in ipArr) {
                    if(address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                        addresses.Add(address);
                    }
                }
            }
            catch(Exception) {
                if (addresses.Count == 0)
                    MessageBox.Show("Cannot find any ipv4 local ip address. Code: 100");
                else
                    MessageBox.Show("Unknown error occured. Code: 101");
            }
            #endregion

            InitializeComponent();

            #region INSERTING IPS TO COMBO BOX ADDRESS LIST
            try {
                foreach (var address in addresses) {
                    comboBoxIpAddress.Items.Add(address.ToString());
                }
            }catch(Exception) {
                MessageBox.Show("Cannot find or add ips to IP address list. Code: 102");
            }
            #endregion

        }

  

        #region KEY MAPPING MANAGEMENT
        public static Keys keyA, keyB;
        private void textBoxKeyA_KeyDown(object sender, KeyEventArgs e) {
            textBoxKeyA.Text = " : "+e.KeyCode.ToString();
            keyA = e.KeyCode;
        }

        
        private void textBoxKeyB_KeyDown(object sender, KeyEventArgs e) {
            textBoxKeyB.Text = " : " + e.KeyCode.ToString();
            keyB = e.KeyCode;
        }
        #endregion

        #region GUI INTERACTION
        
        private void buttonStartServer_Click(object sender, EventArgs e) {
            if(Server.GetInstance().isRunning()) {
                Server.GetInstance().Dispose();
                this.Text = "osu!keypad-server";
                buttonStartServer.Text = "Start server";
                buttonStartServer.BackColor = crimson;
                
            }
            else {
                IPAddress finalHostIp = null;

                try {
                    finalHostIp = IPAddress.Parse(comboBoxIpAddress.Text);
                }
                catch (Exception) {
                    MessageBox.Show("Cannot parse IPv4, check if you entered it properly. Code: 202");
                }



                if (finalHostIp != null) {
                    Server.GetInstance().Start(finalHostIp);
                    this.Text = "► osu!keypad-server";
                    buttonStartServer.Text = "Stop server";
                    buttonStartServer.BackColor = greenish;
                    
                }
            }
            System.Threading.Thread.Sleep(100);
        }
        private void buttonLoadConfig_Click(object sender, EventArgs e) {
            var data = Config.GetInstance().LoadConfig();
            comboBoxIpAddress.Text = data.ip;
            keyA = data.a;
            keyB = data.b;
            textBoxKeyA.Text = keyA.ToString();
            textBoxKeyB.Text = keyB.ToString();
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e) {
            Config.GetInstance().SaveConfig(comboBoxIpAddress.Text, keyA, keyB);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/pethrol");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://osu.ppy.sh/users/3054130");
        }

        
        #endregion
    }
}
