using System;
using FluentAssertions;
using Xunit;

namespace TestProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void return_0__when__set_initial_data_to_0_and_expression_contains_only_init_data()
        {
            var calculatorValue = new Calculator(0);

            calculatorValue.Value.Should().Be(0);
        }

        [Fact]
        public void default_set_to_0__when__init_without_initial_data()
        {
            var calculatorValue = new Calculator();

            calculatorValue.Value.Should().NotBe(1);
            calculatorValue.Value.Should().Be(0);
            
        }
        

    }
}
