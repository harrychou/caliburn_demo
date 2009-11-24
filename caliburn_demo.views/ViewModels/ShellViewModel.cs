using System;
using Caliburn.Core;

namespace caliburn_demo.wpf.ViewModels
{
    public class ShellViewModel : PropertyChangedBase
    {
        private string _message;
        string _name;

        public ShellViewModel()
        {
            Message = "My First Message";
            Name = "Harry";
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                ChangeMessage();
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                NotifyOfPropertyChange("Message");
            }
        }

        public void ChangeMessage()
        {
            Message = "Hello World, " + Name + " - " + DateTime.Now;
        }
    }
}