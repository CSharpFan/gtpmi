namespace Parser
{
    using System;
    using System.IO;
    using MetaDataDotJson;

    internal class MetaDataDotJsonWithLocation
    {
        public FileInfo Location { get; private set; }
        public MetaData MetaData { get; private set; }

        public MetaDataDotJsonWithLocation(FileInfo location, MetaData metaData)
        {
            if (ReferenceEquals(null, location))
            {
                throw new ArgumentNullException("location");
            }
            if (!location.Exists)
            {
                throw new FileNotFoundException(string.Format("File that represents metaData not found at {0}", location));
            }
            if (ReferenceEquals(null, metaData))
            {
                throw new ArgumentNullException("metaData");
            }

            this.Location = location;
            this.MetaData = metaData;
        }
    }
}