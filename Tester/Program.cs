namespace Tester
{
    using System;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Parser;

    internal static class Program
    {
        private static void Main(string[] args)
        {
            //    var bitmap = new Bitmap(@"D:\Personal\Kristof\Downloads\Takeout\Google Photos\2013-03-23\IMG_20130323_162645.jpg");

            //    foreach (var item in bitmap.PropertyItems)
            //    {
            //        Console.WriteLine("Id: {0}, Type: {1}, Value: {2}", item.Id, item.Type, item.Value);
            //    }

            StructureParser structureParser = new StructureParser(@"D:\Personal\Kristof\Downloads\Takeout\");

            var foo = structureParser.FindMetaDataDotJsonFiles();

            foreach (var pathName in foo.Where(e=>!e.Contains("- ")))
            {
                var bar = JsonConvert.DeserializeObject<MetaData>(string.Join("", File.ReadAllLines(pathName)));
            }

            Console.ReadLine();
        }
    }
}