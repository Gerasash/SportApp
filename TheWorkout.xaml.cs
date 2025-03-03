namespace SportApp;
using Microsoft.Maui.Controls;
public partial class TheWorkout : ContentPage
{
	public TheWorkout(Workout workout)
	{
        InitializeComponent();

        // Устанавливаем данные тренировки на странице
        WorkoutNameLabel.Text = workout.Name;
        WorkoutDescriptionLabel.Text = $"Начало: {workout.StartTime}";

        // Кнопка "Назад"
        Button backButton = new Button { Text = "Назад", HorizontalOptions = LayoutOptions.Start };
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();

        // Добавляем элементы на страницу
        Content = new StackLayout
        {
            Children = { WorkoutNameLabel, WorkoutDescriptionLabel, backButton }
        };

        /*Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
        //  переход с обычной страницы назад
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, backButton } };*/
    }
}