using System.Collections.Generic;

namespace ThreadCLI.Models.Interfaces
{
    public interface IScene
    {
        /// <summary>
        /// Gets or sets the scene number.
        /// </summary>>
        int SceneNumber { get; set; }

        /// <summary>
        /// Gets or sets the name of the scene.
        /// </summary>
        string SceneName { get; set; }

        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        string[] Script { get; set; }

        /// <summary>
        /// Gets or sets the scene actions.
        /// </summary>
        IEnumerable<ISceneAction> SceneActions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this scene is an exit scene.
        /// </summary>
        bool ExitScene { get; set; }
    }
}
