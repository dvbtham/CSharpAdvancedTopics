namespace AdvancedTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Title 1" };

            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();
            var textService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
