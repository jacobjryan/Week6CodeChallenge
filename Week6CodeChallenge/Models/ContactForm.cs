using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Week6CodeChallenge.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "First name required."), Display(Name = "First name:")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name required."), Display(Name = "Last name:")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "E-mail address required."), EmailAddress(ErrorMessage = "Not a valid e-mail address."), Display(Name = "E-mail:")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number required."), Phone(ErrorMessage = "Not a valid phone number."), Display(Name = "Phone:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Company name required."), Display(Name = "Company:")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Project description required."), Display(Name = "Project:")]
        public string ProjectDescription { get; set; }
        [Required(ErrorMessage = "Comment required."), DataType(DataType.MultilineText), Display(Name = "Comment:")]
        public string Comment { get; set; }
    }
}