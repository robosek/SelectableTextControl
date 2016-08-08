using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using SelectableTextControl;
using Xamarin.Forms;
using SelectableTextControl.CustomControls;
using SelectableTextControl.Droid.CustomRenderes;
using Android.Graphics.Drawables;
using System.Threading.Tasks;

[assembly: ExportRenderer(typeof(SelectableEntry), typeof(SelectableTextRenderer))]
namespace SelectableTextControl.Droid.CustomRenderes
{
    public class SelectableTextRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(Android.Graphics.Color.Black);
                Control.SetTextSize(Android.Util.ComplexUnitType.Px, 40);
                Control.SetRawInputType(Android.Text.InputTypes.Null);
                Control.SetTextIsSelectable(true);
                Control.FocusChange += (sender, ev) =>
                {
                    int start = Control.SelectionStart;
                    int end = Control.SelectionEnd;
                    SetSelectedTextToGlobal(start, end);
                };
                

            }
        }

        private void SetSelectedTextToGlobal(int start, int end)
        {
            if(ControlIsNotNullAndEmpty())
            {
                string text = Control.Text;
                text = text.Substring(start, end-start);
                App.SelectedText = text;
            }
        }

        private bool ControlIsNotNullAndEmpty()
        {
            return Control?.Text?.Length > 0;
        }

     


    }
}