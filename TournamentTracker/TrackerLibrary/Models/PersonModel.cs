using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The first name of the person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of the person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email adress of the person.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// The cell phone number of the person.
        /// </summary>
        public string CellphoneNumber { get; set; }
        
        public string FullName
        {
            get
            {
                return $"{ FirstName } {LastName}";
            }
        }
    }
}
