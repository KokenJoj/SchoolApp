using System.Collections.ObjectModel;
using System.ComponentModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel : INotifyPropertyChanged
{
    private string _newName = "";

    public ObservableCollection<Student> Students { get; } = new();

    public string NewName
    {
        get => _newName;
        set
        {
            _newName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewName)));
        }
    }

    public StudentsViewModel()
    {
        Students.Add(new Student { Name = "Zholqali Dias", Gpa = 3.85 });
        Students.Add(new Student { Name = "Salimov Alikhan", Gpa = 3.20 });
        Students.Add(new Student { Name = "Marat Gaukhar", Gpa = 3.95 });
        Students.Add(new Student { Name = "Erkinbek Eren", Gpa = 2.75 });
        Students.Add(new Student { Name = "Bassiev David", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName))
        {
            return;
        }

        Students.Add(new Student { Name = NewName.Trim(), Gpa = 3.0 });
        NewName = "";
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
