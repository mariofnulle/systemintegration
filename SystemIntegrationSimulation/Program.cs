using SystemIntegrationSimulation.SystemSimulation;
using SystemIntegrationSimulation.Handlers;
using SystemIntegrationSimulation.DataModels;
using SystemIntegrationSimulation.Interfaces;
using Newtonsoft.Json;

//Create the handler objects.
IData data = new DataHandler();
IIntegration integration = new JsonHandler();

#region Library System

//Create the default data simulating a Library system.
Library library = new()
{
    Authors = data.CreateAuthorDefaultData(out List<Book> books),
    Books = books
};

//Simulates an export of the data to be imported in another system.
integration.ExportJsonData(library);

#endregion

#region Catalog System

//Simulates the data file read.
string json = integration.DeserializeJsonData("Library.json");

//Import the data to the system.
Catalog catalog = JsonConvert.DeserializeObject<Catalog>(json) ?? new();

//Writes in the console the imported data.
catalog.ListRegisters();

#endregion



