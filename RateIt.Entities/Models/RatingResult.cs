using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RateIt.Entities.Models
{
    public class RatingResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Rating")]
        public int RatingId { get; set; }

        public RatingResultType ResultType { get; set; }

        public string Value { get; set; }

        public Rating Rating { get; set; }
    }
}
