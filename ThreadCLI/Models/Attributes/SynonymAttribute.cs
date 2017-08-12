using System;

namespace ThreadCLI.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class SynonymAttribute : Attribute
    {
        private string synonyms;

        public string[] Synonyms { get; private set; }

        public SynonymAttribute(string synonyms)
        {
            this.synonyms = synonyms;

            if (!string.IsNullOrWhiteSpace(synonyms))
            {
                this.Synonyms = synonyms.Split(',');
            }
        }        
    }
}
