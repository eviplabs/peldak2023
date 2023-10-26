namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public static readonly Color InitialButtonColor = Colors.Red;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            CounterBtn.BackgroundColor = Color.FromRgb(10*count % 255, count % 255, count % 255);
            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void AddNewButtonButton_Clicked(object sender, EventArgs e)
        {
            Button newButton = new Button()
            {
                Text = "Hello",
                BackgroundColor = InitialButtonColor
            };
            newButton.Clicked += OnHelloButtonClicked;

            ColorButtons.Children.Add(newButton);
        }

        private void OnHelloButtonClicked(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            senderButton.BackgroundColor = Colors.Aqua;

            var N = ColorButtons.Children.Count;
            for(int i = 0; i < N; i++)
            {
                var currentbutton = (Button)ColorButtons.Children[i];
                if (currentbutton == senderButton)
                    DisplayAlert("Button clicked", $"The {i}-th hello button was clicked", "OK");
            }
        }
    }
}