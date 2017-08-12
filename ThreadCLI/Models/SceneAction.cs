using System.Collections.Generic;
using ThreadCLI.Models.Interfaces;

namespace ThreadCLI.Models
{
    public class SceneAction : ISceneAction
    {
        /// <summary>
        /// Gets or sets the valid verbs that can be used on this action.
        /// </summary>
        public string[] ValidVerbs { get; set; }

        /// <summary>
        /// Gets or sets the key word that triggers this action in the scene.
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// Gets or sets the item check conditions. Key is key word and value is whether key word exists
        /// </summary>
        public IDictionary<string, bool> ItemCheckConditions { get; set; }

        /// <summary>
        /// Gets or sets the script that returns after the action is successful.
        /// </summary>
        public string[] SuccessResultScript { get; set; }

        /// <summary>
        /// Gets or sets the script that returns if the action has failed.
        /// </summary>
        public string[] FailureResultScript { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the key word to the agent's word bag.
        /// </summary>
        public bool AddToWordBag { get; set; }
    }
}
