using Newtonsoft.Json;

///<summary>
///Author data model for Library System.
///</summary>
namespace SystemIntegrationSimulation.DataModels
{
    [JsonObject("AuthorRegister")]
    public class Author
    {
        [JsonProperty("AuthorName")]
        public string Name { get; private set; }
        [JsonIgnore]
        public int BooksWritten { get; private set; }

        public Author(string name, int booksWritten)
        {
            Name = name;
            BooksWritten = booksWritten;
        }
    }
}
