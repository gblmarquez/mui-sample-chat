using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace MuiChat.App.ViewModels
{
    [Export]
    public class ChatViewModel : Screen
    {
        public void Send()
        {
            this.MessageTextBlock += string.Format("[b]me:[/b] {0}\n", this.SendTextBox);
            this.SendTextBox = string.Empty;

            this.NotifyOfPropertyChange("MessageTextBlock");
            this.NotifyOfPropertyChange("SendTextBox");
        }

        public string MessageTextBlock { get; set; }
        public string SendTextBox { get; set; }
    }
}
