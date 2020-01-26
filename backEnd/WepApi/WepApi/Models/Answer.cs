using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WepApi.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        [Required]
        public string body { get; set; }
        public string userName { get; set; }
        public DateTime date { get; set; }
       
        [ForeignKey("question")]
        [Required]
        public string questionFK { get; set; }
        public Question question { get; set; }
    }
}