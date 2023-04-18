using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.ComponentModel;

namespace AddressManagement.Model
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }

        private string _name;
        private string _gender;
        private int _phoneNumber;
        private string _address;

        public string Name { get => _name; set => _name = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }

        public Person()
        {

        }

        public Person(Person input)
        {
            Name = input.Name;
            Gender = input.Gender;
            PhoneNumber = input.PhoneNumber;
            Address = input.Address;
        }


    }
}
