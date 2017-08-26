using System.Collections.Generic;

namespace Spindle.Models
{
    public class Scene
    {
        public int SceneNumber { get; set; }

        public string SceneName { get; set; }

        public string Script { get; set; }

        public bool EndingScene { get; set; }

        public List<SceneAction> Actions { get; set; }
    }
}
