using System;

namespace AdvancedTopics
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: Sending an email... | Video: "+ args.Video.Title);
        }
    }
}