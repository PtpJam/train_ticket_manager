using Newtonsoft.Json;
//using TestDapper.Controller;

namespace TestDapper.Controller
{
    public class ControllerJson
    {
        public ControllerJson()
        {
            m_jsonModel = JsonConvert.DeserializeObject<JsonModel>(File.ReadAllText("database.json"));
        }

        private JsonModel? m_jsonModel;
        public JsonModel jsonModel { 
            get { 

                if (m_jsonModel != null) 
                    return m_jsonModel;
                else 
                    throw new NullReferenceException("Can't open json file or file empty"); 

                } 
        }
    }
}