using System.Collections.ObjectModel;

namespace MauiBindingDemo
{
    public partial class MainPage : ContentPage
    {
        public string CarModel { get; set; }
        public int CarAge { get; set; }

        public List<Car> CarList { get; set; } = new List<Car>();

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
