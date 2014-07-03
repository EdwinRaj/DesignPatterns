using System;
using DecoratorPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DecoratorPatternTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateBeverageTest()
        {
            //Creating Double Mocha Milk Espresso
            IBeverageComponent beverageComponent = new EspressoComponent();
            IBeverageComponentDecorator mochaDecorator = new MochaComponentDecorator(beverageComponent);
            IBeverageComponentDecorator doubleMochaDecorator = new MochaComponentDecorator(mochaDecorator);
            IBeverageComponentDecorator milkDecorator = new MilkComponentDecorator(doubleMochaDecorator);
            Console.WriteLine(milkDecorator.GetDescription());
            Assert.AreEqual(29,milkDecorator.Cost());

        }
    }
}
