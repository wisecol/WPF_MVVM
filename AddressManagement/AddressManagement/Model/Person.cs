using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace AddressManagement.Model
{
    public class Person : ReactiveObject
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { this.RaiseAndSetIfChanged(ref _name, value); }
        }

        private bool _gender;

        public bool Gender
        {
            get { return _gender; }
            set { this.RaiseAndSetIfChanged(ref _gender, value); }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { this.RaiseAndSetIfChanged(ref _phoneNumber, value); }
        }

        private string _address;
       
        public string Address
        {
            get { return _address; }
            set { this.RaiseAndSetIfChanged(ref _address, value); }
        }

        public Person()
        {

        }

        public Person(Person input)
        {
            _name = input.Name;
            _gender = input.Gender;
            _phoneNumber = input.PhoneNumber;
            _address = input.Address;
        }


    }
}
