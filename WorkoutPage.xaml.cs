namespace SportApp;
using Microsoft.Maui.Controls;
using System.Security.AccessControl;
using SQLite;
using System.Collections.ObjectModel;

public partial class TheWorkout : ContentPage
{
    public TheWorkout(Workout workout)
	{
        InitializeComponent();

        // ������������� ������ ���������� �� ��������
        WorkoutNameLabel.Text = workout.Name;
        WorkoutDescriptionLabel.Text = $"������: {workout.StartTime}";

        // ������ "�����"
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        // ������ "�������� ����������"

        addExerciseButton.Clicked += ToModalPage;

    }
    private async void ToModalPage(object? sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddExersciseModalPage());
    }
    void PickerSelectedIndexChanged(object sender, EventArgs e)
    {
        WorkoutDescriptionLabel.Text = $"�� �������: {WorkoutPicker.SelectedItem}";
        
    }
    
}