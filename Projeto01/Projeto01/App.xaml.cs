using Projeto01.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TelaPrincipal();
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
