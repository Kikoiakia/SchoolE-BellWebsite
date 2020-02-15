using System.ComponentModel.DataAnnotations;

namespace Web.Models.Songs
{
    public class SongsCreateViewModel
    {
        [Required]
        public string Url { get; set; }

    }
    
}
