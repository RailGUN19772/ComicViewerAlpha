using System;
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

            var width = MainMenu.width;

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Vertical,
            };

            foreach (var s in files)
                stackLayout.Children.Add(new Image
                {
                    Aspect = Aspect.AspectFill,
                    Source = ImageSource.FromResource($"ComicViewerAlpha.EpisodeImage.{episodeName}.{s}")
                });

            Content = new ScrollView
            {
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,
                
                Content = stackLayout,
            };
        }
    }
}