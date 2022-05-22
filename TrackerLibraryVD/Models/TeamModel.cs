using System.Collections.Generic;

namespace TrackerLibraryVD.Models
{
    public class TeamModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Team name
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of Team members
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        
    }
}
