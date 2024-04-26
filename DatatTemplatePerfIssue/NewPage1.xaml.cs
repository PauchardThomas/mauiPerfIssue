using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DatatTemplatePerfIssue;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
        delay.LoadView();
    }
}