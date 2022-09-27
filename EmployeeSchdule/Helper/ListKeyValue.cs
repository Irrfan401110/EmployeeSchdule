using System.Collections.Generic;

namespace EmployeeSchdule.Helper
{

    public class ListKeyValue : List<KeyValuePair<string, object>>
    {
        public void Add(string key, object value)
        {
            var element = new KeyValuePair<string, object>(key, value);
            this.Add(element);
        }
    }
}