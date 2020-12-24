namespace PocDiiageTemplate.ViewModels
{
    using Prism.Commands;
    using Prism.Navigation;

    public class SecondPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private DelegateCommand _delegateCommand;
        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _availablePseudo;
        public string AvailablePseudo
        {
            get { return _availablePseudo; }
            set { SetProperty(ref _availablePseudo, value); }
        }

        private string _pseudo;
        public string Pseudo
        {
            get { return _pseudo; }
            set { SetProperty(ref _pseudo, value); }
        }

        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Second Page";
            Description = "Entrer un pseudo :";
            AvailablePseudo = "Ce pseudo est disponible !";
            Pseudo = "";
        }

        public DelegateCommand buttonClick => _delegateCommand = new DelegateCommand(Button_Clicked);

        private async void Button_Clicked()
        {
            NavigationParameters navigationParams = new NavigationParameters();
            navigationParams.Add("Pseudo", Pseudo);
            await _navigationService.NavigateAsync("MainPage", navigationParams);
        }
    }
}
