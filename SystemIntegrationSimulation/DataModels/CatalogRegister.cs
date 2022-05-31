namespace SystemIntegrationSimulation.DataModels
{
    ///<summary>
    ///Catalog Registers data model for Catalog System.
    ///</summary>
    public class CatalogRegister
    {
        public AuthorRegister AuthorRegister { get; private set; }
        public string BookTitle { get; private set; }

        public CatalogRegister(AuthorRegister authorRegister, string bookTitle)
        {
            AuthorRegister = authorRegister;
            BookTitle = bookTitle;
        }
    }
}
