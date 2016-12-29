﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewerAlpha
{
    public class EpisodePage : ContentPage
    {
        public EpisodePage(string episodeName,string[] files)
        {
                                    
            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Vertical,
            };

            foreach (var s in files)
                stackLayout.Children.Add(new Image
                {
                    Source = ImageSource.FromResource($"ComicViewerAlpha.EpisodeImage.{episodeName}.{s}")
                });

            Content = new ScrollView
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout,
            };
        }
    }
}