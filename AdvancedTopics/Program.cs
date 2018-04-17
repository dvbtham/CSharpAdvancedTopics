using System;

namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var photoFilter = new PhotoFilters();

            PhotoProcessor.PhotoFilterHandler filterHandler = photoFilter.ApplyBrightness;
            filterHandler += photoFilter.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("/", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
