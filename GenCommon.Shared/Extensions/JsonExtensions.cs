using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenCommon.Shared.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception e)
            {
                return default;
            }
        }

        public static T ToObj<T>(this string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
                return default;
            }
        }
    }
}
