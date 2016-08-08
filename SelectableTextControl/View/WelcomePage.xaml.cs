using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SelectableTextControl.View
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            selectableEntry.Text = SelectableTextControl.Resources.Resources.SimpleText;
            
        }

        private async void SelectedText_OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Last selected text", App.SelectedText, "OK");
        }
    }
}
