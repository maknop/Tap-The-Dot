﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace TapTheDot
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("music1.mp3");
            player.Play();
            ninja.ImageSource = (FileImageSource)ImageSource.FromFile("ninja.png");
        }
        
        void Handle_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomePage();
        }

    }
}
