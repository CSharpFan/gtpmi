namespace Tester
{
    using System;
    using System.Drawing;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var bitmap = new Bitmap(@"c:\temp\photo.jpg");

            foreach (var item in bitmap.PropertyItems)
            {
                Console.WriteLine("Id: {0}, Type: {1}, Value: {2}", item.Id, item.Type, item.Value);
            }

            Console.ReadLine();
        }
    }
}