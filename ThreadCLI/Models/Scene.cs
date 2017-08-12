using System.Collections.Generic;
using ThreadCLI.Models.Interfaces;

namespace ThreadCLI.Models
{
    public class Scene : IScene
    {
        /// <summary>
        /// Gets or sets the scene number.
        /// </summary>>
        public int SceneNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        public string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        public string[] Script { get; set; }

        /// <summary>
        /// Gets or sets the scene actions.
        /// </summary>
        public IEnumerable<ISceneAction> SceneActions { get; set; }
    }
}
