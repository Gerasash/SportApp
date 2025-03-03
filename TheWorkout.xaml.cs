namespace SportApp;
using Microsoft.Maui.Controls;
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

        // ��������� �������� �� ��������
        Content = new StackLayout
        {
            Children = { WorkoutNameLabel, WorkoutDescriptionLabel, backButton }
        };

        /*Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };
        Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
        //  ������� � ������� �������� �����
        backButton.Clicked += async (o, e) => await Navigation.PopAsync();
        Content = new StackLayout { Children = { label, backButton } };*/
    }
}