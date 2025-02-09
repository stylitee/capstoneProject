﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace doghavenCapstone.PreventerPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loading : ContentPage
    {
        public Loading()
        {
            InitializeComponent();
            lblLoadMessage.Text = App.loadingMessage;
            var assembly = typeof(Loading);

            imgLoading.Source = ImageSource.FromResource("doghavenCapstone.Assets.loading_gif_ini.gif",assembly);
        }
    }
}