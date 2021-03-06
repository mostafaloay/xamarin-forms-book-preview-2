﻿using System;
using Xamarin.Forms;

namespace ColorCodedStudents
{
    public class App : Application
    {
        public App()
        {
            Xamarin.FormsBook.Toolkit.Toolkit.Init();
            ElPasoHighSchool.Library.Init();

            MainPage = new ColorCodedStudentsPage();
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
