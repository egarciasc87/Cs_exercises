using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    enum DaysWeek { Monay, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

    private string FullName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    //public int YearBirth { get; set; }

    //Overloaded constructors
    public Person()
    {

    }

    public Person(string firstName, string lastName)
    {
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
