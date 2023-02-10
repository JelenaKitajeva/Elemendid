using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jelena1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            //InitializeComponent();
            Button Entry_btn = new Button
            {
                Text="Ava Entry leht",
                TextColor=Color.Tomato,
                BackgroundColor=Color.BlueViolet
            };
            Button Timer_btn = new Button
            {
                Text = "Timer",
                TextColor = Color.Tomato,
                BackgroundColor = Color.BlueViolet
            };
            Button Box_btn = new Button
            {
                Text = "Box",
                TextColor = Color.Tomato,
                BackgroundColor = Color.BlueViolet
            };
            StackLayout st = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children = { Entry_btn, Timer_btn, Box_btn },
                BackgroundColor = Color.Pink

            };
            Content = st;
            Entry_btn.Clicked += Entry_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            Box_btn.Clicked += Box_btn_Clicked;
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_page());
        }

        private async void Entry_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_page());
        }
        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }
    }
}