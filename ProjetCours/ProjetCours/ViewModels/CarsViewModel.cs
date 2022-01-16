using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ProjetCours.Models;

namespace ProjetCours.ViewModels
{
    public class CarsViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Car> items;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Car> Items
        {
            get { return items; }
            set
            {

                items = value;
            }
        }


        public CarsViewModel()
        {
            Items = new ObservableCollection<Car>() {
                new Car()
                {
                    CarID = 1,
                    Make = "Tesla Model S",
                    YearOfModel = 2015
                },
                new Car()
                {
                    CarID = 2,
                    Make = "Audi R8",
                    YearOfModel = 2012
                },
                new Car()
                {
                    CarID = 3,
                    Make = "Peugeot 208",
                    YearOfModel = 2021
                },
                new Car()
                {
                    CarID = 4,
                    Make = "Renault Clio",
                    YearOfModel = 2018
                },
                new Car()
                {
                    CarID = 5,
                    Make = "Toyota Yaris",
                    YearOfModel = 2008
                },

            };

        }
    }
}

