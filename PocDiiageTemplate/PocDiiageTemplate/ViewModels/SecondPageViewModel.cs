namespace PocDiiageTemplate.ViewModels
{
    using Prism.Navigation;

    public class SecondPageViewModel : ViewModelBase
    {
        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
            Description = "Ceci est une description personnalisée pour la seconde page !";
        }
    }
}
