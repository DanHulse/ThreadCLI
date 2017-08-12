using System.Collections.Generic;
using ThreadCLI.Models.Enumerations;

namespace ThreadCLI.Models.Interfaces
{
    public interface ISceneAction
    {
        /// <summary>
        /// Gets or sets the verb that can be used on this action.
        /// </summary>
        Verb KeyWordVerb { get; set; }

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
        string SuccessResultScript { get; set; }

        /// <summary>
        /// Gets or sets the script that returns if the action has failed.
        /// </summary>
        string FailureResultScript { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to add the key word to the agent's word bag.
        /// </summary>
        bool AddToWordBag { get; set; }

        /// <summary>
        /// Gets or sets the scene number to navigate to, if NULL no new scene.
        /// </summary>
        int? NavigateToScene { get; set; }
    }
}
