using SystemIntegrationSimulation.DataModels;

namespace SystemIntegrationSimulation.SystemSimulation
{
    ///<summary>
    ///Class that simulates a Catalog system for example purposes.
    ///</summary>
    public class Catalog
    {
        public List<CatalogRegister> CatalogRegisters = new();

        //Method only for example purpose.
        public CatalogRegister? CreateNewRegister()
        {
            return null;
        }

        ///<summary>
        ///Method that write in the console all the registers in the system.
        ///</summary>
        public void ListRegisters()
        {
            foreach (CatalogRegister register in this.CatalogRegisters)
            {
                Console.WriteLine(String.Format("Book: {0}\n Author: {1}\n-------------------------", register.BookTitle, register.AuthorRegister.AuthorName));
            }

        }
    }
}
