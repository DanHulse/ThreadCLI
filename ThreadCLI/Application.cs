using System.Collections.Generic;
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
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// </summary>
        public Application()
        {
            this.dataLoader = new DataLoader();
            this.sceneConstructor = new SceneConstructor();
        }

        /// <summary>
        /// Runs the application functions, application entry point.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        public void Run(string dataFile)
        {
            this.LoadData(dataFile);
        }

        /// <summary>
        /// Loads the data from the data file.
        /// </summary>
        /// <param name="dataFile">The data file.</param>
        private void LoadData(string dataFile)
        {
            List<Scene> scenes = new List<Scene>();
            var sceneDataStream = this.dataLoader.ReadDataFile(dataFile);

            foreach (var sceneData in sceneDataStream)
            {
                var scene = this.sceneConstructor.Construct(sceneData);

                scenes.Add(scene);
            }

            string tests = "";
        }
    }
}
