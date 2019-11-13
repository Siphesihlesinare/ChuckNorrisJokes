using ChuckNorrisJokesLibrary;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChucknorrisJokesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        //public List<Joke> categories { get; set; }

        //public CategoryPage()
        //{
        //    categories = new List<Joke>();
        //    categories.Add(new Joke
        //    {
        //        id = "Animal",
        
        //    }) ;
        //    return  ;
        //}
      
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
