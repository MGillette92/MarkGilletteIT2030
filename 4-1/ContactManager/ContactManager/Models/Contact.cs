using System;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number in 555-555-5555 format.")]
        [Phone(ErrorMessage = "Please enter a phone number in 555-555-5555 format.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress(ErrorMessage = "Please enter a properly formatted email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string Organization { get; set; }

        public DateTime DateAdded { get; set; }

        public Contact()
        {
            DateAdded = DateTime.Now;
        }


        public string Slug => (FirstName + LastName).ToString();
    }
}