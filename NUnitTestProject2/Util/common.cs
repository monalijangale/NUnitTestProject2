using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnitTestProject2.Util
{
  public static class common
    {
        public static string GetConfig(String Configparameter)
        {
            String JsonFile = File.ReadAllText(@"../../../../Config.json");
            var config = JObject.Parse(JsonFile);
            string Configvalue = config.GetValue(Configparameter).ToString();
            return Configvalue;

        }

        
    }
}
