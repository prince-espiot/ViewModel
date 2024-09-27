
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ViewModel.Model;
using ViewModel.MVVM;
namespace ViewModel.ViewModel
{
    internal class MainWindowViewModal:ViewModalBase

    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindowViewModal()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = " Prince",
                SerialNumber = "00041",
                Quantity = "5"
            });
            Items.Add(new Item
            {
                Name = "Prosper",
                SerialNumber = "10545",
                Quantity = "8"
            });
        }
        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set {
                selectedItem = value;
                OnPropertyChanged();
            
            }
        }

       

    }
}
