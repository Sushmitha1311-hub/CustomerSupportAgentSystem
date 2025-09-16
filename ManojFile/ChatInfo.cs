using System;
using System.Drawing;

namespace ChatDashboard
{
    public class ChatInfo
    {
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsSelf { get; set; }
        public Image Attachment { get; set; }

        public ChatInfo(string sender, string message, DateTime timestamp, bool isSelf, Image attachment = null)
        {
            Sender = sender;
            Message = message;
            Timestamp = timestamp;
            IsSelf = isSelf;
            Attachment = attachment;
        }
    }
}