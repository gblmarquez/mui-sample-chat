using Caliburn.Micro;
using FirstFloor.ModernUI.Presentation;
using System.ComponentModel.Composition;

namespace MuiChat.App.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class SettingsViewModel : Screen
    {
        private string _statusMessage;
        private System.Uri _selectedSource = new System.Uri("/Views/SettingsAppearanceView.xaml", System.UriKind.Relative);

        public SettingsViewModel()
        {
            this.TabLinks = new LinkCollection(new Link[] { 
                new Link()
                {
                    DisplayName = "appearance",
                    Source = new System.Uri("/Views/SettingsAppearanceView.xaml", System.UriKind.Relative)
                },
                new Link()
                {
                    DisplayName = "about",
                    Source = new System.Uri("/Views/AboutView.xaml", System.UriKind.Relative)
                }
            });            
        }

        public LinkCollection TabLinks
        {
            get;
            set;
        }

        public System.Uri SelectedSource
        {
            get { return _selectedSource; }
            set
            {
                if (this._selectedSource != value)
                {
                    this._selectedSource = value;
                    this.NotifyOfPropertyChange("StatusMessage");
                }
            }
        }

    }
}
