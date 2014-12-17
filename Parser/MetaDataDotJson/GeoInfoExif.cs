namespace Parser.MetaDataDotJson
{
    using Newtonsoft.Json;

    public class GeoInfoExif
    {
        [JsonProperty("latitude_")]
        public double Latitude { get; set; }

        [JsonProperty("longitude_")]
        public double Longitude { get; set; }

        [JsonProperty("altitude_")]
        public double Altitude { get; set; }

        [JsonProperty("latitude_span_")]
        public double LatitudeSpan { get; set; }

        [JsonProperty("longitude_span_")]
        public double LongitudeSpan { get; set; }

        [JsonProperty("uninterpreted")]
        public object Uninterpreted { get; set; }

        [JsonProperty("optional_0_")]
        public int Optional0 { get; set; }

        [JsonProperty("isMutable")]
        public bool IsMutable { get; set; }

        [JsonProperty("cachedSize")]
        public int CachedSize { get; set; }
    }
}