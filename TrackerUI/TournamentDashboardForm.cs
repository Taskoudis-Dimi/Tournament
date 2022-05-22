using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibraryVD;
using TrackerLibraryVD.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public TournamentDashboardForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTournamentDropDown.DataSource = tournaments;
            selectTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, System.EventArgs e)
        {
            CreateTurnamentForm frm = new CreateTurnamentForm();
            frm.Show();
        }

        private void loadTournamentButton_Click(object sender, System.EventArgs e)
        {
            TournamentModel tm = (TournamentModel)selectTournamentDropDown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
