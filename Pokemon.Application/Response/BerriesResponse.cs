namespace Pokemon.Application.Response
{
    public class BerriesResponseData
    {
        public List<BerriesResponse> Berries { get; set; }
        public string Name { get; set; }
    }

    public class BerriesResponse
    {
        public BerryResponse Berry { get; set; }
    }

    public class BerryResponse
    {
        public string Name { get; set; }
        public string url { get; set; }
    }
}
