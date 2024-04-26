UI Thread frozen when loading view



https://github.com/PauchardThomas/mauiPerfIssue/assets/9884985/826f67d5-bc6a-4725-a8d4-22f0df552a67

Main View :

```xaml
 <StackLayout>
     <Button BackgroundColor="Black" Clicked="Button_Clicked" HorizontalOptions="Center" Text="Load Data" TextColor="White" WidthRequest="200" />
     <Label x:Name="lbLoaded" FontSize="Large" HorizontalOptions="Center" VerticalOptions="Center" />
     <VerticalStackLayout x:Name="Rows" Spacing="10">
         <BindableLayout.ItemTemplate>
             <DataTemplate x:DataType="local:Row">
                 <Grid RowDefinitions="45,1">
                     <Grid Grid.Row="0" ColumnDefinitions="auto,auto,*" ColumnSpacing="10">
                         <Label Grid.Column="0" Text="{Binding Title, Mode=OneTime}" />
                         <Label Grid.Column="1" Text="{Binding Description, Mode=OneTime}" />
                         <HorizontalStackLayout Grid.Column="2" BindableLayout.ItemsSource="{Binding Cols, Mode=OneTime}" Spacing="10" WidthRequest="500">
                             <BindableLayout.ItemTemplate>
                                 <DataTemplate x:DataType="local:Col">
                                     <HorizontalStackLayout WidthRequest="100">
                                         <Border HeightRequest="25" Stroke="Blue" WidthRequest="25" />
                                         <Border HeightRequest="25" Stroke="Green" WidthRequest="25" />
                                         <Border HeightRequest="25" Stroke="Orange" WidthRequest="25" />
                                         <Border HeightRequest="25" Stroke="Red" WidthRequest="25" />
                                     </HorizontalStackLayout>
                                 </DataTemplate>
                             </BindableLayout.ItemTemplate>
                         </HorizontalStackLayout>
                     </Grid>
                     <BoxView Grid.Row="1" BackgroundColor="Black" />
                 </Grid>
             </DataTemplate>
         </BindableLayout.ItemTemplate>
     </VerticalStackLayout>
 </StackLayout>
```

Loading data : 

```csharp
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
```
