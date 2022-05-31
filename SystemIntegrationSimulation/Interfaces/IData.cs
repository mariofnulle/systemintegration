using SystemIntegrationSimulation.DataModels;

namespace SystemIntegrationSimulation.Interfaces
{
    ///<summary>
    ///Interface that sets the methods for the default data creation.
    ///</summary>
    interface IData
    {
        public List<Author> CreateAuthorDefaultData(out List<Book> bookList);

        public List<Book> CreateBookDefaultData(List<Author> authorList);
    }
}
