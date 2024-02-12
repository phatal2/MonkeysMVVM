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
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public ICommand LoadMonkeysCommand { get; private set; }
        MonkeysPageViewModel()
        { 
            Monkeys = new ObservableCollection<Monkey>();
        }
        private async Task LoadMonkeys()
        {
            MonkeysService service = new MonkeysService();
            var list = await service.GetMonkeys();
            Monkeys.Clear();
            foreach (var monkey in list)
                Monkeys.Add(monkey);
            
        }
    }
}
