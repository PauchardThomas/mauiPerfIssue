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
        ObservableCollection<Col> cols = new ObservableCollection<Col>();
        for (int i = 0; i < 8; i++)
        {
            cols.Add(new Col("Title" + i));
        }
        ObservableCollection<Row> rows = new ObservableCollection<Row>();
        for (int i = 0; i < 5; i++)
        {
            rows.Add(new Row("Row " + i, "Description " + i, cols));
        }

        var timer = new Stopwatch();
        timer.Start();
        BindableLayout.SetItemsSource(Rows, rows);
        timer.Stop();

        TimeSpan timeTaken = timer.Elapsed;
        string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
        Console.Out.WriteLine(foo);
        lbLoaded.Text = foo;
    }
}