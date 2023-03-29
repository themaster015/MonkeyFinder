namespace MonkeyFinder.ViewModel;
using MonkeyFinder.Services;

public partial class MonkeyViewModel : BaseViewModel
{
    MonkeyService _monkeyService;

    public ObservableCollection<Monkey> Monkeys { get;} = new();


    public MonkeyViewModel(MonkeyService monkeyService)
    {
        Title = "Monkey Finder";
        _monkeyService = monkeyService;
    }

    [RelayCommand]
    async Task GetMonkeysAsync()
    {
        if (IsBusy) { return; }

        try
        {
            IsBusy = true;

            var monkeys = await _monkeyService.GetMonkeys();

            if (Monkeys.Count != 0) { monkeys.Clear(); }

            foreach (var monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error", "No se pudo obtener los monos", "Ok");
        } 
        finally
        {
            IsBusy = false;
        }
    }
}
