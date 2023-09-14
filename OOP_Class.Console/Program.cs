// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
https://www.youtube.com/watch?v=9V5B3dNoVIA&list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_&index=31
*/

List<Person> listStudents = new List<Person>();
List<Book> listBooks = new List<Book>();
List<Author> listAuthors = new List<Author>();
Book[] arrayBooks = new Book[5];

const double PI = 3.1416;
string title = "";
string authorName = "";
string category = "";
int stock = 0;

string firstName = "";
string lastName = "";
string yearTemp = "";
int yearBirth = 0;
string option = "";

Person person;
Book book;
Author author;
Student student;
Employee employee;

Console.WriteLine("1 - Book");
Console.WriteLine("2. Author");
Console.WriteLine("3. Person (varios)");
Console.WriteLine("Select class:");
option = Console.ReadLine();

Console.WriteLine("Enter number of items: ");
string input = Console.ReadLine();
int numberItems = Int16.Parse(input);

switch (option)
{
    case "1":
        Console.WriteLine("\nInput data -> Books");

        for (int i = 0; i < numberItems; i++)
        {
            Console.WriteLine("Book #" + (i + 1));
            Console.WriteLine("Enter title: ");
            title = Console.ReadLine();
            Console.WriteLine("Enter author: ");
            authorName = Console.ReadLine();
            Console.WriteLine("Enter category: ");
            category = Console.ReadLine();
            book = new Book(title, category, authorName);

            Console.WriteLine("Enter stock: ");
            input = Console.ReadLine();
            stock = Int16.Parse(input);
            book.setStock(stock);

            listBooks.Add(book);
        }

        break;
    case "2":
        Console.WriteLine("\nInput data -> Authors");

        for (int i=0; i<numberItems; i++)
        {
            Console.WriteLine("Author #" + (i + 1));
            Console.WriteLine("Enter first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            lastName = Console.ReadLine();
            author = new Author(firstName, lastName);
            author.sayHello();
            author.writeBook();
            listAuthors.Add(author);
        }
        break;
    case "3":
        employee = new Employee("Ernesto", "Jimenez");
        author = new Author("Carlos", "Hernandez");
        student = new Student("Andrés", "Villa");
        Console.WriteLine("Enter year birth student:");
        input = Console.ReadLine();
        yearBirth = Int16.Parse(input);
        student.YearBirth = yearBirth;
        Console.WriteLine("Student's year birth ->" + student.YearBirth);
        
        Person[] arrayPerson = { employee, author, student};
        arrayPerson[0].sayHello();
        arrayPerson[1].sayHello();
        arrayPerson[2].sayHello();
        employee.sayHello();
        author.sayHello();
        student.sayHello();
        listAuthors.Add(author);
        break;
    default:
        break;
}


Console.WriteLine("\nShow data:");
Console.WriteLine("Total stock: " + Book.TotalNumberBooks);

for (int i = 0; i < numberItems; i++)
{

    //Console.WriteLine("Student #" + (i + 1));
    //Console.WriteLine("Full name: " + listStudents[i].getFullName());
    //Console.WriteLine("Age: " + listStudents[i].getAge());
    
    //Console.WriteLine("\nEnter year of birth: ");
    //yearBirth = 1987;
}

