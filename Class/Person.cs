using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.Class
{
    public enum Gender
    {
        male,female,none
    }
    public class Person
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public DateTime DateTime { get; set; }  
        public Gender Gender { get; set; }
        public bool DrivingLicence { get; set; }

        public Person()
        {
            Name = null;
            Surname = null;
            Phone = null;
            Email = null;
            DateTime = new DateTime();
            Gender = Gender.none;
            DrivingLicence = false;
        }

        public Person(string name, string surname, string phone, string email, DateTime dateTime, Gender gender, bool drivingLicence)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Email = email;
            DateTime = dateTime;
            Gender = gender;
            DrivingLicence = drivingLicence;
        }
    }
}
