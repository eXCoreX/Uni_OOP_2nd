using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Model
{
    class Author
    {
        public Author(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value ?? throw new ArgumentNullException("Last name can't be null");
            }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (new DateTime(1880, 1, 1) < value && value < DateTime.Now)
                {
                    dateOfBirth = value;
                }
                else
                {
                    throw new ArgumentException("Invalid date of birth");
                }
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {DateOfBirth:D}";
        }
    }
}
