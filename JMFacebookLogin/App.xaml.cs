using JMFacebookLogin.View;
using Xamarin.Forms;

namespace JMFacebookLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new JMFacebookLoginPage();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
