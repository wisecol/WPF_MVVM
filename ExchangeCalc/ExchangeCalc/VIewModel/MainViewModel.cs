using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ExchangeCalc.Model;

namespace ExchangeCalc.VIewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MainModel model = null;

        public MainViewModel()
        {
            model = new MainModel();
        }

        public string Dollar
        {
            get
            {
                if (string.IsNullOrEmpty(model.Dollar))
                    Won = "0";
                else
                {
                    int num = -1;
                    if(int.TryParse(model.Dollar,out num))
                    {
                        int res = num * 1240;
                        Won = res.ToString();
                    }
                    else
                    {
                        Dollar = "";
                        Won = "0";
                    }
                }
                return model.Dollar;   
            }
            set
            {
                if (model.Dollar != value)
                {
                    model.Dollar = value;
                    OnPropertyChanged("Dollar");
                }
            }
        }

        public string Won
        {
            get { return model.Won; }
            set { model.Won = value; OnPropertyChanged("Won"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
