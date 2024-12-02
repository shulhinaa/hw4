using System.Collections.ObjectModel;
using System.Windows.Input;

namespace task4.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Item _selectedItem;

        public ObservableCollection<Item> Items { get; } = new();

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(); 
                    ((Command)DeleteItemCommand).ChangeCanExecute();
                }
            }
        }

        public ICommand NavigateToAddItemCommand { get; }
        public ICommand DeleteItemCommand { get; }

        public MainViewModel()
        {
            Items.Add(new Product
            {
                Name = "Milk",
                Price = 40.50m,
                CountryOfOrigin = "Ukraine",
                PackagingDate = DateTime.Now.AddDays(-2),
                Description = "Fresh milk from local farms",
                Quantity = 1,
            });

            Items.Add(new Book
            {
                Name = "Atomic Habits",
                Price = 1000.00m,
                CountryOfOrigin = "USA",
                PackagingDate = DateTime.Now.AddDays(-10),
                Description = "An international bestseller",
                Publisher = "Penguin Classics",
            });

            NavigateToAddItemCommand = new Command(async () => await NavigateToAddItemPage());
            DeleteItemCommand = new Command(DeleteItem, () => SelectedItem != null);
        }

        private async Task NavigateToAddItemPage()
        {
            var addItemPage = new AddItemPage
            {
                BindingContext = new AddItemViewModel(OnNewItemAdded)
            };
            await Application.Current.MainPage.Navigation.PushAsync(addItemPage);
        }

        private void OnNewItemAdded(Item newItem)
        {
            if (newItem != null)
            {
                Items.Add(newItem);
            }
        }

        private void DeleteItem()
        {
            if (SelectedItem != null)
            {
                Items.Remove(SelectedItem);
                SelectedItem = null;
            }
        }
    }
}





