using System.Threading.Tasks;

namespace Calculator.Data
{
    public class CalculatorService : Helper 
    {
        public async Task<ProbabilityData> GetResultAsync(double PA, double PB, string TypeOfCalculation)
        {
            ProbabilityData probCalc = new ProbabilityData();

            if (PA >= 0 && PA <= 1 && PB >= 0 && PB <= 1)
            {
                probCalc.PA = PA;
                probCalc.PB = PB;
                probCalc.TypeOfCalculation = TypeOfCalculation;
                bool check = false;
                probCalc.currentCount = 0.0;

                if (TypeOfCalculation.Equals("Combined"))
                {
                    probCalc.currentCount = PA * PB;
                    check = true;
                }
                else if (TypeOfCalculation.Equals("Either"))
                {
                    probCalc.currentCount = PA + PB - (PA * PB);
                    check = true;
                }
                if (check) //result is valid output .txt file
                {
                    FileOutput(PA, PB, TypeOfCalculation, probCalc);
                }
                else
                {
                    probCalc.Error = "Error: Kindly Choose the Function Method!!";
                }
            }
            else 
            {
                probCalc.Error = "Error: Kindly Enter Value Between [0-1] only.";
            }
            return await Task.FromResult(probCalc);
        }
    }
}
