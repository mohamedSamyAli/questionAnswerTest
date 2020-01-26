using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WepApi.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        [Required]
        public string header { get; set; }
        public string userName { get; set; }
        [Required]
        public string body { get; set; }
        public DateTime date { get; set; }
        public List<Answer> answers { get; set; }
    }
}