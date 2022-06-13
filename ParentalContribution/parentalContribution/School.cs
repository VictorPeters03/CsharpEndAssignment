using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parentalContribution
{
    internal class School
    {
        private string name;
        private List<Category> categories;

        public School(string name)
        {
            this.name = name;
            categories = new List<Category>();
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


        public List<Category> Categories
        {
            get 
            { 
                return categories; 
            }
        }

        public void addCategories(Category category)
        {
            categories.Add(category);
        }

        public Category getCheapestCategory()
        {
            double cheapestCategoryPrice = categories[0].Price;
            Category cheapestCategory = Categories[0];
            for (int i = 1; i < categories.Count; i++)
            {
                if (categories[i].Price < cheapestCategoryPrice)
                {
                    cheapestCategory = categories[i];
                    cheapestCategoryPrice = categories[i].Price;
                }
            }
            return cheapestCategory;
        }

        public Student getYoungestStudent()
        {
            return getCheapestCategory().getYoungestStudent();
        }

        public int calculateStudentsPerCategory(Category category)
        {
            return category.Students.Count;
        }

        public double calculateTotalContribution()
        {
            double totalContribution = 0;
            foreach (Category category in categories)
            {
                totalContribution += category.Students.Count * category.Price;
            }
            return totalContribution;
        }
    }
}
