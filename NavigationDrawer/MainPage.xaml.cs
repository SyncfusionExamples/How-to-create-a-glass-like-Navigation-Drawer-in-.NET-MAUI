namespace NavigationDrawer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPrimaryDrawerToggled(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }
    }
}
