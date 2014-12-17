namespace Parser.MetaDataDotJson
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    ///     Represents the info of an album
    /// </summary>
    public class AlbumData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("access")]
        public string Access { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("geoInfo")]
        public object GeoInfo { get; set; }
    }
}