using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class TipCalculatorModel
    {
        [Required(ErrorMessage = "Please enter the cost of meal.")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage =
               "The cost must be a valid number greater than 0.")]
        public decimal? CostofMeal { get; set; }




        public decimal? CalculateTip15()
        {
            decimal? tip15 = 0;
            tip15 = (CostofMeal / 10) + (CostofMeal / 20);
            return tip15;

        }
        public decimal? CalculateTip20()
        {
            decimal? tip20 = 0;
            tip20 = CostofMeal / 5;
            return tip20;

        }
        public decimal? CalculateTip25()
        {
            decimal? tip25 = 0;
            tip25 = CostofMeal / 4;
            return tip25;

        }


    }
}