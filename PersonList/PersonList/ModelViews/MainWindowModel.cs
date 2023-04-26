using PersonList.Commands;
using PersonList.Models;
using PersonList.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonList.ModelViews
{
    public class MainWindowModel : Notifier
    {
        private string _id;
        private string _name;
        private string _sex;
        private string _age;
        private ObservableCollection<Person> _people;
        public List<Person> _personLst = new List<Person>(); 
        

        //삭제 
        private void Delete(object _)
        {
            int.TryParse(Id, out int id);
            int Delidx = _personLst.FindIndex(x => x.Id == id);
            if (Delidx > -1)
            {
                _personLst.RemoveAt(Delidx);
                Clear();
                DisplayListView();
            }
                
        }

        private bool CanDelete(object _)
        {
            int.TryParse(_id, out int id);
            return id > 0;
        }


        public MainWindowModel()
        {
            SaveCommand = new SaveCommand(this);
            DeleteCommand = new RelayCommand<object>(Delete, CanDelete);
            CancelCommand = new RelayCommand<object>(_ => Clear());
            MouseLeftButtonUpCommand = new RelayCommand<Person>(MouseLeftButtonUp);
            DisplayListView();
        }

        //변수 초기화
        public void Clear()
        {
            Id = "";
            Name = "";
            Sex = "";
            Age = "";
        }

        private void MouseLeftButtonUp(Person person)
        {
            if(person==null) return;
            Id=person.Id.ToString();
            Name = person.Name;
            Sex = person.Sex;
            Age = person.Age.ToString();
        }

        //리스트뷰 재정의
        public void DisplayListView()
        {
            People = new ObservableCollection<Person>(_personLst);
        }

        public System.Windows.Input.ICommand SaveCommand { get; set; }
        public System.Windows.Input.ICommand DeleteCommand { get; set; }
        public System.Windows.Input.ICommand CancelCommand { get; set; }
        public System.Windows.Input.ICommand MouseLeftButtonUpCommand { get; set; }

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        
        public string Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
                OnPropertyChanged();
            }
        }
        
        public string Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                _people = value;
                OnPropertyChanged();
            }
        }

    }
}
