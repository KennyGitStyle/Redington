using System;

namespace Calculator.Data
{
    public class ProbabilityData 
    {
        public double PA { get; set; } 
        public double PB { get; set; }
        public string TypeOfCalculation { get; set; }
        public DateTime DateOfCalculation { get; } = DateTime.Now;
        public string Error { get; set; }
        public double currentCount { get; set; }
    }
}
