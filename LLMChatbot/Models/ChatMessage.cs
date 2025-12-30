using System;

namespace LLMChatbot.Models
{
    public enum MessageRole
    {
        User,
        Bot
    }

    public class ChatMessage
    {
        public MessageRole Role { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public ChatMessage(MessageRole role, string content)
        {
            Role = role;
            Content = content;
            Time = DateTime.Now;
        }
    }
}

