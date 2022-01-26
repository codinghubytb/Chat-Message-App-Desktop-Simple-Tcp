using Online_Chat_TCP_IP.Services;
using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Chat_TCP_IP
{
    public partial class frm_ChatMessageServer : Form
    {
        #region Variable
        List<string> peopleConnected;
        #endregion

        public frm_ChatMessageServer(string PORTServer)
        {
            InitializeComponent();
            peopleConnected = new List<string>();
            messageConnexion(PORTServer);
        }

        /// <param name="port"></param>
        private void messageConnexion(string port)
        {
            ActionUser(port);
        }

        /// <summary>
        /// Create Server and start
        /// </summary>
        /// <param name="port">string port</param>
        private void ActionUser(string port)
        {
            try
            {
                Program.server = new ClassServer(port);
                Program.server.CreateServer();
                Program.server.server.Events.DataReceived += Events_DataReceived;
                Program.server.server.Events.ClientDisconnected += Events_ClientDisconnected;
                Program.server.server.Events.ClientConnected += Events_ClientConnected;
                Program.server.server.Start(); 

                lblTitle.Text = $"Welcome to the server {Program.classIP.RecoverLocalIp()}:{port}";
                txtMessage.Text += $"You have joined the server {DateTime.Now} {Environment.NewLine}";
            }
            catch(Exception e)
            {
                lblTitle.Text = $"Server not create";
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Client Connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"[{e.IpPort}] connected {Environment.NewLine}";
                peopleConnected.Add(e.IpPort);
            });
        }

        /// <summary>
        /// Client Deconnect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"[{e.IpPort}] disconnected {Environment.NewLine}";
                peopleConnected.Remove(e.IpPort);
            });
        }

        /// <summary>
        /// Data received client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtMessage.Text += $"[{ e.IpPort}] : { Encoding.UTF8.GetString(e.Data)} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} {Environment.NewLine}";
            });
        }

        /// <summary>
        /// Button send message to all client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSendMessage.Text))
            {
                foreach(var ip in peopleConnected)
                {
                    try
                    {
                        Program.server.server.Send(ip, txtSendMessage.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                    
                txtMessage.Text += $"[Server] : {txtSendMessage.Text} {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} {Environment.NewLine}";
                txtSendMessage.Text = "";
            }
        }

        /// <summary>
        /// Close server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                Program.server.server.Stop();
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

        /// <summary>
        /// Display people Connected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPeopleConnected_Click(object sender, EventArgs e)
        {
            string peopleCo = "";
            foreach (string people in peopleConnected)
                peopleCo += $"¤ {people}\n";
            MessageBox.Show(peopleCo, "List of people Connected !!");
        }
    }
}
