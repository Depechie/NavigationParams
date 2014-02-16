using Cimbalino.Phone.Toolkit.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace NavigationParams.ViewModel
{
    public class Page2ViewModel : ViewModelBase
    {
        public RelayCommand ViewLoadedCommand { get; protected set; }

        private bool _viewLoadedCommandEnabled = true;
        private INavigationService _navigationService;

        public bool ViewLoadedCommandEnabled
        {
            get
            {
                return _viewLoadedCommandEnabled;
            }
            set
            {
                if (_viewLoadedCommandEnabled == value)
                    return;

                _viewLoadedCommandEnabled = value;
                RaisePropertyChanged("ViewLoadedCommandEnabled");
            }
        }

        public Page2ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            this.ViewLoadedCommand = new RelayCommand(() => ViewLoaded());
        }

        private void ViewLoaded()
        {
            var r = _navigationService.QueryString["param"];
        }
    }
}
