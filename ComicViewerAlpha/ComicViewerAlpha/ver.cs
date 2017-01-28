using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ComicViewerAlpha
{
    public class Ver : ContentPage
    {
        public Ver()
        {
            //変更内容の段落は半角８個分
            string ver1_0 = "16/11/30 Ver1.0 Release\n16/12/12\n";
            string ver1_1 = "16/12/12 Ver1.1 更新内容\n"+
                            "        ソースコード及び内部処理の簡略化\n"+
                            "        Aboutの追加\n"+
                            "        ボタン配置の変更及びサイズの調整\n";
            string ver1_2 = "16/12/18 Ver1.2 更新内容\n"+
                            "        エピソードページの表示切替の実装\n"+
                            "        エピソードページのデザインの修正\n"+
                            "        メインページのデザインの修正、画像の追加\n";
            string ver1_3 = "13/01/26 Ver1.3 更新内容\n" +
                            "        iOS10.2での動作確認\n" +
                            "        レイアウトの再変更\n" +
                            "        「プロローグ」の追加\n" +
                            "        「デザイン科」の追加\n";
            string ver1_4 = "13/01/28 Ver1.4 更新内容\n" +
                            "        iOS9.3での動作確認\n" +
                            "        iOS（iPad Pro 9.7)でのズームインの機能実装\n" +
                            "        「科学科」の追加";

            StackLayout stackLayout = new StackLayout
            {
                Spacing = 30,
                Children =
                {
                    new Label
                    { TextColor = Color.White, Text = "このアプリについて\n" + ver1_0 + ver1_1 + ver1_2 + ver1_3 + ver1_4 },
                    new Label
                    {
                        TextColor = Color.White,
                        Text = "動作確認端末及び環境\n"+
                             "SONY XPERIA Z5 Android6.0\n"+
                             "HUAWEI Media PAD 7 Lite Android4.0.3\n"+
                             "\niPad mini 1st gen iOS9.3\n"+
                             "iPad Pro 9.7 iOS10.2\n"+
                             "\nWindows10 AnniversaryUpdate"
                    }
                }
            };

            Content = new ScrollView
            {
                BackgroundColor = Color.Black,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Content = stackLayout,
            };
        }
    }
}