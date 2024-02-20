using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfIdeas;

partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    DateOfWeek dateOfWeek;
}
