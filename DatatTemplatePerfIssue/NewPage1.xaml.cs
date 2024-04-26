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
        tb1.Load();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        tb2.Load();
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        tb3.Load();
    }
}