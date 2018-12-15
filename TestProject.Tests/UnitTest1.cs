using System;
using Xunit;

namespace TestProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            var calculatorValue = new Calculator();

            calculatorValue.Value.Should().NotBe(1);
            calculatorValue.Value.Should().Be(0);
        }
        
        [Fact]
        public void increase_new_value__when__add_value_to_earlier_value()
        {
            var math = new Calculator();

            math.Add(15);

            math.Should().Be(15);
        }
    }
}
