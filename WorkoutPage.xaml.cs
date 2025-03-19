namespace SportApp;
using Microsoft.Maui.Controls;
using System.Security.AccessControl;

public partial class TheWorkout : ContentPage
{
	public TheWorkout(Workout workout)
	{
        InitializeComponent();

        // ������������� ������ ���������� �� ��������
        WorkoutNameLabel.Text = workout.Name;
        WorkoutDescriptionLabel.Text = $"������: {workout.StartTime}";

        // ������ "�����"
        Button backButton = new Button { Text = "�����", HorizontalOptions = LayoutOptions.Start };
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        // ������ "�������� ����������"

        Button addExerciseButton = new Button { Text = "�������� ����������", HorizontalOptions = LayoutOptions.Start };
        addExerciseButton.Clicked += ToModalPage;


        // ��������� �������� �� ��������
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