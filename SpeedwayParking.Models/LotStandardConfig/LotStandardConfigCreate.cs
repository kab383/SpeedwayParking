using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SpeedwayParking.Models.LotStandardConfig
{
    public class LotStandardConfigCreate
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Choose between 0 and 5000 spaces for this lot's standard Auto parking configuration:")]
        [RegularExpression("([0-5000]+)", ErrorMessage = "Please enter number between 0 and 5000")]
        public int NumberOfAutoSpaces { get; set; }
        [Display(Name = "Choose between 0 and 250 spaces for this lot's standard RV parking configuration:")]
        [RegularExpression("([0-250]+)", ErrorMessage = "Please enter number between 0 and 250")]
        public int NumberOfRvSpaces { get; set; }
        [Display(Name = "Choose between 0 and 1500 spaces for this lot's standard Motorcycle parking configuration:")]
        [RegularExpression("([0-1500]+)", ErrorMessage = "Please enter number between 0 and 1500")]
        public int NumberOfMotorcycleSpaces { get; set; }
        [Display(Name = "Choose between 0 and 5000 spaces for this lot's standard ADA parking configuration:")]
        [RegularExpression("([0-1000]+)", ErrorMessage = "Please enter number between 0 and 1000")]
        public int NumberOfAdaSpaces { get; set; }
    }
}
