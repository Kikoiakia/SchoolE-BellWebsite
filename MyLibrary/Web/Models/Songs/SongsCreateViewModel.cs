using System.ComponentModel.DataAnnotations;

namespace Web.Models.Songs
{
    public class SongsCreateViewModel
    {

        [Required]
        [MaxLength(80, ErrorMessage = "Author name cannot be longer than 80 characters")]
        public string Title { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "Title length cannot be more than 80 characters")]
        public string Thumbnail { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Negative values are not accepted")]
        public int Rating { get; set; }

        [Required]
        public string Url { get; set; }

    }
    /*
     * Title = s.Title,
                Thumbnail = s.Thumbnail,
                Rating = s.Rating,                
                Url = s.Url,  
                */
}
