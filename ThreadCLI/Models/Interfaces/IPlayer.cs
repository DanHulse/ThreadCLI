namespace ThreadCLI.Models.Interfaces
{
    public interface IPlayer : IAgent
    {
        /// <summary>
        /// Gets or sets the player's experience points , if NULL experience points disabled.
        /// </summary>
        int? ExperiencePoints { get; set; }
    }
}