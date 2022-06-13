using System;

namespace parentalContribution
{
    internal class Student
    {
        private string name;
        private DateTime dateOfBirth;

        public Student(string name, int year, int month, int day)
        {
            this.name = name;
            this.dateOfBirth = new DateTime(year, month, day);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int calculateAge()
        {
            int age = DateTime.Now.Year - dateOfBirth.Year;
            if (dateOfBirth.Month > DateTime.Now.Month)
            {
                age--;
            }
            return age;
        }
    }
}
