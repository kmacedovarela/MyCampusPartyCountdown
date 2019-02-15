using CampusPartyCountdown.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CampusPartyCountdown
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationPage(new MyCampusPartyCountdownView());
        }

        protected override void OnStart()
        {
            base.OnStart();
	
        	AppCenter.Start("87e5ce5b-ca29-454d-9535-067725a96785",
                typeof(Analytics), typeof(Crashes));

        }
    }
}
