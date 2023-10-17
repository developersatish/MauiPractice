using System.Diagnostics;

namespace MauiApp1.Controls;

public partial class TextControlsDemo : ContentPage
{
    public TextControlsDemo()
    {
        InitializeComponent();
    }
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Debug.WriteLine(txtName.Text);
    }
}