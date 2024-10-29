namespace InvalidXAML;

public partial class MainPage : ContentPage
{
    int count = 0;

    public string Headline { get; private set; }

    public MainPage()
    {
        InitializeComponent();
        Headline = "Hello, World!";
        BindingContext = this;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

