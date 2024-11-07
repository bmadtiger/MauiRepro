using System.Text.RegularExpressions;

namespace ThemeSwitcher;

public partial class MainPage : ContentPage
{
    public const string USER_SELECTED_STATE = "UserSelected";
    public const string NOT_SELECTED_STATE = "NotSelected";
    public const string DARK_THEME_NAME = nameof(AppTheme.Dark);
    public const string LIGHT_THEME_NAME = nameof(AppTheme.Light);

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is Button clickedButton)
        {
            VisualStateManager.GoToState(clickedButton, USER_SELECTED_STATE);

            foreach (Button otherButton in this.ButtonStack.Children.OfType<Button>())
            {
                if (otherButton != clickedButton)
                {
                    VisualStateManager.GoToState(otherButton, NOT_SELECTED_STATE);
                }
            }

            Application.Current.UserAppTheme = clickedButton.Text switch
            {
                DARK_THEME_NAME => AppTheme.Dark,
                LIGHT_THEME_NAME => AppTheme.Light,
                _ => AppTheme.Unspecified,
            };
        }
    }
}

