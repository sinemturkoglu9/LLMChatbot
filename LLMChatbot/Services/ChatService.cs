using System.Collections.Generic;
using LLMChatbot.Models;

namespace LLMChatbot.Services
{
    public class ChatService
    {
        private readonly IChatbotEngine _engine;
        public List<ChatMessage> Messages { get; } = new();

        public ChatService(IChatbotEngine engine)
        {
            _engine = engine;
        }

        public ChatMessage SendMessage(string text)
        {
            Messages.Add(new ChatMessage(MessageRole.User, text));
            var response = _engine.GenerateResponse(text);
            var botMsg = new ChatMessage(MessageRole.Bot, response);
            Messages.Add(botMsg);
            return botMsg;
        }
    }
}


