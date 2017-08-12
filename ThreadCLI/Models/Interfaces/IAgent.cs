namespace ThreadCLI.Models.Interfaces
{
    public interface IAgent
    {
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        string AgentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the agent.
        /// </summary>
        string AgentName { get; set; }

        /// <summary>
        /// Gets or sets the agent's hit points, if NULL hit points disabled.
        /// </summary>
        int? HitPoints { get; set; }

        /// <summary>
        /// Gets or sets the agent's skill points, if NULL skill points disabled.
        /// </summary>
        int? SkillPoints { get; set; }

        /// <summary>
        /// Gets or sets the agent's level, if NULL level disabled.
        /// </summary>
        int? Level { get; set; }

        /// <summary>
        /// Gets or sets the agent's word bag, contains all usable words.
        /// </summary>
        string[] WordBag { get; set; }
    }
}
