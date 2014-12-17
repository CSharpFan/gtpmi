namespace Parser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using MetaDataDotJson;
    using Newtonsoft.Json;

    /// <summary>
    ///     Recursivly finds all "metadata.json" files
    /// </summary>
    internal class DirectoryStructureParser
    {
        private readonly DirectoryInfo _baseDirectory;

        public DirectoryStructureParser(DirectoryInfo baseDirectory)
        {
            if (ReferenceEquals(null, baseDirectory))
            {
                throw new ArgumentNullException("baseDirectory");
            }

            this._baseDirectory = baseDirectory;
        }

        internal IEnumerable<Task<MetaDataDotJsonWithLocation>> FindMetaDataDotJsonFiles()
        {
            var fileInfos = this._baseDirectory.GetFiles("metadata.json", SearchOption.AllDirectories);

            return fileInfos.Select(DeserializeMetaDataAsync);
        }

        private static Task<MetaDataDotJsonWithLocation> DeserializeMetaDataAsync(FileInfo fileInfo)
        {
            return Task.Factory.StartNew(() =>
                                         {
                                             var jsonFile = File.ReadAllLines(fileInfo.FullName);

                                             return new MetaDataDotJsonWithLocation(fileInfo, JsonConvert.DeserializeObject<MetaData>(string.Join(string.Empty, jsonFile)));
                                         });
        }
    }
}