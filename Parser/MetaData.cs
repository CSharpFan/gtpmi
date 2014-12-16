namespace Parser
{
    using System;
    using System.Collections.Generic;
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

    public class GeoInfo
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

    public class Medium
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

    /// <summary>
    ///     Defines the root of the Meta Data, specifies the data about the album, (<see cref="AlbumData" />), and one or more files (<see cref="Medium" />)
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MetaData
    {
        [JsonProperty("albumData")]
        public AlbumData AlbumData { get; set; }

        [JsonProperty("media")]
        public List<Medium> Media { get; set; }
    }
}