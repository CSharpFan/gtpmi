namespace Tester
{
    using System;
    using Parser;

    internal static class Program
    {
        private static async void Main(string[] args)
        {
            //    var bitmap = new Bitmap(@"D:\Personal\Kristof\Downloads\Takeout\Google Photos\2013-03-23\IMG_20130323_162645.jpg");

            //    foreach (var item in bitmap.PropertyItems)
            //    {
            //        Console.WriteLine("Id: {0}, Type: {1}, Value: {2}", item.Id, item.Type, item.Value);
            //    }

            //DirectoryStructureParser structureParser = new DirectoryStructureParser(@"D:\d\Downloads\Takeout\");

            //var foo = structureParser.FindMetaDataDotJsonFiles();

            //foreach (var pathName in foo)
            //{
            //    var uri = new Uri(pathName);
            //    var bar = JsonConvert.DeserializeObject<MetaData>(string.Join("", File.ReadAllLines(uri.AbsolutePath)));
            //}

            GooglePicturesParser pdp = new GooglePicturesParser(@"e:\Takeout", @"e:\TakeoutParsed");

            pdp.ProgressReporter += PdpProgressReporter;

            await pdp.ParseGooglePicturesAsync();


            Console.ReadLine();
        }

        private static void PdpProgressReporter(byte progress)
        {
            // handle progress
        }
    }
}