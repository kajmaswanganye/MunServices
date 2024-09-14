using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json; 
namespace MunServices
{
   

    public class FileHandler
    {
        public static void SaveToJson<T>(string filePath, T data)
        {
            var jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }

        public static T LoadFromJson<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default(T);
            }

            var jsonData = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }
    }

}
