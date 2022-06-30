using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiApp2
{
    public class MainPageViewModel : ObservableObject
    {
        public IRelayCommand ClickedCommand { get; set; }


        private bool _isWorking;

        public bool IsWorking
        {
            get { return _isWorking; }
            set { SetProperty(ref _isWorking, value); }
        }

        public MainPageViewModel()
        {
            ClickedCommand = new RelayCommand(Clicked);

            // If false "space" for Label is never created only apears after orientation change
            //IsWorking = false;

            // If true "space" is created and visibility can be toggled
            IsWorking = true;
        }

        private void Clicked() 
        {
            if (IsWorking)
                IsWorking = false;
            else
                IsWorking = true;
        }

    }
}
