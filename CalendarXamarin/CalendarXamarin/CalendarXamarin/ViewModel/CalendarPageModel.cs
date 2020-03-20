using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.ComponentModel;
using System.Windows.Input;

namespace CalendarXamarin
{
    public class ViewModel : INotifyPropertyChanged
    {
        private void LeftHandleAction(object obj)
        {
            (obj as SfCalendar).Backward();
        }
        private void RightHandleAction(object obj)
        {
            (obj as SfCalendar).Forward();
        }

        public ViewModel()
        {
            LeftCommand = new Command(LeftHandleAction);
            RightCommand = new Command(RightHandleAction);
        }

        private string selectedMonth = DateTime.Now.ToString("Y");
        public string SelectedMonth
        {
            get { return selectedMonth; }
            set
            {
                selectedMonth = value;
                NotifyPropertyChanged("SelectedMonth");
            }
        }
        private ICommand leftCommand;
        public ICommand LeftCommand
        {
            get { return leftCommand; }
            set { leftCommand = value; }
        }
        private ICommand rightCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ICommand RightCommand
        {
            get { return rightCommand; }
            set { rightCommand = value; }
        }
    }
}
