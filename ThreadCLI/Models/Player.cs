using ThreadCLI.Models.Interfaces;

namespace ThreadCLI.Models
{
    public class Player : IPlayer
    {
        /// <summary>
        /// Gets or sets the agent identifier.
        /// </summary>
        public string AgentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the agent.
        /// </summary>
        public string AgentName { get; set; }

        /// <summary>
        /// Gets or sets the player's experience points , if NULL experience points disabled.
        /// </summary>
        public int? ExperiencePoints { get; set; }

        /// <summary>
        /// Gets or sets the agent's hit points, if NULL hit points disabled.
        /// </summary>
        public int? HitPoints { get; set; }

        /// <summary>
        /// Gets or sets the agent's skill points, if NULL skill points disabled.
        /// </summary>
        public int? SkillPoints { get; set; }

        /// <summary>
        /// Gets or sets the agent's level, if NULL level disabled.
        /// </summary>
        public int? Level { get; set; }

        /// <summary>
        /// Gets or sets the agent's word bag, contains all usable words.
        /// </summary>
        public string[] WordBag { get; set; }
    }
}
