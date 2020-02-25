using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data.Entity
{
    public class SongUser : IdentityUser<string>
    {
        public Song UpvotedSongs { get; set; }

        public Song DownvotedSongs { get; set; }
    }
}
