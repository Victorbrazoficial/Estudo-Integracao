using Newtonsoft.Json;

namespace Pokemon.Infrastructure.HTTPClients.ApiObjects
{
    public class BerriesApiObject
    {
        public List<Berries>? Berries { get; set; }
        [JsonProperty("contest_type")]
        public ContestType ContestType { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Names> Names { get; set; }
    }

    public class Berries
    {
        public Berry Berry { get; set; }
        public int Potency { get; set; }
    }

    public class Berry
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class ContestType
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }

    public class Names
    {
        public Language Language { get; set; }
        public string Name { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
