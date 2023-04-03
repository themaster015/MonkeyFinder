namespace MonkeyFinder.ViewModel;

[QueryProperty("Monkey", "Monkey")]

public partial class MonkeyDetailViewModel : BaseViewModel
{
    public MonkeyDetailViewModel()
    {
        
    }

    [ObservableProperty]
    Monkey monkey;
}
