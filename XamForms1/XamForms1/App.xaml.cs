﻿using FreshMvvm;
using Xamarin.Forms;
using XamForms1.PageModels;

namespace XamForms1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            var tabbedNavigation = new FreshTabbedNavigationContainer ();
            tabbedNavigation.AddTab<MoviesPageModel> ("Movies", null);
            tabbedNavigation.AddTab<AboutPageModel> ("About", null);
            
            MainPage = tabbedNavigation;
            
            //MainPage = new XamForms1Page();
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