using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNumber.Model
{
    class MainModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        //test
        private int inputNum = 1;
        private int resNum = 1;

        public int InputNum
        {
            get { return inputNum; }
            set
            {
                inputNum = value;
                ResNum = value * 2;
                OnPropertyChanged("InputNum");
            } 
        }
        public int ResNum
        {
            get { return resNum; }
            set
            {
                resNum = value;
                OnPropertyChanged("ResNum");
            }
        }
    }
}
