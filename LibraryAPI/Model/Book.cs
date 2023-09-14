namespace LibraryAPI.Model
{
    public class Book
    {
        public static int Count = 0;
        public static int TotalNumberBooks = 0;
        public string Title { get; set; }
        public string Category { get; set; }
        //public int YearPublished { get; set; }
        public string Author { get; set; }
        public int Stock { get; private set; }
        public int Id { get; private set; }

        public Book(string title, string category, string author)
        {
            Count++;
            this.Id = Count;
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
}
