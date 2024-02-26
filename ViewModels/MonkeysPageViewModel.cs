using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MonkeysMVVM.Models;
using MonkeysMVVM.Services;

namespace MonkeysMVVM.ViewModels
{
    public class MonkeysPageViewModel : ViewModel
    {
        private MonkeysService service;
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public Monkey SelectedMonkey { get; set; }
        public ICommand LoadMonkeysCommand { get; private set; }
        public ICommand GoToShowMonkeyView {  get; private set; }
        MonkeysPageViewModel(MonkeysService s)
        {
            service = s;

            GoToShowMonkeyView = new Command(async () => await GoToShowMonkey());
            LoadMonkeysCommand = new Command(async () => await LoadMonkeys());

            Monkeys = new ObservableCollection<Monkey>();
        }
        private async Task GoToShowMonkey()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("Monkey", SelectedMonkey);
            await AppShell.Current.GoToAsync("GoToShowMonkey", data);
        }
        private async Task LoadMonkeys()
        {
            var list = await service.GetMonkeys();
            Monkeys.Clear();
            foreach (var monkey in list)
                Monkeys.Add(monkey);
        }

    }
}
