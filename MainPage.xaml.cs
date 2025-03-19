
using System.Collections.ObjectModel;
using System.Security.AccessControl;
using Microsoft.Maui.Controls;

namespace SportApp
{
    public partial class MainPage : ContentPage
    {
        // Коллекция для хранения тренировок
        public ObservableCollection<Workout> Workouts { get; set; } = new ObservableCollection<Workout>();

        public MainPage()
        {
            InitializeComponent();

            // Привязка данных к ListView
            WorkoutListView.ItemsSource = Workouts;
            // Добавляем обработчик события выбора тренировки
            WorkoutListView.ItemSelected += OnWorkoutSelected;
        }

        // Обработчик нажатия на кнопку "Добавить тренировку"
        private void OnAddWorkoutClicked(object sender, System.EventArgs e)
        {
            string workoutName = WorkoutNameEntry.Text;

            if (workoutName == null) {
                workoutName = "";
            }
            // Добавляем новую тренировку в коллекцию
            Workouts.Add(new Workout(workoutName));


            // Очищаем поле ввода
            WorkoutNameEntry.Text = string.Empty;

        }

        // Обработчик события выбора тренировки
        private async void OnWorkoutSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var selectedWorkout = e.SelectedItem as Workout;

            // Переход на страницу TheWorkout с передачей данных
            await Navigation.PushAsync(new TheWorkout(selectedWorkout));

            // Сброс выбора
            WorkoutListView.SelectedItem = null;

        }
        //для перехода на ToTheWorkout
        /*private async void ToTheWorkout(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new TheWorkout());
        }*/
        private async void OnDeleteWorkoutClicked(object sender, EventArgs e)
        {
            // Получаем выбранную тренировку из CommandParameter
            var menuItem = sender as MenuItem;
            var workout = menuItem.CommandParameter as Workout;

            if (workout == null)
                return;

            // Запрос подтверждения удаления
            bool result = await DisplayAlert("Удаление", $"Удалить тренировку '{workout.Name}'?", "Да", "Нет");

            if (result)
            {
                Workouts.Remove(workout);
            }
        }
        // Модель тренировки
        
    }
}