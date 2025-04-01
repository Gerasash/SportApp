namespace SportApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

        }
        private void OnSettingsClicked(object sender, EventArgs e)
        {
            DisplayAlert("Добавление", "Вы нажали кнопку добавить!", "OK");
        }
    }
}
