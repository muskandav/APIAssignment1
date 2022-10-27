using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIAssignment.Entities
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [StringLength(20)]
        [Column(TypeName = "varchar")]
        [Required]
        public string MovieName { get; set; }
        public string? Lang { get; set; }
        public DateTime? ReleaseYear { get; set; }
        public string? Actor { get; set; }
        public string? Director { get; set; }
    }
}
