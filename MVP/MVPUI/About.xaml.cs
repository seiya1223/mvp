﻿using Microsoft.Mvp.Helpers;
using Microsoft.Mvpui.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Microsoft.Mvpui
{
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();

            btnCancel.Source = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1}", CommonConstants.BaseResourcePath, "Cancel.png");

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += OnCloseClicked;
            btnCancel.GestureRecognizers.Add(tapGestureRecognizer);
        }

        public async void OnCloseClicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new Settings());

            await Navigation.PopModalAsync(true);
        }
    }
}
