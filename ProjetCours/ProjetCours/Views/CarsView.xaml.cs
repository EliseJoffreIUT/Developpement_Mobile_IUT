using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ProjetCours.Models;
using ProjetCours.ViewModels;
using Xamarin.Forms;

namespace ProjetCours.Views
{
    public partial class CarsView : ContentView
    {
        public CarsView()
        {
            InitializeComponent();
            BindingContext = new CarsViewModel();
        }
    }
}
