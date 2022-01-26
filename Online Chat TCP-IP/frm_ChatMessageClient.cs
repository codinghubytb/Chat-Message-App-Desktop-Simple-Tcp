using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Chat_TCP_IP.Services;
using SimpleTcp;

namespace Online_Chat_TCP_IP
{
    public partial class frm_ChatMessageClient : Form
    {
        #region Variable

        string ip;
        string port;
        #endregion

        public frm_ChatMessageClient(string IPServer, string PORTServer)
        {
            InitializeComponent();
            ip = IPServer;
            port = PORTServer;
        }

        /// <summary>
        /// Create Client and connect to server
        /// </summary>
        /// <param name="ip">string ip</param>
        /// <param name="port">string port</param>
        private void ActionUser(string ip, string port)
        {
            try
            {
                Program.client = new ClassClient(ip, port);
                Program.client.client.Events.Connected += Events_Connected;
                Program.client.client.Events.Disconnected += Events_Disconnected;
                Program.client.client.Events.DataReceived += Events_DataReceived1;
                Program.client.client.Connect();
                lblTitle.Text = $"Welcome to the server\n{ip} : {port}";
                btnConnexion.Visible = false;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }

        }

        /// <summary>
        /// Data received server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_DataReceived1(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"\n[{ e.IpPort}] : { Encoding.UTF8.GetString(e.Data)} {Environment.NewLine}";
            });
        }

        /// <summary>
        /// Client disconnect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"\nYou are offline {Environment.NewLine}";
            });
        }

        /// <summary>
        /// Client Connected to server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"\nYou are connected {Environment.NewLine}";
            });
        }

        /// <summary>
        /// Button send message to server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSendMessage.Text))
            {
                try
                {
                    Program.client.client.Send(txtSendMessage.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtMessage.Text += $"\n[Me] {txtSendMessage.Text} {Environment.NewLine}";
                txtSendMessage.Text = "";
            }
        }

        /// <summary>
        /// Disconnect client to server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                Program.client.client.Disconnect();
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        /// <summary>
        /// Connect client to server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            ActionUser(ip, port);
        }
    }
}
