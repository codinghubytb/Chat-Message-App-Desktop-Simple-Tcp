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
    public partial class frm_MainPage : Form
    {
        #region Variable

        frm_CreateServer frm_CreateServer;
        frm_JoinServer frm_JoinServer;

        #endregion

        public frm_MainPage()
        {
            InitializeComponent();
            timer1.Start();
        }

        #region Click

        private void btnJoinServer_Click(object sender, EventArgs e)
        {
            frm_JoinServer = new frm_JoinServer();
            frm_JoinServer.ShowDialog();

        }

        private void btnCreateServer_Click(object sender, EventArgs e)
        {
            frm_CreateServer = new frm_CreateServer();
            frm_CreateServer.ShowDialog();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelWelcome.Visible = false;
            timer1.Stop();
        }
    }
}
