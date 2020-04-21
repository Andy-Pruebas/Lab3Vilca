using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3V
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ScrollViewDemo();
            //MainPage = new GridDemo();
            //MainPage = new RelativeLayoutDemo();
            //MainPage = new AbsoluteLayoutDemo();
            //MainPage = new StackLayoutDemo();
            //MainPage = new MainPage();
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
