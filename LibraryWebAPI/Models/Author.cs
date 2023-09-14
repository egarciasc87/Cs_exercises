using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebAPI.Models
{
    public class Author
    {
        public static int NumberOfBooks;
        public static int contador = 0;
        public int Id { get; set; }
        private string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int YearBirth { get; set; }

        //Overloaded constructors
        public Author()
        {

        }

        public Author(string firstName, string lastName)
        {
            contador++;
            this.Id = contador;
            this.FirstName = firstName;
            this.LastName = lastName;
            //this.YearBirth = yearBirth;
        }

        public void sayHello()
        {
            System.Console.WriteLine("Hello, my name is " +
                this.FirstName);
        }

        public string getFullName()
        {
            this.FullName = this.FirstName + " " + this.LastName;
            return this.FullName;
        }

        //public int getAge()
        //{
        //    int yearToday = DateTime.Today.Year;
        //    int age = yearToday - this.YearBirth;
        //    return age;
        //}
    }
}