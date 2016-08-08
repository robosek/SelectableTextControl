using SelectableTextControl.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SelectableTextControl
{
    public class App : Application
    {
        public static string SelectedText { get; set; }

        public App()
        {
            MainPage = new WelcomePage();
            
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
