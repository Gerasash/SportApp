namespace SportApp;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}
    void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            // �������� ����� ����
            App.Current.UserAppTheme = AppTheme.Dark;
            Preferences.Set("AppTheme", "Dark");
        }
        else
        {
            // �������� ������� ����
            App.Current.UserAppTheme = AppTheme.Light;
            Preferences.Set("AppTheme", "Light");
        }
        // Perform required operation after examining e.Value
    }
}