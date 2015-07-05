using System.ComponentModel.DataAnnotations;

namespace WebPlusLogicWithAPIApps_DevApps.Models
{
    public class CreateViewModel
    {
        [Display(Name = "Error")]
        public string Error { get; set; }
    }
}