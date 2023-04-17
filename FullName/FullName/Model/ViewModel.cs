using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FullName.Model
{
    class ViewModel : Notifier
    {
        string lastName = string.Empty;
        string firstname = string.Empty;
        string fullName = string.Empty;
        string birth = string.Empty;
        bool isBirthError = false;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                fullName = lastName + firstname;
                NotifyChanged("LastName", "FullName");
            }
        }

        public string FirstName
        {
            get { return firstname; }
            set
            {
                firstname = value;
                fullName = lastName + firstname;
                NotifyChanged("FirstName", "FullName");
            }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public string Birth
        {
            get { return birth; }
            set
            {
                if(Regex.IsMatch(value, "^[0-9]*$"))
                {
                    birth = value;
                    isBirthError = false;
                }
                else
                {
                    birth = value;
                    isBirthError = true;
                }
                NotifyChanged("Birth");
                NotifyChanged("BirthErr");
                NotifyChanged("BirthErrMsg");
            }
        }

        public bool BirthErr
        {
            get { return isBirthError; }
        }

        public string BirthErrMsg
        {
            get
            {
                if (!isBirthError)
                    return $"입력하신 생년월일 : {birth}";
                else
                    return $"생년월일은 숫자로 입력해 주세요. : {birth}";
            }
        }


    }
}
