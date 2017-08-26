using Spindle.Enumerations;

namespace Spindle.Models
{
    public class SceneAction
    {
        public string Keyword { get; set; }

        public Verbs Verb { get; set; }

        public string ActionScript { get; set; }

        public int? SceneTransition { get; set; }

        public string InventoryItem { get; set; }

        public string CheckCondition { get; set; }

        public bool CheckConditionInverted { get; set; }
    }
}
