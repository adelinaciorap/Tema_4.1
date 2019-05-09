using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaBase
    { 
     private string baseName;
        public string BaseName
        {
            get { return baseName; }
            set { baseName = value; }
        }
        private double baseCost;
        public double BaseCost
        {
            get { return 3.5; }
            set { baseCost = value; }
        }


        private double extraCost;
        public double ExtraCost
        {
            get { return extraCost; }
            set { extraCost = value; }
        }


        public PizzaBase(string BaseType)
        {
            this.BaseName = BaseType;
            {
                if (BaseType == "Italian")
                {
                    ExtraCost = 1.5 * BaseCost;
                }
                else if (BaseType == "Thick")
                {
                    ExtraCost = 1.7 * BaseCost;
                }
                else
                {
                    BaseType = "Regular";
                    ExtraCost = BaseCost;
                }
            }
        }
             public void Print()
             {
                Console.WriteLine("The pizza has " + BaseName + " base");
                Console.WriteLine("The pizza costs " + ExtraCost);
             }
        
    }
}
