﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace registration
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Page2();

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
