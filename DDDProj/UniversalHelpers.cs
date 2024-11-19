using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DDDProj
{
    public class UserDataParse
    {
        private string _UserPath;


        //private readonly JsonSerializerOptions _options = new()
        //{
        //    PropertyNameCaseInsensitive = true
        //};



        public static Root? Parse(string filePath)
        {
            string _jsonString;
            using (StreamReader sr = new StreamReader(filePath))
            {
                _jsonString = sr.ReadToEnd();
                sr.Close();
            }
            Root? myDeserializedClass = JsonSerializer.Deserialize<Root>($"{{\"Frames\":{_jsonString}}}");
            return myDeserializedClass;
        }

    }


    internal class UniversalHelpers
    {
    }
}
