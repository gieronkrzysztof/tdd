using System;
using Xunit;

namespace TestProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data()
        {
            var testCalculator = new Calculator();
            
            testCalculator.AddNumbers(5, 10);

            
        }
    }
}
