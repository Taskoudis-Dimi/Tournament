using System;
using System.Collections.Generic;

namespace TrackerLibraryVD.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// Unique ID for the Tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of this specific Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry Fee for this Tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Teams applied&Paid for this TRNMT
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Prize model for this TRNMT
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Rounds in this TRNMT
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }

    }
}
