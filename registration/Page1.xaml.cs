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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            singup.Clicked += Singup_Clicked;

        }

        private void Singup_Clicked(object sender, EventArgs e)
        {
            if (username.Text == null || email.Text == null || password.Text == null)
                DisplayAlert("error", "empty inputs!!", "ok");
            else
            {

                Class1 c = new Class1();
                c.username = username.Text;
                c.email = email.Text;
                c.passworld = password.Text;
                DisplayAlert("congrats", "registration succeeded", "ok");
            }
        }

    }
}