namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new[]
        {
            "Dias Zholgali",
            "Marat Gaukhar",
            "Salimov ALikhan",
            "Basiev David",
            "Zholzhanov Alizhan"
        };
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        StudentsList.SelectedItem = null;
    }
}