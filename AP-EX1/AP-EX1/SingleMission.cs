/******************
 * Efrat Harrison
 * harrise1
 * 318160215
 * ****************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class SingleMission : IMission
    {
        public func single = null;
        public SingleMission(func function, string name)
        {
            this.single = function;
            this.Name = name;
        }
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get { return "Single"; } }


        public double Calculate(double value)
        {
            double newVal = value;
            if(single != null)
            {
                newVal = single(value);
            }

            OnCalculate?.Invoke(this, newVal);
            return newVal;
        }
    }
}
