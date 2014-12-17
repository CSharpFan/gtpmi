namespace Parser.MetaDataDotJson
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    ///     Defines the root of the Meta Data, specifies the data about the album, (<see cref="AlbumData" />), and one or more files (<see cref="MetaDataDotJson.Media" />)
    /// </summary>
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MetaData
    {
        [JsonProperty("albumData")]
        public AlbumData AlbumData { get; set; }

        [JsonProperty("media")]
        public IReadOnlyCollection<Media> Media { get; set; }
    }
}