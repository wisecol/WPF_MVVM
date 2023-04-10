using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChartUI_Design_App
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BrushConverter converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            //Create DataGrid Items Info
            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John", Position = "Manager", Email = "John@anotherreal.com", Phone = "010-1234-5678" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Noah", Position = "Coach", Email = "noah@anotherreal.com", Phone = "010-2312-2345" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#f38f00"), Name = "Valeria", Position = "Administrator", Email = "valeria@anotherreal.com", Phone = "010-2575-8654" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ivan", Position = "Manager", Email = "ivan@anotherreal.com", Phone = "010-6112-2357" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Jeorge", Position = "Manager", Email = "jeorge@anotherreal.com", Phone = "010-2265-7564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Reza", Position = "Coach", Email = "reze@gamil.com", Phone = "010-5321-6504" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Alvion", Position = "Coach", Email = "alvion@naver.com", Phone = "010-2376-0989" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Nia", Position = "Coach", Email = "nia@hanmail.net", Phone = "010-7543-3450" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Naldo", Position = "Coach", Email = "naldo@gmail.com", Phone = "010-2675-9909" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Rose", Position = "Coach", Email = "rose@naver.com", Phone = "010-6754-4564" });

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John", Position = "Manager", Email = "John@anotherreal.com", Phone = "010-1234-5678" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Noah", Position = "Coach", Email = "noah@anotherreal.com", Phone = "010-2312-2345" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Valeria", Position = "Administrator", Email = "valeria@anotherreal.com", Phone = "010-2575-8654" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ivan", Position = "Manager", Email = "ivan@anotherreal.com", Phone = "010-6542-2357" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Jeorge", Position = "Manager", Email = "jeorge@anotherreal.com", Phone = "010-2265-7564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Reza", Position = "Coach", Email = "reze@gamil.com", Phone = "010-5321-6504" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Alvion", Position = "Coach", Email = "alvion@naver.com", Phone = "010-2376-0989" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Nia", Position = "Coach", Email = "nia@hanmail.net", Phone = "010-7543-3450" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Naldo", Position = "Coach", Email = "naldo@gmail.com", Phone = "010-2675-9909" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Rose", Position = "Coach", Email = "rose@naver.com", Phone = "010-6754-4564" });

            members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John", Position = "Manager", Email = "John@anotherreal.com", Phone = "010-1234-5678" });
            members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Noah", Position = "Coach", Email = "noah@anotherreal.com", Phone = "010-2312-2345" });
            members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Valeria", Position = "Administrator", Email = "valeria@anotherreal.com", Phone = "010-2575-8654" });
            members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Ivan", Position = "Manager", Email = "ivan@anotherreal.com", Phone = "010-6542-2357" });
            members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Jeorge", Position = "Manager", Email = "jeorge@anotherreal.com", Phone = "010-2265-7564" });
            members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741d9"), Name = "Reza", Position = "Coach", Email = "reze@gamil.com", Phone = "010-5321-6504" });
            members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#ff6d00"), Name = "Alvion", Position = "Coach", Email = "alvion@naver.com", Phone = "010-2376-0989" });
            members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff5252"), Name = "Nia", Position = "Coach", Email = "nia@hanmail.net", Phone = "010-7543-3450" });
            members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Naldo", Position = "Coach", Email = "naldo@gmail.com", Phone = "010-2675-9909" });
            members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0ca678"), Name = "Rose", Position = "Coach", Email = "rose@naver.com", Phone = "010-6754-4564" });

            membersDataGrid.ItemsSource = members;

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if(e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
            }

        }
    }

    public class Member
    {
        public string Character { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Brush BgColor { get; set; }
       
    }

}
