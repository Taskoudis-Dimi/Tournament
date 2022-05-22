namespace TrackerLibraryVD.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in Matchup
        /// </summary>
        /// <summary>
        /// Unique ID for the matchup entry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int TeamCompetingId { get; set; }
        public int ParentMatchupId { get; set; }

        //TODO dole sa ili bez id?? TC vs TCI ?
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Previous match from which this team 
        /// came as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
