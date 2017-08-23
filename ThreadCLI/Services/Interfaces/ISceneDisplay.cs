using System.Collections.Generic;
using ThreadCLI.Models;

namespace ThreadCLI.Services.Interfaces
{
    public interface ISceneDisplay
    {
        /// <summary>
        /// Gets or sets the scenes.
        /// </summary>
        IEnumerable<Scene> Scenes { get; set; }

        /// <summary>
        /// Selects the scene to display.
        /// </summary>
        /// <param name="sceneNumber">The scene number.</param>
        void SceneSelect(int sceneNumber);
    }
}
