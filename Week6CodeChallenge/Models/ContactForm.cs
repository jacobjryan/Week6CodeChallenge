using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Week6CodeChallenge.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage="First name required.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First name required.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Last name required."), EmailAddress(ErrorMessage = "Not a valid e-mail address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "E-mail address required."), Phone]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Phone number required.")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Project description required.")]
        public string ProjectDescription { get; set; }
        [Required(ErrorMessage = "Comment required"), DataType(DataType.MultilineText)]
        public string Comment { get; set; }
    }
}