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
    public partial class frm_JoinServer : Form
    {
        #region Variable

        frm_ChatMessageClient frm_ChatMessageClient;
        #endregion

        public frm_JoinServer()
        {
            InitializeComponent();
        }

        #region Click

        private void btnJoinServer_Click(object sender, EventArgs e)
        {
            if (txtPort.Text != "" && txtIp.Text != "")
            {
                frm_ChatMessageClient = new frm_ChatMessageClient(txtIp.Text, txtPort.Text);
                frm_ChatMessageClient.ShowDialog();
            }
            else
                MessageBox.Show("Please complete all information");
        }
        #endregion
    }
}
