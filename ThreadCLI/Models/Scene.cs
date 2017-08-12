using ThreadCLI.Models.Enumerations;
using ThreadCLI.Models.Interfaces;

namespace ThreadCLI.Models
{
    public class Scene : IScene
    {
        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        public string[] Script { get; set; }

        /// <summary>
        /// Gets or sets the valid directions for the scene.
        /// </summary>
        public Direction ValidDirection { get; set; }

        /// <summary>
        /// Gets or sets the scene actions.
        /// </summary>
        public ISceneAction SceneActions { get; set; }
    }
}
