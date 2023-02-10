using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jelena1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry_page : ContentPage
    {
        Editor ed;
        Button btn;
        Label lb;
        public Entry_page()
        {
            ed = new Editor
            {
                Placeholder = "Sisesta siia tekst",
                BackgroundColor = Color.White,
                TextColor = Color.Plum
            };
            ed.TextChanged += Ed_TextChanged;
            lb = new Label
            {
                Text = "Mingi tekst",
                TextColor = Color.Plum,
                BackgroundColor = Color.Violet
                
            };
            btn = new Button
            {
                Text ="Tagasi"
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { ed, btn, lb},
                BackgroundColor = Color.Blue
            };
            Content= st;
            btn.Clicked += Btn_Clicked;

        }
        int i = 0;
        private void Ed_TextChanged(object sender, TextChangedEventArgs e)
        {
            ed.TextChanged += Ed_TextChanged;
            char key = e.NewTextValue?.LastOrDefault() ?? ' ' ;
            if (key == 'A')
            {
                i++;
                lb.Text = key.ToString() + ": " + i;
            }
        }
        
        
        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
       
            

        
    }
}