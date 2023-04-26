using PersonList.Models;
using PersonList.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonList.Commands
{
    public class SaveCommand : ICommand
    {
        private MainWindowModel _mainWindowModel;

        //텍스트박스 데이터 가져오기.
        private Person GetPerson()
        {
            Person person = new Person();
            person.Name = _mainWindowModel.Name;
            person.Sex = _mainWindowModel.Sex;
            int.TryParse(_mainWindowModel.Id, out int id);
            int.TryParse(_mainWindowModel.Age, out int age);
            person.Id = id;
            person.Age = age;
            
            return person;
        }

        //저장 버튼 실행 여부(텍스트박스 조건 안 맞으면 비활성화)
        private bool IsValidSave(Person person)
        {
            if(person.Id <= 0)return false;
            if (string.IsNullOrWhiteSpace(person.Name)) return false;
            if (string.IsNullOrWhiteSpace(person.Sex)) return false;
            if (person.Age <= 0) return false;
            return true;
        }

        //Execute 실행시 텍스트박스 정보 리스트 저장 후 삭제. 리스트뷰 출력
        private void Save()
        {
            Person person = GetPerson();
            if(person != null)
            {
                //리스트뷰에 동일Id 탐색 후 없으면 추가, 있으면 업데이트
                Person findPerson = _mainWindowModel._personLst.Find(x => x.Id == person.Id);
                if(findPerson!=null)
                    findPerson.UpdateData(person);
                else
                    _mainWindowModel._personLst.Add(person);
                                
                _mainWindowModel.Clear();
                _mainWindowModel.DisplayListView();
            }

        }

        //생성자
        public SaveCommand(MainWindowModel mainWindowModel)
        {
            _mainWindowModel = mainWindowModel;
        }

        //true 시 Execute로 넘어감
        public override bool CanExecute(object parameter)
        {
            return IsValidSave(GetPerson());
        }

        public override void Execute(object parameter)
        {            
            Save();
        }

    }
}
