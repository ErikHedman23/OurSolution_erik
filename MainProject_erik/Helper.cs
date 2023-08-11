using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject_erik
{
    public class Helper
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public string Greeting(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {name}!";
            }
        }
        

    }
}
