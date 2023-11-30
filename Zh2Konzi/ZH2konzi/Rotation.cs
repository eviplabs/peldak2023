using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ZH2konzi
{
    public class Rotation : INotifyPropertyChanged
    {
        private int _degree = 0;
        private string propertyName;

        public int Degree {
            get
            {
                return _degree;
            }
            set
            {
                _degree = value;
                Notify(nameof(Degree));
            }
        }

        private void Notify(string propertyName)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
