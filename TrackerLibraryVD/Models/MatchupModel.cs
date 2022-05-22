using System.Collections.Generic;

namespace TrackerLibraryVD.Models
{
    public class MatchupModel
    {/// <summary>
     /// Matchup list
     /// </summary>
     /// <summary>
     /// Unique ID for the matchup
     /// </summary>
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Team which has won
        /// </summary>

        /// <summary>
        /// Id from DB for identifying winner
        /// </summary>

        public int WinnerId { get; set; }

        public TeamModel Winner { get; set; }
        /// <summary>
        /// IN Which round?
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
