using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parentalContribution
{
    internal class Category
    {
        private string name;
        private double price;
        private List<Student> students;

        public Category(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.students = new List<Student>();
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
        
        public double Price
        { 
            get 
            { 
                return price; 
            } 
            set 
            { 
                price = value; 
            } 
        }
        public void addStudent(Student student)
        {
            students.Add(student);
        }
        public List<Student> Students
        {
            get 
            { 
                return students;
            }
        }
        public Student getYoungestStudent()
        {
            int youngestStudentAge = students[0].calculateAge();
            Student youngestStudent = students[0];
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].calculateAge() < youngestStudentAge)
                {
                    youngestStudentAge = students[i].calculateAge();
                    youngestStudent = students[i];
                }
            }
            return youngestStudent;
        }
    }
}
