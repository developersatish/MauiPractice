using MauiApp1.AppsDemo;
using MauiApp1.ColorMaker;
using MauiApp1.Controls;
using MauiApp1.Pages;

namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

      //  MainPage = new AppShell();

        var navPage = new NavigationPage(new MainPage());

        navPage.BarBackground = Colors.Chocolate;
        navPage.BarTextColor = Colors.White;

        //  MainPage = navPage;
        // MainPage = new Tabbed();

        // MainPage = new Flyout();

        // MainPage=new StackLayoutDemo();

        // MainPage = new ActivityControlsDemo();

        //MainPage = new FlexLayoutPage();

        // MainPage = new ColorMakerView();
        MainPage = new PerfectPayView();
    }
}
