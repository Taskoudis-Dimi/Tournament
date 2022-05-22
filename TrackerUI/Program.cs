using System;
using System.Windows.Forms;
using TrackerLibraryVD;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Initialize db connections
            TrackerLibraryVD.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            Application.Run(new TournamentDashboardForm());
            //Application.Run(new CreateTurnamentForm());
        }
    }
}
