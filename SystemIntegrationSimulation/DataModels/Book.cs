using Newtonsoft.Json;

namespace SystemIntegrationSimulation.DataModels
{
    ///<summary>
    ///Book data model for Library System.
    ///</summary>
    [JsonObject("CatalogRegisters")]
    public class Book
    {
        [JsonProperty("AuthorRegister")]
        public Author Author { get; private set; }
        [JsonProperty("BookTitle")]
        public string Title { get; private set; }
        [JsonIgnore]
        public int Year { get; private set; }

        public Book(Author author, string title, int year)
        {
            Author = author;
            Title = title;
            Year = year;
        }
    }
}
