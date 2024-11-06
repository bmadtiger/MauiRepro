using System.Text.RegularExpressions;

namespace ThemeSwitcher;

public partial class MainPage : ContentPage
{
    public const string USER_SELECTED_STATE = "UserSelected";
    public const string NOT_SELECTED_STATE = "NotSelected";

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            bool selected = VisualStateManager.GoToState(clickedButton, USER_SELECTED_STATE);

            foreach (Button otherButton in this.ButtonStack.Children.OfType<Button>())
            {
                if (otherButton != clickedButton)
                {
                    bool unselected = VisualStateManager.GoToState(otherButton, NOT_SELECTED_STATE);
                }
            }
        }
    }
}

