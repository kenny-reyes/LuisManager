using System.Collections.Generic;
using LuisManager.Domain.Enums;

namespace LuisManager.Domain
{
    public class LuisScheme
    {
        public string luis_schema_version { get; set; }
        public string versionId { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string culture { get; set; }

        public List<Intents> intents { get; set; }
        public List<Entities> entities { get; set; }
        public List<Composites> composites { get; set; }
        public List<ClosedLists> closedLists { get; set; }
        public List<string> bing_entities { get; set; }
        public List<Actions> actions { get; set; }
        public List<ModelFeatures> model_features { get; set; }
        public List<RegexFeatures> regex_features { get; set; }
        public List<Utterances> utterances { get; set; }

        public DevelopmentStatus Status { get; set; }
    }
}
