using System;

namespace AdvancedTopics
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message... | Video: " + args.Video.Title);
        }
    }
}