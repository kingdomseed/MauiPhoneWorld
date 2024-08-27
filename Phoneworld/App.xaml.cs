namespace Phoneworld;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell(); // Initial Window is created here (MainPage) with UI resources defined in xaml in front.
    }
}