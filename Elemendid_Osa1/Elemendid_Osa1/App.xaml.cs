using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid_Osa1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new maakonnad();
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
