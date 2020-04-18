using RadioButtonPlayground.Views;
using Xamarin.Forms;

namespace RadioButtonPlayground
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RadioButtonView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}