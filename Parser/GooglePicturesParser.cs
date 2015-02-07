namespace Parser
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public class GooglePicturesParser
    {
        private readonly DirectoryInfo _inputDirectory;
        private readonly DirectoryInfo _outputDirectory;

        public GooglePicturesParser(string inputDirectoryPath, string outputDirectoryPath)
        {
            if (ReferenceEquals(null, inputDirectoryPath))
            {
                throw new ArgumentNullException("inputDirectoryPath");
            }
            if (ReferenceEquals(null, outputDirectoryPath))
            {
                throw new ArgumentNullException("outputDirectoryPath");
            }

            this._inputDirectory = new DirectoryInfo(inputDirectoryPath);

            if (!this._inputDirectory.Exists)
            {
                throw new DirectoryNotFoundException(string.Format("inputDirectoryPath doesn't exist at {0}", inputDirectoryPath));
            }

            this._outputDirectory = new DirectoryInfo(outputDirectoryPath);

            if (!this._outputDirectory.Exists)
            {
                this._outputDirectory.Create(); // create it now, if it can't, we can fail early
            }
        }


        public async Task ParseGooglePicturesAsync()
        {
            // read all the json files in the input directory
            var directoryStructureParser = new DirectoryStructureParser(this._inputDirectory);

            foreach (var metaDataDotJsonTask in directoryStructureParser.FindMetaDataDotJsonFiles())
            {
                var metaDataDotJson = await metaDataDotJsonTask;

                var albumParser = new AlbumParser(metaDataDotJson, this._outputDirectory);

                albumParser.Parse();
            }
        }
    }
}