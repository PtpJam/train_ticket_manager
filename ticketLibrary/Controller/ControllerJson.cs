using Newtonsoft.Json;
//using TestDapper.Controller;

namespace TestDapper.Controller
{
    public class ControllerJson
    {
        public ControllerJson(string filename = "database.json")
        {
            m_jsonModel = JsonConvert.DeserializeObject<JsonModel>(File.ReadAllText(filename));
        }

        private JsonModel? m_jsonModel;
        public JsonModel jsonModel { 
            get { 

                if (m_jsonModel != null) 
                    return m_jsonModel;
                else 
                    throw new NullReferenceException("Can't open json file or file is empty"); 
                } 
        }
    }
}