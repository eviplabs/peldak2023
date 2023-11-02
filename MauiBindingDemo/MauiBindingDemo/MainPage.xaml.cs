using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MauiBindingDemo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string _carModel;
        public string CarModel
        {
            get { return _carModel; }
            set
            {
                if (_carModel != value)
                {
                    _carModel = value;
                    OnPropertyChanged(nameof(CarModel));
                }
            }
        }

        private int _carAge;
        public int CarAge
        {
            get { return _carAge; }
            set
            {
                if (_carAge != value)
                {
                    _carAge = value;
                    OnPropertyChanged(nameof(CarAge));
                }
            }
        }

        public ObservableCollection<Car> CarList { get; set; } = new ObservableCollection<Car>();

        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
        }

        private void OnAddItemClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CarModel))
                CarList.Add(new Car() { Model = CarModel, Age = CarAge });
        }

        private void ResetEntriesButtonClicked(object sender, EventArgs e)
        {
            CarModel = "Ford Focus";
            CarAge = 1;
        }
    }
}
