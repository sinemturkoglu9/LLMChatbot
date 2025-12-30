using System;
using System.Windows.Forms;
using LLMChatbot.UI;

namespace LLMChatbot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

