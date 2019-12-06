using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            singUp.Clicked += SingUp_Clicked;

        }

        private void SingUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1()) ;
        }

    }
}