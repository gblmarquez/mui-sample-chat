using Caliburn.Micro;
using Matrix.Xmpp.Client;
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
        Matrix.Xmpp.Client.XmppClient xmppClient = new Matrix.Xmpp.Client.XmppClient();

        public void Connect()
        {
            xmppClient.OnRosterItem += xmppClient_OnRosterItem;
            xmppClient.OnMessage += xmppClient_OnMessage;
            xmppClient.OnPresence += xmppClient_OnPresence;
            xmppClient.OnReceiveBody += xmppClient_OnReceiveBody;
            xmppClient.OnSendBody += xmppClient_OnSendBody;
            xmppClient.OnError += xmppClient_OnError;

            xmppClient.SetUsername("gblmarquez");
            xmppClient.SetXmppDomain("gmail.com");
            xmppClient.Password = "qflksukjgcrbqxqx";

            xmppClient.AutoRoster = true;

            // disable SRV lookups and specify hostname manual
            xmppClient.ResolveSrvRecords = false;
            xmppClient.Hostname = "talk.google.com";

            xmppClient.Status = "I'm chatty";
            xmppClient.Show = Matrix.Xmpp.Show.chat;

            xmppClient.Open();
        }

        public void Send()
        {
            this.MessageTextBlock += string.Format("[b]me:[/b] {0}\n", this.SendTextBox);
            this.SendTextBox = string.Empty;

            this.NotifyOfPropertyChange("MessageTextBlock");
            this.NotifyOfPropertyChange("SendTextBox");
        }

        public string MessageTextBlock { get; set; }
        public string SendTextBox { get; set; }

        void xmppClient_OnError(object sender, Matrix.ExceptionEventArgs e)
        {

        }

        void xmppClient_OnSendBody(object sender, Matrix.Net.BodyEventArgs e)
        {

        }

        void xmppClient_OnReceiveBody(object sender, Matrix.Net.BodyEventArgs e)
        {
        }

        void xmppClient_OnPresence(object sender, Matrix.Xmpp.Client.PresenceEventArgs e)
        {
        }

        void xmppClient_OnMessage(object sender, Matrix.Xmpp.Client.MessageEventArgs e)
        {
        }

        void xmppClient_OnRosterItem(object sender, Matrix.Xmpp.Roster.RosterEventArgs e)
        {
        }
    }
}
