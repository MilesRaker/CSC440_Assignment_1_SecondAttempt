using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC440_Assignment_1_SecondAttempt
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _dateOfBirth;
        DateTime today = DateTime.Now;

        private int _age => today.Subtract(_dateOfBirth).Days / 365;
        public bool isAdult
        {
            get
            {
                if(_age>= 18)
                {
                    return true;
                }
                return false;
            }
        }
        public string sunSign
        {
            get
            {
                string[] ZodiacSigns = { "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };
                bool firstHalfOfMonth = false; //true means birthdate.Day < 20
                if (_dateOfBirth.Day < 20) firstHalfOfMonth = true;

                if (firstHalfOfMonth)
                {
                    return ZodiacSigns[_dateOfBirth.Month - 1];
                }
                else
                {
                    return ZodiacSigns[_dateOfBirth.Month];
                }

            }
        }
        public string animalSign
        {
            get
            {

                if ((_dateOfBirth.Year - 1900) % 12 == 0)
                {
                    return "rat";
                }
                if ((_dateOfBirth.Year - 1900) % 13 == 0)
                {
                    return "ox";
                }
                if ((_dateOfBirth.Year - 1900) % 14 == 0)
                {
                    return "tiger";
                }
                if ((_dateOfBirth.Year - 1900) % 15 == 0)
                {
                    return "rabbit";
                }
                if ((_dateOfBirth.Year - 1900) % 16 == 0)
                {
                    return "dragon";
                }
                if ((_dateOfBirth.Year - 1900) % 17 == 0)
                {
                    return "snake";
                }
                if ((_dateOfBirth.Year - 1900) % 18 == 0)
                {
                    return "horse";
                }
                if ((_dateOfBirth.Year - 1900) % 19 == 0)
                {
                    return "sheep";
                }
                if ((_dateOfBirth.Year - 1900) % 20 == 0)
                {
                    return "monkey";
                }
                if ((_dateOfBirth.Year - 1900) % 21 == 0)
                {
                    return "rooster";
                }
                if ((_dateOfBirth.Year - 1900) % 22 == 0)
                {
                    return "dog";
                }
                if ((_dateOfBirth.Year - 1900) % 23 == 0)
                {
                    return "pig";
                }
                else
                {
                    return "no matching animal sign";
                }
            }
        }
        public bool isBirthday
        {
            get
            {
                if (_dateOfBirth.Month - today.Month == 0 && _dateOfBirth.Day - today.Day == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public string defaultScreenName
        {
            get
            {
                return _firstName[0] + _lastName + _dateOfBirth.Month + _dateOfBirth.Day;
            }
        }

        public Person(string firstName, string lastName, string email, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _dateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName, string email)
            : this(firstName, lastName, email, new DateTime()) { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
            : this(firstName, lastName, "", new DateTime()) { }


    }
}
