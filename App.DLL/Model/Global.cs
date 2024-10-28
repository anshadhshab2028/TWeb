using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DLL.Model
{
    public  class Global
    {
        public static string jsonSerialize<TValue>(TValue value)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };


            return JsonConvert.SerializeObject(value, settings);
        }
    }
}
