using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    class ToDoModel: INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

        private bool _isDone;
        private string _text;
        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        public string Text
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }
        private string _text1;

        public string text1
        {
            get { return _text1; }
            set
            {
                if (_text1 == value)
                    return;
                _text1 = value;
                OnPropertyChanged(" text1 ");
            }
        }
        private string _text2;

        public string text2
        {
            get { return _text2; }
            set 
            {
                if (_text2 == value)
                    return;
                _text2 = value;
                OnPropertyChanged("text2");
            }
        }
        private string _text3;

        public string text3
        {
            get { return _text3; }
            set 
            {
                if (_text3 == value)
                    return;
                _text3 = value;
                OnPropertyChanged("text3");
            }
        }
        private string _text4;

        public string text4
        {
            get { return _text4; }
            set 
            {
                if (_text4 == value)
                    return;
                _text4 = value;
                OnPropertyChanged("text4");
            }
        }
        private bool _isDone2;

        public bool IsDone2
        {
            get { return _isDone2; }
            set 
            {
                if (_isDone2 == value)
                    return;
                _isDone2 = value;
                OnPropertyChanged("IsDone2");
            }
        }







        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = " " )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            
        }

    }
    
}
