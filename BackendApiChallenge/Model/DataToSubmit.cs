using System.ComponentModel.DataAnnotations;

namespace BackendApiChallenge.Model
{
    public class DataToSubmit
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        [Required]
        public string supervisor { get; set; }
    }
}
