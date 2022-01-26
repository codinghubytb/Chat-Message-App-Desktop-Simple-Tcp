using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Chat_TCP_IP.Services
{
    public class ClassClient
    {
        #region Variable

        public SimpleTcpClient client;
        #endregion

        public ClassClient(string IpServeur, string PortServer)
        {
            try
            {
                client = new SimpleTcpClient($"{IpServeur}:{PortServer}");
            }
            catch(Exception e)
            {
                MessageBox.Show($"Erreur lors de la connection au serveur \n{e.Message}");
            }
        }
    }
}
