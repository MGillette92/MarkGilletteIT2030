using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a subtotal.")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage =
               "The subtotal must be a valid number greater than 0.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0, 100, ErrorMessage =
               "Discount percent must be between 0 and 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? discountAmount = 0;


         public decimal? CalculateDiscountAmount()
        {

            discountAmount = Subtotal * (DiscountPercent / 100);

            return discountAmount;

        }

        public decimal? CalculatePriceQuotation()
        {
            decimal? priceQuotation = 0;
            priceQuotation = Subtotal - discountAmount;

            return priceQuotation;

        }


    }
}