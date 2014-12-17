namespace Parser.MetaDataDotJson
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Media
    {
        [JsonProperty("tags")]
        // TODO decide whether this can be a string, unknown at the time
        public List<object> Tags { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("people")]
        public List<object> People { get; set; }

        [JsonProperty("comments")]
        public List<object> Comments { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("geoInfo")]
        public GeoInfo GeoInfo { get; set; }

        [JsonProperty("geoInfoExif")]
        public GeoInfoExif GeoInfoExif { get; set; }

        [JsonProperty("imageViews")]
        public int ImageViews { get; set; }

        [JsonProperty("licence")]
        public object License { get; set; }
    }
}