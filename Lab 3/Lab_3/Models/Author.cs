using System;
using System.Runtime.Serialization;

namespace Lab_3.Models
{
    [DataContract]
    public class Author : ICloneable
    {
        public Author(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        private string firstName;

        [DataMember]
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

        [DataMember]
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

        [DataMember]
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                if (value < DateTime.Now)
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

        public object Clone()
        {
            return new Author(FirstName, LastName, DateOfBirth);
        }
    }
}
