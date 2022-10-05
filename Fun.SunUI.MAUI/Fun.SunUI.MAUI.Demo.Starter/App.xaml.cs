namespace Fun.SunUI.MAUI.Demo.Starter
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            MainPage = Fun.SunUI.MAUI.Demo.Main.Create(serviceProvider);
        }
    }
}