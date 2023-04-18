using PersonInfo.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonInfo.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            SaveCommand = new SaveCommand();
        }

        public ICommand SaveCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public int Id { get; set; } = 5;
        public string Name { get; set; } = "홍길동";
        public string Sex { get; set; } = "남자";
        public int Age { get; set; } = 31;

    }
}
