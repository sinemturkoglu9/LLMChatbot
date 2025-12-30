namespace LLMChatbot.Services
{
    public class SimpleLLMEngine : IChatbotEngine
    {
        public string GenerateResponse(string userMessage)
        {
            userMessage = userMessage.ToLower();

            if (userMessage.Contains("merhaba"))
                return "Merhaba 👋";

            if (userMessage.Contains("nasılsın"))
                return "İyiyim 😄 Sen?";

            if (userMessage.Contains("c#"))
                return "C# nesne tabanlı bir programlama dilidir.";

            return "Bunu anlayamadım 🤖";
        }
    }
}

