using Microsoft.Maui.Controls;
namespace SportApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        private void ToolbarItem1_Clicked(object sender, EventArgs e)
        {
            // Обработчик для действия 1
        }

        private void ToolbarItem2_Clicked(object sender, EventArgs e)
        {
            // Обработчик для действия 2
        }

    }
}