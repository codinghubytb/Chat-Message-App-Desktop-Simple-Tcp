using Online_Chat_TCP_IP.Services;
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

namespace Online_Chat_TCP_IP
{
    public partial class frm_CreateServer : Form
    {
        #region Variable

        frm_ChatMessageServer frm_ChatMessageServer;
        #endregion

        public frm_CreateServer()
        {
            InitializeComponent();
            txtIp.Text = Program.classIP.RecoverLocalIp();
        }

        #region Click

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            if(txtPort.Text != "")
            {
                frm_ChatMessageServer = new frm_ChatMessageServer(txtPort.Text);
                frm_ChatMessageServer.ShowDialog();
            }
            else
                MessageBox.Show("Please complete all information");
        }
        #endregion
    }
}
