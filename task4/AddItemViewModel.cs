using System;
using System.Windows.Input;

namespace task4.ViewModels
{
    public class AddItemViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public DateTime PackagingDate { get; set; } = DateTime.Now;
        public string Description { get; set; }

        public ICommand AddCommand { get; }
        public ICommand CancelCommand { get; }

        private readonly Action<Item> _onItemAdded;

        public AddItemViewModel(Action<Item> onItemAdded)
        {
            _onItemAdded = onItemAdded;

            AddCommand = new Command(AddItem);
            CancelCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
        }

        private void AddItem()
        {
            if (string.IsNullOrWhiteSpace(Name) || Price <= 0)
            {
                App.Current.MainPage.DisplayAlert("Помилка", "Будь ласка, заповніть всі поля правильно.", "OK");
                return;
            }

            var newItem = new Item
            {
                Name = Name,
                Price = Price,
                CountryOfOrigin = CountryOfOrigin,
                PackagingDate = PackagingDate,
                Description = Description
            };

            _onItemAdded?.Invoke(newItem);

            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}

