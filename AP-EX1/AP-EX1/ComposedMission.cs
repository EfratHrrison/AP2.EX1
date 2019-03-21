using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class ComposedMission : IMission
    {
        //public func composed;

        List<func> listFunc= new List<func>();
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        public String Name { get; }
        public String Type { get { return "Composed"; } }
        public ComposedMission(string name)
        {

            this.Name = name;
        }
      
        public ComposedMission Add(func function){

            listFunc.Add(function);
            return this;

         }
        public double Calculate(double value) {
            foreach (var func in listFunc)
            {
                if (func != null)
                {
                    value = func(value);
                } 
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
