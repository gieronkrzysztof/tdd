using System;

namespace TestProject
{
    public class Class1
    {
    }

    public class Calculator
    {
        public int Value {get; private set; }

        public Calculator(int initialValue){
            Value = initialValue;
        }
         public Calculator() {
              Value = 0;
        }

        public int Add(int valueToAdd){
            Value += valueToAdd;
            return Value;
        }        
    }
}
