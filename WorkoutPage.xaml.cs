namespace SportApp;
using Microsoft.Maui.Controls;
using System.Security.AccessControl;

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
        // Кнопка "Добавить упражнение"

        Button addExerciseButton = new Button { Text = "Добавить упражнение", HorizontalOptions = LayoutOptions.Start };
        addExerciseButton.Clicked += ToModalPage;


        // Добавляем элементы на страницу
        Content = new StackLayout
        {
            Children = { WorkoutNameLabel, WorkoutDescriptionLabel, backButton, addExerciseButton }
        };

    }
    private async void ToModalPage(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddExersciseModalPage());
    }
    private async void ToCommonPage(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}