using System.Collections.Generic;
using ThreadCLI.Models;
using ThreadCLI.Services;
using ThreadCLI.Services.Interfaces;

namespace ThreadCLI
{
    public class Application
    {
        private readonly IDataLoader dataLoader;

        private readonly ISceneConstructor sceneConstructor;

        public Application()
        {
            this.dataLoader = new DataLoader();
            this.sceneConstructor = new SceneConstructor();
        }

        public void Run(string dataFile)
        {
            this.LoadData(dataFile);
        }

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
