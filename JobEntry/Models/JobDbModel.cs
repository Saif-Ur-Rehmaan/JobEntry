using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobEntry.Models
{
    public class JobDbModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; } = "";
        [Required]
        public string Image{ get; set; } = "";
        [Required]
        public string JobLocation { get; set; } = "";
        [Required]
        [StringLength(20)]
        public string JobNature{ get; set; } = "";
        [Required]
        [Column(TypeName = "text")]
        public string JobDescription { get; set; }= "";
        [Required]
        [Column(TypeName = "text")]
        public string Responsiblity { get; set; }= "";
        [Required]
        [Column(TypeName = "text")]
        public string Qualification{ get; set; }= "";
        [Required]
        public int MinPay { get; set; }

        [Required]
        public int MaxPay { get; set; }
        [Required]
        public int Vacency{ get; set; }
         
        public DateTime DateLine { get; set; } = DateTime.Now;
 
        public DateTime PublishedOn { get; set; } = DateTime.Now;


    }
}
