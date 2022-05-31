using SystemIntegrationSimulation.Interfaces;
using Newtonsoft.Json;

namespace SystemIntegrationSimulation.Handlers
{
    ///<summary>
    ///Handler that execute Json operations methods.
    ///</summary>
    public class JsonHandler : IIntegration
    {
        #region ExportJsonData

        ///<summary>
        ///Method that exports an object data to a Json file.
        ///<param name="exportObject">Object data to be exported.</param>
        ///</summary>
        public void ExportJsonData(object exportObject)
        {
            //Serialize the object in a Json formated string.
            string json = JsonConvert.SerializeObject(exportObject);

            //Writes the Json file, setting the object type name as the file name.
            using (StreamWriter sw = new(String.Format("{0}.json", exportObject.GetType().Name)))
            {
                sw.WriteLine(json);
            }
        }

        #endregion

        #region DeserializeJsonData

        ///<summary>
        ///Method that reads a Json file and return it as a string.
        ///<param name="jsonFile">The Json file name to be read.</param>
        ///</summary>
        ///<returns>The Json file converted in a string.</returns>
        public string DeserializeJsonData(string jsonFile)
        {
            string json;

            //Reads the received file and save it in a string.
            using (StreamReader sr = new(jsonFile))
            {
                json = sr.ReadToEnd();
            }

            return json;
        }

        #endregion
    }
}
