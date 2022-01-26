using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;
using Online_Chat_TCP_IP.Services;

namespace Online_Chat_TCP_IP
{
    internal static class Program
    {
        #region Variable

        public static ClassServer server { get; set; }
        public static ClassClient client { get; set; }
        public static ClassIP classIP { get; set; } = new ClassIP();
        #endregion

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_MainPage());
        }
    }
}
