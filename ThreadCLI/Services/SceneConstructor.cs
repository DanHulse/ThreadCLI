using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ThreadCLI.Models;
using ThreadCLI.Models.Enumerations;
using ThreadCLI.Services.Interfaces;

namespace ThreadCLI.Services
{
    public class SceneConstructor : ISceneConstructor
    {
        /// <summary>
        /// Constructs the scene
        /// </summary>
        /// <param name="sceneData">The scen data</param>
        /// <returns>A constructed <see cref="Scene"/></returns>
        public Scene Construct(string sceneData)
        {
            var sceneDataSplit = Regex.Split(sceneData, Regex.Escape("##"));

            var sceneInfo = this.ConstructSceneInfo(sceneDataSplit[0]);
            var script = this.ConstructScript(sceneDataSplit[1]);
            var actions = this.ConstructSceneActions(sceneDataSplit[2]);

            var scene = new Scene
            {
                SceneNumber = sceneInfo.sceneNumber,
                SceneName = sceneInfo.sceneName,
                Script = script,
                SceneActions = actions
            };

            return scene;
        }

        private (int sceneNumber, string sceneName) ConstructSceneInfo(string sceneInfoData)
        {
            var sceneInfo = sceneInfoData.Split('-').ToList();

            return (Int32.Parse(sceneInfo.First()), sceneInfo.Last());
        }

        private string[] ConstructScript(string scriptData)
        {
            var script = scriptData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            return script;
        }

        private IEnumerable<SceneAction> ConstructSceneActions(string actionData)
        {
            List<SceneAction> sceneActions = new List<SceneAction>();
            var actions = actionData.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).ToList();

            foreach (var action in actions)
            {
                var actionSplit = action.Split('-').ToList();

                foreach (var verbAction in actionSplit.Skip(1))
                {
                    var sceneAction = new SceneAction
                    {
                        KeyWord = actionSplit.First(),
                        KeyWordVerb = (Verb)Enum.Parse(typeof(Verb), Regex.Match(verbAction, @"\(([^)]*)\)").Groups[1].Value),
                        AddToWordBag = verbAction.Contains("^") ? true : false,
                        NavigateToScene = verbAction.Contains("[") ? Int32.Parse(Regex.Match(verbAction, @"\[([^)]*)\]").Groups[1].Value) : (int?)null,
                        ItemCheckConditions = this.ConstructSceneActionConditions(Regex.Match(verbAction, @"\{([^)]*)\}").Groups[1].Value),
                        SuccessResultScript = Regex.Match(verbAction, "\"([^\"]*)\"").Groups[1].Value,
                        FailureResultScript = verbAction.Contains("|") ? Regex.Match(verbAction, "\"([^\"]*)\"").Groups[3].Value : null
                    };

                    sceneActions.Add(sceneAction);
                }
            }

            return sceneActions;
        }

        private IDictionary<string, bool> ConstructSceneActionConditions(string conditionData)
        {
            var conditions = new Dictionary<string, bool>();

            var splitConditions = conditionData.Split(',');

            foreach (var splitCondition in splitConditions)
            {
                var checkTrue = splitCondition.Contains("!") ? false : true;
                
                conditions.Add(splitCondition.Replace("!", "") , checkTrue);
            }

            return conditions;
        }
    }
}
