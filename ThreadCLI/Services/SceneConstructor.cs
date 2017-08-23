using System;
using System.Collections.Generic;
using System.Linq;
using ThreadCLI.Helpers;
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
            var sceneDataSplit = sceneData.SplitString("\r\n", "\n");

            var sceneInfo = this.ConstructSceneInfo(sceneDataSplit.First());
            var script = this.ConstructScript(sceneDataSplit.Where(w => w.StartsWith("#")).Select(s => s.TrimStart('#')).ToArray());
            var actions = this.ConstructSceneActions(sceneDataSplit.Where(w => w.StartsWith("@")).Select(s => s.TrimStart('@')).ToArray());

            var scene = new Scene
            {
                SceneNumber = sceneInfo.sceneNumber,
                SceneName = sceneInfo.sceneName,
                Script = script,
                SceneActions = actions,
                ExitScene = actions.Any() ? false : true
            };

            return scene;
        }

        /// <summary>
        /// Constructs the scene information.
        /// </summary>
        /// <param name="sceneInfoData">The scene information data.</param>
        /// <returns>Value tuple containing scene information</returns>
        private (int sceneNumber, string sceneName) ConstructSceneInfo(string sceneInfoData)
        {
            var sceneInfo = sceneInfoData.SplitString("-");

            return (Int32.Parse(sceneInfo.First()), sceneInfo.Last());
        }

        /// <summary>
        /// Constructs the script.
        /// </summary>
        /// <param name="scriptData">The script data.</param>
        /// <returns>String array containing the script for the scene</returns>
        private string[] ConstructScript(string[] scriptData)
        {
            return scriptData;
        }

        /// <summary>
        /// Constructs the scene actions.
        /// </summary>
        /// <param name="actionData">The action data.</param>
        /// <returns>IEnumerable of actions that can be performed in the scene</returns>
        private IEnumerable<SceneAction> ConstructSceneActions(string[] actionData)
        {
            List<SceneAction> sceneActions = new List<SceneAction>();

            foreach (var action in actionData)
            {
                var actionSplit = action.SplitString("-");

                foreach (var verbAction in actionSplit.Last().SplitString("(", ")"))
                {
                    var subScripts = verbAction.ParseString("\"", "\"").SplitString("|");

                    var sceneAction = new SceneAction
                    {
                        KeyWord = actionSplit.First(),
                        KeyWordVerb = verbAction.ParseEnum<Verb>("*"),
                        AddToWordBag = verbAction.Contains("^") ? true : false,
                        NavigateToScene = verbAction.ParseInt("[", "]"),
                        ItemCheckConditions = this.ConstructSceneActionConditions(verbAction.ParseString("{", "}")),
                        SuccessResultScript = subScripts.ElementAtOrDefault(0),
                        FailureResultScript = subScripts.ElementAtOrDefault(1)
                    };

                    sceneActions.Add(sceneAction);
                }
            }

            return sceneActions;
        }

        /// <summary>
        /// Constructs the scene action conditions.
        /// </summary>
        /// <param name="conditionData">The condition data.</param>
        /// <returns>Dictionary of conditions that need to be met for the action to be successful</returns>
        private IDictionary<string, bool> ConstructSceneActionConditions(string conditionData)
        {
            var conditions = new Dictionary<string, bool>();

            var splitConditions = conditionData.SplitString(",");

            foreach (var splitCondition in splitConditions)
            {
                var checkTrue = splitCondition.Contains("!") ? false : true;
                
                conditions.Add(splitCondition.Replace("!", "") , checkTrue);
            }

            return conditions;
        }
    }
}
