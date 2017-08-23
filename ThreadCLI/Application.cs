using System.Collections.Generic;
using System.Linq;
using ThreadCLI.Models;
using ThreadCLI.Services;
using ThreadCLI.Services.Interfaces;

namespace ThreadCLI
{
    public class Application
    {
        /// <summary>
        /// The data loader
        /// </summary>
        private readonly IDataLoader dataLoader;

        /// <summary>
        /// The scene constructor
        /// </summary>
        private readonly ISceneConstructor sceneConstructor;

        /// <summary>
        /// The scene display
        /// </summary>
        private readonly ISceneDisplay sceneDisplay;

        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        public Application()
        {
            this.dataLoader = new DataLoader();
            this.sceneConstructor = new SceneConstructor();
            this.sceneDisplay = new SceneDisplay();
        }

        /// <summary>
        /// Runs the application functions, application entry point.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        public void Run(string dataFile)
        {
            var scenes = this.LoadData(dataFile).OrderBy(o => o.SceneNumber).ToList();

            this.sceneDisplay.Scenes = scenes;

            this.sceneDisplay.SceneSelect(1);
        }

        /// <summary>
        /// Loads the data from the data file.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        private List<Scene> LoadData(string dataFile)
        {
            List<Scene> scenes = new List<Scene>();
            var sceneDataStream = this.dataLoader.ReadDataFile(dataFile);

            foreach (var sceneData in sceneDataStream)
            {
                var scene = this.sceneConstructor.Construct(sceneData);

                scenes.Add(scene);
            }

            return scenes;
        }
    }
}
