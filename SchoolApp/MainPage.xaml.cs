namespace SchoolApp;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCheckClicked(object sender, EventArgs e)
    {
        _count++;
        StatusLabel.Text = $"Button clicked: {_count} times";
    }
    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }
}