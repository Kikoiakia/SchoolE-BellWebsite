using Data.Entity;
using System.Collections.Generic;
using Web.Models.Shared;

namespace Web.Models.Songs
{
    public class SongsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<SongViewModel> Items { get; set; }

        public SongUser User { get; set; }
    }
}
