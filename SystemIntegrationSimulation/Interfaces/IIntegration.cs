using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIntegrationSimulation.Interfaces
{
    ///<summary>
    ///Interface that sets the methods for the Json handling.
    ///</summary>
    internal interface IIntegration
    {
        public void ExportJsonData(object exportObject);

        public string DeserializeJsonData(string jsonFile);
    }
}
