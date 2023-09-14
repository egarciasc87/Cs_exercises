using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Book
{
    public static int TotalNumberBooks = 0;
    public string Title { get; set; }
    public string Category { get; set; }
    //public int YearPublished { get; set; }
    public string Author { get; set; }
    public int Stock { get; private set; }
    
    public Book()
    {

    }

    public Book(string title, string category, string author)
    {
        this.Title = title;
        this.Category = category;
        //this.YearPublished = yearPublished;
        this.Author = author;
        this.Stock = 0;
    }

    public void setStock(int stock)
    {
        TotalNumberBooks -= this.Stock;
        TotalNumberBooks += stock;
        this.Stock = stock;
    }
}
