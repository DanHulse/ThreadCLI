using System.Collections.Generic;

namespace ThreadCLI.Models.Interfaces
{
    public interface ISceneAction
    {
        /// <summary>
        /// Gets or sets the valid verbs that can be used on this action.
        /// </summary>
        string[] ValidVerbs { get; set; }

        /// <summary>
        /// Gets or sets the key word that triggers this action in the scene.
        /// </summary>
        string KeyWord { get; set; }

        /// <summary>
        /// Gets or sets the item check conditions. Key is key word and value is whether key word exists
        /// </summary>
        IDictionary<string, bool> ItemCheckConditions { get; set; }

        /// <summary>
        /// Gets or sets the script that returns after the action is successful.
        /// </summary>
        string[] SuccessResultScript { get; set; }

        /// <summary>
        /// Gets or sets the script that returns if the action has failed.
        /// </summary>
        string[] FailureResultScript { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the key word to the agent's word bag.
        /// </summary>
        bool AddToWordBag { get; set; }
    }
}
