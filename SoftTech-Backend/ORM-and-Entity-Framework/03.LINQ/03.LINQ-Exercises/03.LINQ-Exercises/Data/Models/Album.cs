using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public decimal Price { get { return Songs.Sum(x => x.Price); } set { } }

        [Required]
        [ForeignKey("Producer")]
        public int ProducerId { get; set; }
        public virtual Producer? Producer { get; set; }

        public virtual ICollection<Song>? Songs { get; set; }
    }
}