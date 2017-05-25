using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataTriggerTest
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            this.PropertyChanged(this,new PropertyChangedEventArgs(PropertyName));
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        private Command _trigger;
        public Command Trigger
        {
            get
            {
                return _trigger
                    ?? (_trigger = new Command(
                    () =>
                    {
                        IsSelected = !IsSelected;
                    }));
            }
        }
    }
}
