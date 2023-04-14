using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic_Training.Model
{
    class ViewModel : Notifier
    {
        string lastName = string.Empty;//성
        string firstName = string.Empty;//이름
        string fullName = string.Empty;//성명
        string birth = string.Empty;
        bool isBirthError = false;

        public string LastName {
            get { return lastName; }
            set
            {
                lastName = value;
                fullName = lastName + firstName;
                //이름 및 성명 전체 수정
                NotifyChanged("LastName", "FullName");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                fullName = lastName + firstName;
                //성 및 성명 전체 수정
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
                //입력 문자열에서 일치하는 항목을 찾을 것인지 여부 나타냄
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
                    return $"생년월일은 숫자로 입력해 주세요 : {birth}";
            }
        }

    }
}
