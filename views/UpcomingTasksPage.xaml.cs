using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace TaskManager.views
{
    public partial class UpcomingTasksPage : ContentPage
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public UpcomingTasksPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { Title = "Complete MAUI Project", DueDate = "2023-11-01" },
                new TaskItem { Title = "Submit Report", DueDate = "2023-11-05" },
                new TaskItem { Title = "Plan Next Sprint", DueDate = "2023-11-10" }
            };

            TasksListView.ItemsSource = Tasks; 
        }

        private async void OnAddTaskClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Add Task", "This is where you would add a new task!", "OK");
        }
    }

    public class TaskItem
    {
        public string Title { get; set; }
        public string DueDate { get; set; }
    }
}