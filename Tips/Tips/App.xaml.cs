using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Tips.Views;

namespace Tips
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new CalculatorPage();
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
