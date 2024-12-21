namespace TaskManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); // Set AppShell as MainPage  
        }
    }
}