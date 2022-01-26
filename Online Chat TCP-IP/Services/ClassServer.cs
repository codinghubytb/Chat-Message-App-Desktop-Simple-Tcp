using SimpleTcp;
using System;
using System.Net;
using System.Windows.Forms;
using Online_Chat_TCP_IP.Services;

namespace Online_Chat_TCP_IP.Services
{
    public class ClassServer
    {
        #region Variable

        public string IP;
        private string _PORT;
        public SimpleTcpServer server;
        #endregion

        public ClassServer(string PORT)
        {
            IP = Program.classIP.RecoverLocalIp();
            _PORT = PORT;
        }

        /// <summary>
        /// Create Server
        /// </summary>
        public void CreateServer()
        {
            try
            {
                server = new SimpleTcpServer($"{IP}:{_PORT}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erreur lors de la création du serveur \n{e.Message}");
            }
        }
    }
}
