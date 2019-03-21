using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public delegate double func(double val);
    public class FunctionsContainer
    {
        
        private Dictionary<string, func> dictionary = new Dictionary<string, func>();

        public func this[string funcName]
        {
            set { dictionary[funcName] = value; }
            get
            {
                if (!dictionary.ContainsKey(funcName))
                {
                    dictionary[funcName] = val => val;
                }
                return dictionary[funcName];
            }
        }

        public List<string> getAllMissions()
        {
            return new List<string>(this.dictionary.Keys);
        }


    }
}
