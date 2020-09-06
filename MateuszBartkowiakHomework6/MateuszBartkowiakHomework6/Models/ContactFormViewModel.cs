using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MateuszBartkowiakHomework6.Models
{
    public class ContactFormViewModel
    {
        /// <summary>
        /// Imię
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Miejscowość
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Adres
        /// </summary>
        public string Address { get; set; }

    }
}
