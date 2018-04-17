namespace AdvancedTopics
{
    public class PhotoProcessor
    {
        // We can use  Action<> instead of create custom delegate.

        public delegate void PhotoFilterHandler(Photo photo);

        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
