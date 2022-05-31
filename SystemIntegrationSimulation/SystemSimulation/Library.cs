using SystemIntegrationSimulation.DataModels;
using Newtonsoft.Json;

namespace SystemIntegrationSimulation.SystemSimulation
{
    ///<summary>
    ///Class that simulates a Library system for example purposes.
    ///</summary>
    [JsonObject("Catalog")]
    public class Library
    {
        [JsonIgnore]
        public List<Author> Authors = new();
        [JsonProperty("CatalogRegisters")]
        public List<Book> Books = new();
    }
}
