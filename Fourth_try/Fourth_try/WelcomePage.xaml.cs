using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Fourth_try
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
        public void Navi(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
