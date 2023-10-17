using MauiApp1.Controls;
using MauiApp1.Views;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        //count++;

        //if (count == 1)
        //	CounterBtn.Text = $"Clicked {count} time";
        //else
        //	CounterBtn.Text = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);

        Navigation.PushAsync(new ContentPageDemo());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private void text_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TextControlsDemo());
    }

    private void Presentation_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PresentationControlsDemo());

    }

    private void Input_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControlsDemo());

    }

    private void Commands_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CommandsControlsDemo());

    }

    private void Collection_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CollectionsControlsDemo());

    }

    private void Activity_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActivityControlsDemo());

    }
}

