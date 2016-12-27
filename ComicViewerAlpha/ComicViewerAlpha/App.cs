using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ComicViewerAlpha
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var mp = new NavigationPage(new MainMenu())     //MainMenu�ɉ�ʐ���
            {
                Title = "�i�r�Q�[�V���� �X�^�b�N",
                // �i�r�Q�[�V�����o�[ TextColor
                BarTextColor = Color.White,
                // �i�r�Q�[�V�����o�b�N�O�����h�o�[�J���[
                BarBackgroundColor = Color.Black
            };

            // The root page of your application
            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
