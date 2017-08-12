using ThreadCLI.Models.Enumerations;

namespace ThreadCLI.Models.Interfaces
{
    public interface IScene
    {
        /// <summary>
        /// Gets or sets the script.
        /// </summary>
        string[] Script { get; set; }

        /// <summary>
        /// Gets or sets the valid directions for the scene.
        /// </summary>
        Direction ValidDirection { get; set; }

        /// <summary>
        /// Gets or sets the scene actions.
        /// </summary>
        ISceneAction SceneActions { get; set; }
    }
}
