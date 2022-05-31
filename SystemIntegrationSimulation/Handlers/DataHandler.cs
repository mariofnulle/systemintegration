using SystemIntegrationSimulation.DataModels;
using SystemIntegrationSimulation.Interfaces;

namespace SystemIntegrationSimulation.Handlers
{
    ///<summary>
    ///Handler that creates the default data for testing purposes.
    ///</summary>
    public class DataHandler : IData
    {
        #region CreateAuthorDefaultData

        ///<summary>
        ///Method that creates the default data for Authors in Library System.
        ///<param name="bookList">List of Books default data</param>
        ///</summary>
        ///<returns>A list of Authors</returns>
        public List<Author> CreateAuthorDefaultData(out List<Book> bookList)
        {
            //Creates the default author data list.
            List<Author> authorList = new()
            {
                new Author("George R. R. Martin", 5),
                new Author("J. R. R. Tolkien", 4),
                new Author("Douglas Adams", 1)
            };

            //Execute the default book data creation method, passing the created author list.
            bookList = CreateBookDefaultData(authorList);

            return authorList;
        }

        #endregion

        #region CreateBookDefaultData

        ///<summary>
        ///Method that creates the default data for Authors in Library System.
        ///<param name="authorList">List of existing Authors</param>
        ///</summary>
        ///<returns>A list of Books</returns>
        public List<Book> CreateBookDefaultData(List<Author> authorList)
        {
            List<Book> bookList = new();
            
            //Pass trough each author, binding the book data to each author correctly.
            foreach(Author author in authorList)
            {
                //Pass trough each author, binding the book data to each author correctly.
                switch (author.Name)
                {
                    case "George R. R. Martin":
                        bookList.Add(new Book(author, "A Game of Thrones", 1996));
                        bookList.Add(new Book(author, "A Clash of Kings", 1998));
                        bookList.Add(new Book(author, "A Storm of Swords", 2000));
                        bookList.Add(new Book(author, "A Feast for Crows", 2005));
                        bookList.Add(new Book(author, "A Dance with Dragons", 2011));
                        break;
                    case "J. R. R. Tolkien":
                        bookList.Add(new Book(author, "The Hobbit, or There and Back Again", 1937));
                        bookList.Add(new Book(author, "The Fellowship of the Ring", 1954));
                        bookList.Add(new Book(author, "The Two Towers", 1954));
                        bookList.Add(new Book(author, "The Return of the King", 1955));
                        break;
                    case "Douglas Adams":
                        bookList.Add(new Book(author, "The Hitchhiker's Guide to the Galaxy", 1985));
                        break;
                }

            }

            return bookList;
        }

        #endregion
    }
}
