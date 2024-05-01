namespace AndroidNavBug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Routing.RegisterRoute("page2", typeof(Page2));
        }
    }
}
