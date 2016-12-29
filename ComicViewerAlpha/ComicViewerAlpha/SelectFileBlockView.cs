using ComicViewerAlpha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewerAlpha
{
    public class SelectFileBlockView : ContentPage
    {
        public SelectFileBlockView()
        {
            var width = MainMenu.width;
            var height = MainMenu.height;

            var prologue = new Image
            {
                //プロローグ
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var prologueGR = new TapGestureRecognizer();
            prologue.GestureRecognizers.Add(prologueGR);

            var welcomeKST = new Image
            {
                //KSTへようこそ！
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var welcomeKSTGR = new TapGestureRecognizer();
            welcomeKST.GestureRecognizers.Add(welcomeKSTGR);

            var jouhou = new Image
            {
                //情報工学科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var jouhouGR = new TapGestureRecognizer();
            jouhou.GestureRecognizers.Add(jouhouGR);

            var electronics = new Image
            {
                //総合電機科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var electronicsGR = new TapGestureRecognizer();
            electronics.GestureRecognizers.Add(electronicsGR);

            var mechatronics = new Image
            {
                //電子機械科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var mechatronicsGR = new TapGestureRecognizer();
            mechatronics.GestureRecognizers.Add(mechatronicsGR);

            var kensetsu = new Image
            {
                //建設工学科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var kensetsuGR = new TapGestureRecognizer();
            kensetsu.GestureRecognizers.Add(kensetsuGR);

            var design = new Image
            {
                //デザイン科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var designGR = new TapGestureRecognizer();
            design.GestureRecognizers.Add(designGR);

            var science = new Image
            {
                //科学科
                WidthRequest = width * 0.4,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileBoxView.test.png"),
            };
            var scienceGR = new TapGestureRecognizer();
            science.GestureRecognizers.Add(scienceGR);

            BackgroundImage = "KST.JPG";
            //Android:AndroidResourceとしてResources/drawableに追加
            //iOS:Resourcesにリンクとして追加
            //UWP:プロジェクト直下にリンクとして追加

            var block1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                
                Spacing = 10,
                Children =
                {
                    prologue,
                    welcomeKST,
                }
            };
            var block2 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Spacing = 10,
                Children =
                {
                    jouhou,
                    electronics,
                }
            };
            var block3 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Spacing = 10,
                Children =
                {
                    mechatronics,
                    kensetsu,
                }
            };
            var block4 = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Spacing = 10,
                Children =
                {
                    design,
                    science,
                }
            };

            StackLayout stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                
                Children =
                {
                  new Label {Text = "BlockView" },
                  block1,
                  block2,
                  block3,
                  block4,
                }
            };
            BackgroundColor = Color.Black;

            Content = new ScrollView
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Content = stackLayout,
            };

            prologueGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png"
                }));
            };

            welcomeKSTGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                }));
            };
            jouhouGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                }));
            };
            electronicsGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                }));
            };
            mechatronicsGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                }));
            };
            kensetsuGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                }));
            };
            designGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                    "Screenshot.png",
                }));
            };
            scienceGR.Tapped += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "Screenshot.png",
                }));
            };
        }
    }
}
