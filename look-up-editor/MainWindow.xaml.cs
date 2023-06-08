using DevExpress.Mvvm.Native;
using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace look_up_editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            Products = new Data();

            command = new RelayCommand(OnClickAction);
        }

        public ICommand command { get; }

        private void OnClickAction(object? sender)
        {
            MessageBox.Show($"Product ID : {this.SelectedItem?.ID}, Product Name : {this.SelectedItem?.ProductName}");
        }

        public ObservableCollection<Product>? products { get; set; }
        public ObservableCollection<Product>? Products
        {
            get => products;
            set
            {
                products = value;
                NotifyPropertyChanged(nameof(Products));
            }
        }

        private Product? selectedItem { get; set; }
        public Product? SelectedItem {
            get => selectedItem;
            set
            {
                selectedItem = value;
                NotifyPropertyChanged(nameof(SelectedItem));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RelayCommand : ICommand
    {
        private Action<object?>? action { get; set; }
        public RelayCommand(Action<object?>? action) 
        { 
            this.action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            this.action?.Invoke(parameter);
        }
    }
}
