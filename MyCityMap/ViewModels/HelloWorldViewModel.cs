using Caliburn.Micro;

namespace MyCityMap.ViewModels
{
    public class HelloWorldViewModel : BaseViewModel
    {
        private INavigationService _pageNavigationService;

        public HelloWorldViewModel(INavigationService pageNavigationService)
        {
            _pageNavigationService = pageNavigationService;
        }

        private string _myMessage;
        public string MyMessage
        {
            get { return _myMessage; }
            set
            {
                _myMessage = value;
                NotifyOfPropertyChange(() => MyMessage);
            }
        }

        public void SayHello()
        {
            MyMessage = "Hello World!";
        }
    }
}
