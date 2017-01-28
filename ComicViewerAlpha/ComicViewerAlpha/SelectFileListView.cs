using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewerAlpha
{
    public class SelectFileListView : ContentPage
    {
        public SelectFileListView()
        {
            var width = MainMenu.width;
            var height = MainMenu.height;

            /*var prologue = new Image
            {
                //プロローグ
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };

            var prologueGR = new TapGestureRecognizer();
            prologue.GestureRecognizers.Add(prologueGR);

            var welcomeKST = new Image
            {
                //KSTへようこそ！
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var welcomeKSTGR = new TapGestureRecognizer();
            welcomeKST.GestureRecognizers.Add(welcomeKSTGR);

            var jouhou = new Image
            {
                //情報工学科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var jouhouGR = new TapGestureRecognizer();
            jouhou.GestureRecognizers.Add(jouhouGR);

            var electronics = new Image
            {
                //総合電機科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var electronicsGR = new TapGestureRecognizer();
            electronics.GestureRecognizers.Add(electronicsGR);

            var mechatronics = new Image
            {
                //電子機械科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var mechatronicsGR = new TapGestureRecognizer();
            mechatronics.GestureRecognizers.Add(mechatronicsGR);

            var kensetsu = new Image
            {
                //建設工学科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var kensetsuGR = new TapGestureRecognizer();
            kensetsu.GestureRecognizers.Add(kensetsuGR);

            var design = new Image
            {
                //デザイン科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var designGR = new TapGestureRecognizer();
            design.GestureRecognizers.Add(designGR);

            var science = new Image
            {
                //科学科
                WidthRequest = width * 0.5,
                Source = ImageSource.FromResource("ComicViewerAlpha.Image.SelectFileListView.ListView.png"),
            };
            var scienceGR = new TapGestureRecognizer();
            science.GestureRecognizers.Add(scienceGR);
            */

            var prologue = new Button
            {
                Text = "プロローグ"
            };
            var welcomeKST = new Button
            {
                Text = "KSTへようこそ！"
            };
            var jouhou = new Button
            {
                Text = "情報工学科"
            };
            var electronics = new Button
            {
                Text = "総合電機科"
            };
            var mechatronics = new Button
            {
                Text = "電子機械科"
            };
            var kensetsu = new Button
            {
                Text = "建設工学科"
            };
            var design = new Button
            {
                Text = "デザイン科"
            };
            var science = new Button
            {
                Text = "科学科"
            };

            //BackgroundImage = "KST.JPG";
            //Android:AndroidResourceとしてResources/drawableに追加
            //iOS:Resourcesにリンクとして追加
            //UWP:プロジェクト直下にリンクとして追加

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 20,
                
                Children =
                {   new Label
                    {
                        HorizontalTextAlignment= TextAlignment.Center,
                        FontSize = 25,
                        Text = "現在、「プロローグ」と「デザイン科」と「科学科」\nを読むことができます。"
                    },

                    prologue,
                    welcomeKST,
                    jouhou,
                    electronics,
                    mechatronics,
                    kensetsu,
                    design,
                    science,
                }
            };

            Content = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = stackLayout,
            };

            //prologueGR.Tapped += async (sender, e) =>
            prologue.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("prolouge", new[]
                {
                    "page1.png",
                    "page2.png",
                    "page3.png",
                    "page4.png",
                    "page5.png",
                    "page6.png",
                    "page7.png",
                    "page8.png",
                }));
            };

            welcomeKST.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "andmore.png"
                }));
            };
            jouhou.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "andmore.png"
                }));
            };
            electronics.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "andmore.png"
                }));
            };
            mechatronics.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "andmore.png"
                }));
            };
            kensetsu.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("Episode1", new[]
                {
                    "andmore.png"
                }));
            };
            design.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("design", new[]
                {
                    "page1.png",
                    "page2.png",
                    "page3.png",
                    "page4.png",
                    "page5.png",
                }));
            };
            science.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EpisodePage("science", new[]
                {
                    "page1.png",
                    "page2.png",
                    "page3.png",
                    "page4.png",
                    "page5.png",
                }));
            };
        }
    }
}
