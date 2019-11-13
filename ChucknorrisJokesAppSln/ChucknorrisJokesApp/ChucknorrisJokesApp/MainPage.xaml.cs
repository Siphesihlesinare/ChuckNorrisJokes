using ChuckNorrisJokesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChucknorrisJokesApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new CategoryPage();
        }

        private async void JokeButton_Clicked(object sender, EventArgs e)
        {
            var jokeGenerator = new JokeGenerator();
            string joke = await jokeGenerator.GetRandomJoke();

            JokeLabel.Text = joke;

        }

        private async void CategoryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryPage());
            //var jokeGenerator = new JokeGenerator();
            //string categories = await jokeGenerator.GetRandomJoke();

            //JokeLabel.Text = categories;
            
        }
    }
}