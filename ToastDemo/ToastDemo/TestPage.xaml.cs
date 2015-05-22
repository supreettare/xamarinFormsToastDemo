using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ToastDemo
{
    using Toasts.Forms.Plugin.Abstractions;

    public partial class TestPage : ContentPage
    {
        private IToastNotificator notificator; 
        public TestPage()
        {
            InitializeComponent();
            
            // Get hold of the Toast notifier
            notificator = DependencyService.Get<IToastNotificator>();
        }

        public async void OnShowClick(object sender, EventArgs e)
        {
            
            
            // Show Toast to wait for 12 seconds
            notificator.Notify(
                ToastNotificationType.Info,
                "Please wait",
                "Getting your location..",
                TimeSpan.FromSeconds(25));

            // Sleep for a while 
           // Device.StartTimer(new TimeSpan(5000), this.OnComplete);
        }

        private bool OnComplete()
        {
            return false; 
        }

        public async void OnHideClick(object sender, EventArgs e)
        {
            // Kill the notificator 
            notificator.HideAll();
        }
    }
}
