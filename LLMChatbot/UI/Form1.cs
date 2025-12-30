using System;
using System.Windows.Forms;
using LLMChatbot.Services;
using LLMChatbot.Models;

namespace LLMChatbot.UI
{
    public partial class Form1 : Form
    {
        private ChatService _chatService;

        public Form1()
        {
            InitializeComponent();

            // Z-ORDER + FOCUS GARANTÝ
            panelBottom.BringToFront();
            txtMessage.BringToFront();
            txtMessage.Focus();

            IChatbotEngine engine = new SimpleLLMEngine();
            _chatService = new ChatService(engine);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userText = txtMessage.Text.Trim();
            if (string.IsNullOrEmpty(userText))
                return;

            lstChat.Items.Add("Sen: " + userText);

            ChatMessage botMessage = _chatService.SendMessage(userText);
            lstChat.Items.Add("Bot: " + botMessage.Content);

            txtMessage.Clear();
            txtMessage.Focus();
        }
    }
}




