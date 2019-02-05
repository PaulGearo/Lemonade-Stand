using System;
using System.Collections.Generic;
using System.Text;

namespace lemonade_stand
{
    class LemonadeStand
    {
        public LemonadeStand()
        {
            Name = Program.GetStringResponce("What's the name of the Stand?");
            MonthsInOperation = Program.GetIntResponce("How may months were you open?");
            NumberOfCupsSoldPerMonth = Program.GetIntResponce("How may cups did you sell?");
            PricePerCup = Program.GetDoubleResponce("what was the price per cup?");
            LemonsCostPerCup = Program.GetDoubleResponce("What was the cost of lemons per cup?");
            SugerCostPerCup = Program.GetDoubleResponce("what was the cost of suger per cup?");
            PaperCup = Program.GetDoubleResponce("whats the cost of the paper cups sold?");
            TableCost = Program.GetDoubleResponce("What was the cost of table");
            ChairCost = Program.GetDoubleResponce("what was the cost of chair");
            SignCost = Program.GetDoubleResponce("what was the cost of sign?");
        }

        public string Name { get; set; }
        public int MonthsInOperation { private get; set; }
        public int NumberOfCupsSoldPerMonth { private get; set; }
        public double PricePerCup { private get; set; }
        public double SugerCostPerCup { private get; set; }
        public double LemonsCostPerCup { private get; set; }
        public double PaperCup { private get; set; }
        public double ChairCost { private get; set; }
        public double TableCost { private get; set; }
        public double SignCost { private get; set; }

        private double GetRevenueForMonth()
        {
            return PricePerCup * NumberOfCupsSoldPerMonth;
        }
        private double GetExpensesForMonthExucldingOverhead()
        {
            return NumberOfCupsSoldPerMonth * (SugerCostPerCup + LemonsCostPerCup + PaperCup);
        }
        private double GetProfitForMonthExludingOverhead()
        {
            return GetRevenueForMonth() - GetExpensesForMonthExucldingOverhead();
        }
        private double GetOverheadCosts()
        {
            return ChairCost + TableCost + SignCost;
        }

        private double GetLifeTimeRevenue()
        {
            return (GetRevenueForMonth() * MonthsInOperation);
        }

        private  double GetLifetimeMonthlyProfits()
        {
            return GetExpensesForMonthExucldingOverhead() * MonthsInOperation;
        }

        public double GetLifetimeTotalProfit()
        {
            return GetLifeTimeRevenue() - GetOverheadCosts();
        }
    }
}
