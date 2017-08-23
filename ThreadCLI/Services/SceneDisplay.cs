using System.Collections.Generic;
using System.Linq;
using ThreadCLI.Graphics;
using ThreadCLI.Helpers;
using ThreadCLI.Models;
using ThreadCLI.Services.Interfaces;

namespace ThreadCLI.Services
{
    public class SceneDisplay : ISceneDisplay
    {
        /// <summary>
        /// The list of scenes
        /// </summary>
        public IEnumerable<Scene> Scenes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SceneDisplay"/> class.
        /// </summary>
        public SceneDisplay()
        {

        }

        /// <summary>
        /// Selects the scene to display.
        /// </summary>
        /// <param name="sceneNumber">The scene number.</param>
        public void SceneSelect(int sceneNumber)
        {
            this.DisplayScene(Scenes.First(w => w.SceneNumber == sceneNumber));
            this.CaptureSceneAction();
        }

        /// <summary>
        /// Displays the scene.
        /// </summary>
        /// <param name="scene">The scene.</param>
        private void DisplayScene(Scene scene)
        {
            WriteText.Display($"{scene.SceneNumber} - {scene.SceneName}", ColourPalettes.Header);
            WriteText.Display(scene.Script, ColourPalettes.Primary);
        }

        /// <summary>
        /// Captures the scene action.
        /// </summary>
        /// <returns></returns>
        private int CaptureSceneAction()
        {
            return 0;
        }
    }
}
