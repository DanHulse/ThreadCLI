using ThreadCLI.Models;

namespace ThreadCLI.Services.Interfaces
{
    public interface ISceneConstructor
    {
        /// <summary>
        /// Constructs the scene
        /// </summary>
        /// <param name="sceneData">The scen data</param>
        /// <returns>A constructed <see cref="Scene"/></returns>
        Scene Construct(string sceneData);
    }
}
