using ChuckNorrisJokesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChucknorrisJokesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public string[] Categories { get; set; }

        public CategoryPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var jokeGen = new JokeGenerator();

            Categories = await jokeGen.GetCategories();

            BindingContext = this;
        }
    }
}