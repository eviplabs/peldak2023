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
        }
    }
}