using System.ComponentModel.DataAnnotations;

namespace JobEntry.ViewModels
{
    public class JobDetailViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string JobTitle { get; set; } = "";
        [Required]
        public string Image { get; set; } = "";
        [Required]
        public string JobLocation { get; set; } = "";
        [Required]
        public string JobNature { get; set; } = "";
        [Required]
        public string JobDescription { get; set; } = "";
        [Required]
        public string Responsiblity { get; set; } = "";
        [Required]
        public string Qualification { get; set; } = "";
        [Required]
        public int MinPay { get; set; }

        [Required]
        public int MaxPay { get; set; }
        [Required]
        public int Vacency { get; set; }

        
        public DateTime DateLine { get; set; } = DateTime.Now;

        public DateTime PublishedOn { get; set; } = DateTime.Now;


    }
}
