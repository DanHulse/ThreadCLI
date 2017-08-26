using System.Collections.Generic;

namespace Spindle.Models
{
    public class Story
    {
        public string StoryName { get; set; }

        public List<Chapter> Chapters { get; set; }
    }
}
