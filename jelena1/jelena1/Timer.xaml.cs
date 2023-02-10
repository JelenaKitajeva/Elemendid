using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jelena1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Timer : ContentPage
    {
        public Timer()
        {
            InitializeComponent();
        }
        bool on_off = true;
        public async void ShowTime()
        {
            while (on_off)
            {
                lb.Text = DateTime.Now.ToString("T");
                await Task.Delay(1000);
                
             }
    }

        private void btn_Clicked(object sender, EventArgs e)
        {
        if(on_off)
            {on_off = false;}
        else
            { on_off = true;
                ShowTime();
            }
        }
    }

}
