using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//polymorphism: many forms (author, student, employee)
class Author : Person
{
    public static int NumberOfBooks;

    public Author(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public void writeBook()
    {
        Console.WriteLine("I'm writing a new book.");
    }

    public void publishBook()
    {
        NumberOfBooks++;
    }

    //method overriding
    public void sayHello()
    {
        System.Console.WriteLine("Hello, my name is " +
            this.FirstName + ". I am writer.");
    }
}

class Student : Person
{
    private int yearBirth;

    public Student(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public void sayHello()
    {
        System.Console.WriteLine("Hello, my name is " +
            this.FirstName + ". I am a student.");
    }

    public int YearBirth
    {
        get 
        { 
            return yearBirth; 
        }
        set
        {
            if (value < 1950)
            {
                Console.WriteLine("Year birth can not be lower than 1950.");
                yearBirth = 1950;
            }
            else
            {
                yearBirth = value;
            }
        }
    }
}

class Employee : Person
{
    public Employee(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public void sayHello()
    {
        System.Console.WriteLine("Hello, my name is " +
            this.FirstName + ". I am a employee.");
    }
}
