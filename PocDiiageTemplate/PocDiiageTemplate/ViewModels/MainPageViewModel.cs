namespace PocDiiageTemplate.ViewModels
{
    using Prism.Commands;
    using Prism.Navigation;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private DelegateCommand _delegateCommand;

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private List<string> _pseudos;
        public List<string> Pseudos
        {
            get { return _pseudos; }
            set { SetProperty(ref _pseudos, value); }
        }

        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Main Page";
            Message = "Bienvenue sur l'application ! Voici la liste de vos anciens pseudos :";
            Pseudos = new List<string>() { "Hello", "World" };
            GetMyBeers();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Message = "Bienvenue sur l'application " + parameters["Pseudo"] + " !";
        }

        public DelegateCommand buttonClick => _delegateCommand = new DelegateCommand(Button_Clicked);
        private async void Button_Clicked()
        {
            await _navigationService.NavigateAsync("SecondPage");
        }

        private async void GetMyBeers()
        {
            ClientHttp myClient = new ClientHttp();
            var toto = await myClient.GetBeerAsync();
            System.Console.WriteLine(toto);
        }
    }
}
