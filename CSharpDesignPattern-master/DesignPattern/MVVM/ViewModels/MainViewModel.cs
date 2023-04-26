using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfTutorials.DesignPattern.Models;
using WpfTutorials.DesignPattern.MVVM.Commands;

namespace WpfTutorials.DesignPattern.MVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IPersonRepository _personRepository;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //if(PropertyChanged!=null)
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Delete(object _)
        {
            int.TryParse(Id, out int id);
            if (_personRepository.DeleteOne(id))
            {
                Clear();
                DisplayListView();
            }
        }

        public MainViewModel(Models.IPersonRepository personRepository)
        {
            _personRepository = personRepository;
            SaveCommand = new SaveCommand(this, personRepository);
            DeleteCommand = new RelayCommand<object>(Delete);
            DisplayListView();
        }

        public void Clear()
        {
            Id = "";
            Name = "";
            Sex = "";
            Age = "";
            OnPropertyChanged("People");
        }
        // '!' 사용 시 null 값 허용
        public void DisplayListView()
        {
            Poeple = new ObservableCollection<Person>(_personRepository.GetAll()!);
            OnPropertyChanged("People");
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }

        public ObservableCollection<Person> Poeple { get; set; }

    }
}
