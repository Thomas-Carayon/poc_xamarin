namespace PocDiiageTemplate.ViewModels
{
    using Prism.Commands;
    using Prism.Navigation;

    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private DelegateCommand _delegateCommand;

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Main Page";
        }

        public DelegateCommand buttonClick => _delegateCommand = new DelegateCommand(Button_Clicked);
        private async void Button_Clicked()
        {
            await _navigationService.NavigateAsync("SecondPage");
        }
    }
}
