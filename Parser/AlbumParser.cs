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
                // this is ONE file in the metadata. 
                // there might be a file with suffix '-edited'. 

                // sanity check, does the file exist we want? 
                var originalFile = Path.Combine(this._metaDataDirectory.FullName, media.Title);
                var originalFileExists = File.Exists(originalFile);

                // also check whether we have an -edited file. 
                // would be nice if we can 
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension( media.Title);
                const string dashEdited = "-edited";
                var extension = Path.GetExtension(media.Title);

                var editedFileName = string.Format("{0}{1}{2}", fileNameWithoutExtension, dashEdited, extension);

                var editedFileExists = File.Exists(Path.Combine(_metaDataDirectory.FullName, editedFileName));

                if (editedFileExists)
                {
                    // consider the following:
                    /*
                     * (a) Edited: -edited
                     * (b) Original: no -edited
                     * 
                     * However (a) contains the correct metadata (date taken, flash, iso)
                     * So we need to copy over that data to (b)
                     * If we don't have (a) we should be fine
                     */ 
                    
                }

                if (originalFileExists)
                {
                    System.Diagnostics.Debug.WriteLine("Date created: {0}", new FileInfo(originalFile).LastWriteTime);
                }
            }
        }
    }
}