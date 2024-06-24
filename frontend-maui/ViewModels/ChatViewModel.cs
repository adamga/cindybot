using CindyBotMaui.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace CindyBotMaui.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ChatMessage> _messages;
        public ObservableCollection<ChatMessage> Messages
        {
            get => _messages;
            set
            {
                _messages = value;
                OnPropertyChanged();
            }
        }

        public ChatViewModel()
        {
            Messages = new ObservableCollection<ChatMessage>();
        }

        public async Task SendMessage(string message)
        {
            // Simulate sending a message and receiving a response
            Messages.Add(new ChatMessage { Sender = "You", Message = message, Timestamp = System.DateTime.Now });

            // Simulate a delay to mimic network latency
            await Task.Delay(1000);

            // Simulate receiving a response
            Messages.Add(new ChatMessage { Sender = "Bot", Message = "Echo: " + message, Timestamp = System.DateTime.Now });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
