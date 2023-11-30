using System.Collections.ObjectModel;

namespace ZH2konzi
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Rotation> Rotations { get; set; }
            = new ObservableCollection<Rotation>();

        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();

            for(int i = 0; i < 10; i++)
            {
                Rotations.Add(new Rotation() { Degree = 5 * i });
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            foreach (var r in Rotations)
            {
                r.Degree += 10;
            }
        }

        public string CurrentDegreeRequest { get; set; }
        public Rotation CurrentlySelectedRotation { get; set; }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            int deg = int.Parse(CurrentDegreeRequest);
            CurrentlySelectedRotation.Degree = deg;
        }
    }
}