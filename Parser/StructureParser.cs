namespace Parser
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StructureParser
    {
        private readonly DirectoryInfo _baseDirectory;

        public StructureParser(string baseDirectory)
            : this(new DirectoryInfo(baseDirectory))
        {
        }

        private StructureParser(DirectoryInfo baseDirectory)
        {
            if (ReferenceEquals(null, baseDirectory))
            {
                throw new ArgumentNullException("baseDirectory");
            }

            this._baseDirectory = baseDirectory;
        }

        public IReadOnlyCollection<string> FindMetaDataDotJsonFiles()
        {
            return this._baseDirectory.GetFiles("metadata.json", SearchOption.AllDirectories)
                .Select(e => e.FullName)
                .ToList();
        }
    }
}