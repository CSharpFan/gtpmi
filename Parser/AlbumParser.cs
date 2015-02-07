namespace Parser
{
    using System;
    using System.IO;
    using MetaDataDotJson;

    internal class AlbumParser
    {
        private readonly MetaData _metaData;
        private readonly DirectoryInfo _outputDirectory;
        private readonly DirectoryInfo _metaDataDirectory;

        public AlbumParser(MetaDataDotJsonWithLocation metaDataDotJsonWithLocation, DirectoryInfo outputDirectory)
        {
            if (ReferenceEquals(null, metaDataDotJsonWithLocation))
            {
                throw new ArgumentNullException("metaDataDotJsonWithLocation");
            }

            if (ReferenceEquals(null, outputDirectory))
            {
                throw new ArgumentNullException("outputDirectory");
            }


            this._metaData = metaDataDotJsonWithLocation.MetaData;
            this._metaDataDirectory = metaDataDotJsonWithLocation.Location.Directory;
            this._outputDirectory = outputDirectory;
        }

        public async void Parse()
        {
            foreach (var media in this._metaData.Media)
            {

            }
        }
    }
}