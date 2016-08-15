using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myAbacus.Models
{
    public class Adder
    {
        public Adder(string value1, string value2)
        {
            
            Value1 = value1;
            Value2 = value2;
        }

        public string Value1 { get; }
        public string Value2 { get; }

        public string Sum { get { return Add().ToString(); } }

        private double Add()
        {
            return Convert.ToDouble(Value1) + Convert.ToDouble(Value2);
        }
    }
}