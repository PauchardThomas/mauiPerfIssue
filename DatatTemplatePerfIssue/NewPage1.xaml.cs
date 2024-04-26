using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DatatTemplatePerfIssue;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        switcher.SelectedIndex = 0;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        switcher.SelectedIndex = 1;
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        switcher.SelectedIndex = 2;
    }
}