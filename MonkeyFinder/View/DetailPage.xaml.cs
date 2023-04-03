namespace MonkeyFinder.View;

public partial class DetailPage : ContentPage
{
    public DetailPage(MonkeyDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}