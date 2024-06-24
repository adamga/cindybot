using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace CindyBotMaui
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Messages { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Messages = new ObservableCollection<string>();
            BindingContext = this;
        }

        private async void OnSendMessage(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MessageEntry.Text))
            {
                Messages.Add($"You: {MessageEntry.Text}");
                var response = await ChatService.SendMessageAsync(MessageEntry.Text);
                Messages.Add($"Bot: {response}");
                MessageEntry.Text = string.Empty;
                ChatScrollView.ScrollTo(Messages.Count - 1, position: ScrollToPosition.End, animate: true);
            }
        }
    }
}
