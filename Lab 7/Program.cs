namespace IT1050IndiaCampbellLab7
{
    class BookTest
    {
        static void Book(string[] args)
        {
            Book myBook = new Book("Coldest Winer Ever", "Sister Souljah", 1999);

           

            myBook.Display();

          

        }

    }
}

 class Book
    {
        private string Title;
        private string Author;
        private int Year;

        public Book(string Title, string Director, int Year)
        {
            this.Title = Title;
            this.Author = Director;
            this.Year = Year;

        }

        public Book(string Title)
        {
            this.Title = Title;

        }

        public void Display()
        {
            Console.WriteLine("{0} Written by {1} released in {2}\n", Title, Author, Year);




        }
    }
}
