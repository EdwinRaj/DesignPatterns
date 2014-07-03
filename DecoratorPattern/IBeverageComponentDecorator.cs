using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public interface IBeverageComponentDecorator:IBeverageComponent
    {
        IBeverageComponent BeverageComponent { get; }
    }

    public class MochaComponentDecorator : IBeverageComponentDecorator
    {
        public MochaComponentDecorator(IBeverageComponent beverage)
        {
            this.BeverageComponent = beverage;
        }
        public string GetDescription()
        {
            return BeverageComponent.GetDescription() + " , Mocha";
        }

        public decimal Cost()
        {
            return BeverageComponent.Cost() + 2;
        }

        public IBeverageComponent BeverageComponent { get; private set; }
    }

    public class WhipComponentDecorator : IBeverageComponentDecorator
    {
        public WhipComponentDecorator(IBeverageComponent beverage)
        {
            this.BeverageComponent = beverage;
        }
        public string GetDescription()
        {
            return BeverageComponent.GetDescription() + " , WhipCream";
        }

        public decimal Cost()
        {
            return BeverageComponent.Cost() + 4;
        }

        public IBeverageComponent BeverageComponent { get; private set; }
    }

    public class MilkComponentDecorator : IBeverageComponentDecorator
    {
        public MilkComponentDecorator(IBeverageComponent beverage)
        {
            this.BeverageComponent = beverage;
        }
        public string GetDescription()
        {
            return BeverageComponent.GetDescription() + " ,Milk";
        }

        public decimal Cost()
        {
            return BeverageComponent.Cost() + 5;
        }

        public IBeverageComponent BeverageComponent { get; private set; }
    }
}
