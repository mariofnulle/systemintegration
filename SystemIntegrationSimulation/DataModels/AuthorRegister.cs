namespace SystemIntegrationSimulation.DataModels
{
    ///<summary>
    ///Author data model for Catalog System.
    ///</summary>
    public class AuthorRegister
    {
        public string AuthorName { get; private set; }

        public string AuthorAddress { get; private set; }

        public int Age { get; private set; }

        public AuthorRegister(string authorName, string authorAddress, int age)
        {
            AuthorName = authorName;
            AuthorAddress = authorAddress;
            Age = age;
        }
    }
}
