using System.Collections.Generic;

namespace Spindle.Models
{
    public class Chapter
    {
        public int ChapterNumber { get; set; }

        public string ChapterName { get; set; }

        public List<Scene> Scenes { get; set; }
    }
}
