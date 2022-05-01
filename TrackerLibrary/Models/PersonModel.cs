using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    { /// <summary>
      /// Unique ID for the Person
      /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Team member First Name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Team member last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Team member email
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Team member Phone no
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName {
            get {
                return $"{FirstName } {LastName}";
            }
        }
    }
}
