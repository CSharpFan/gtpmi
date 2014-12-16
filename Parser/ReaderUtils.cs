namespace Parser
{
    using System;
    using System.IO;

    /// <summary>
    ///     Utility class to read certain properties of a file or bitmap
    /// </summary>
    public static class ReaderUtils
    {
        public static DateTime ReadLastModified(FileInfo fileInfo)
        {
            if (ReferenceEquals(null, fileInfo))
            {
                throw new ArgumentNullException("fileInfo");
            }

            return File.GetLastWriteTime(fileInfo.FullName);
        }
    }
}